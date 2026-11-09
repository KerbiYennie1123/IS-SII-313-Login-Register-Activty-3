using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kirbs_Act_3
{
    public partial class signIn : Form
    {
        private static string rememberedUsername = string.Empty;

        public signIn()
        {
            InitializeComponent();
            ApplyTransparentOverGradient();
        }

        private void ApplyTransparentOverGradient()
        {
            Control[] overlayControls = { pictureBox2, label1, label7, label2 };
            foreach (Control ctrl in overlayControls)
            {
                Point screenPos = ctrl.Location;
                ctrl.Parent = pictureBox1;
                ctrl.Location = new Point(screenPos.X - pictureBox1.Location.X, screenPos.Y - pictureBox1.Location.Y);
                ctrl.BackColor = Color.Transparent;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rememberedUsername))
            {
                userName.Text = rememberedUsername;
                checkBox1.Checked = true;
                password.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void showPass_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
            showPass.Text = password.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = userName.Text.Trim();
            string pass = password.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserAccount? account = Database.ValidateLogin(user, pass);
            if (account != null)
            {
                rememberedUsername = checkBox1.Checked ? user : string.Empty;
                Dashboard dashboard = new Dashboard(account.FullName);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Clear();
                password.Focus();
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}