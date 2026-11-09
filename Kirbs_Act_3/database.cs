using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;

namespace Kirbs_Act_3
{
    public class UserAccount
    {
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public static class Database
    {
        public static string ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ResolveDatabasePath()};Persist Security Info=False;";

        private static string ResolveDatabasePath()
        {
            DirectoryInfo? directory = new DirectoryInfo(AppContext.BaseDirectory);

            while (directory != null)
            {
                string databasePath = Path.Combine(directory.FullName, "ArkiDatabase.accdb");
                if (File.Exists(databasePath) && Directory.GetFiles(directory.FullName, "*.csproj").Length > 0)
                    return databasePath;

                directory = directory.Parent;
            }

            return Path.Combine(AppContext.BaseDirectory, "ArkiDatabase.accdb");
        }

        private const int HashIterations = 210000;
        private const int SaltSize = 16;
        private const int HashSize = 32;

        private static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, HashIterations, HashAlgorithmName.SHA256, HashSize);
            return $"PBKDF2${HashIterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }

        private static bool VerifyPassword(string password, string storedPassword)
        {
            if (!storedPassword.StartsWith("PBKDF2$", StringComparison.Ordinal))
                return string.Equals(password, storedPassword, StringComparison.Ordinal);

            string[] parts = storedPassword.Split('$');
            if (parts.Length != 4 || parts[0] != "PBKDF2" ||
                !int.TryParse(parts[1], out int iterations) || iterations < 10000 || iterations > 1000000)
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] expectedHash = Convert.FromBase64String(parts[3]);
                byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, expectedHash.Length);
                return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool RegisterUser(string fullName, string username, string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();

                    using (OleDbCommand checkCmd = new OleDbCommand("SELECT COUNT(*) FROM Users WHERE [Username] = ?", conn))
                    {
                        checkCmd.Parameters.Add("@Username", OleDbType.VarWChar).Value = username;
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            errorMessage = "Username is already taken.";
                            return false;
                        }
                    }

                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Users ([FullName], [Username], [Password]) VALUES (?, ?, ?)", conn))
                    {
                        cmd.Parameters.Add("@FullName", OleDbType.VarWChar).Value = fullName;
                        cmd.Parameters.Add("@Username", OleDbType.VarWChar).Value = username;
                        cmd.Parameters.Add("@Password", OleDbType.VarWChar, 255).Value = HashPassword(password);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "Database error: " + ex.Message;
                return false;
            }
        }

        public static UserAccount? ValidateLogin(string username, string password)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand("SELECT [FullName], [Username], [Password] FROM Users WHERE [Username] = ?", conn))
                    {
                        cmd.Parameters.Add("@Username", OleDbType.VarWChar).Value = username;

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                                return null;

                            string fullName = reader["FullName"]?.ToString() ?? string.Empty;
                            string accountUsername = reader["Username"]?.ToString() ?? username;
                            string storedPassword = reader["Password"]?.ToString() ?? string.Empty;
                            if (!VerifyPassword(password, storedPassword))
                                return null;

                            reader.Close();

                            if (!storedPassword.StartsWith("PBKDF2$", StringComparison.Ordinal))
                            {
                                using (OleDbCommand updateCmd = new OleDbCommand("UPDATE Users SET [Password] = ? WHERE [Username] = ?", conn))
                                {
                                    updateCmd.Parameters.Add("@Password", OleDbType.VarWChar, 255).Value = HashPassword(password);
                                    updateCmd.Parameters.Add("@Username", OleDbType.VarWChar).Value = accountUsername;
                                    updateCmd.ExecuteNonQuery();
                                }
                            }

                            return new UserAccount
                            {
                                FullName = fullName,
                                Username = accountUsername,
                                Password = string.Empty
                            };
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Username", typeof(string));

            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                conn.Open();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT [FullName], [Username] FROM Users", conn))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
