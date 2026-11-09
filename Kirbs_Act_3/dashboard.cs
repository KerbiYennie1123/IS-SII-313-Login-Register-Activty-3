using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kirbs_Act_3
{
    public partial class Dashboard : Form
    {
        private string currentUser;

        public Dashboard(string userFullName)
        {
            currentUser = userFullName;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeUser.Text = $"Welcome, {currentUser}!";
            LoadUserData();

            YochiroWave.BackColor = Color.Transparent;
            if (YochiroWave.Image != null)
            {
                Bitmap bmp = new Bitmap(YochiroWave.Image);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        if (pixelColor.R > 240 && pixelColor.G > 240 && pixelColor.B > 240)
                        {
                            bmp.SetPixel(x, y, Color.Transparent);
                        }
                    }
                }
                YochiroWave.Image = bmp;
            }
        }

        private void LoadUserData()
        {
            try
            {
                dataGridViewUsers.DataSource = Database.GetAllUsers();
            }
            catch (Exception)
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserData();
            MessageBox.Show("User list refreshed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            signIn loginForm = new signIn();
            loginForm.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void YochiroWave_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}