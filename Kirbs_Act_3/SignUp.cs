using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kirbs_Act_3
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            ApplyTransparentOverGradient();
        }

        private void ApplyTransparentOverGradient()
        {
            Control[] overlayControls = { pictureBox2, label1, label7, label8 };
            foreach (Control ctrl in overlayControls)
            {
                Point screenPos = ctrl.Location;
                ctrl.Parent = pictureBox3;
                ctrl.Location = new Point(screenPos.X - pictureBox3.Location.X, screenPos.Y - pictureBox3.Location.Y);
                ctrl.BackColor = Color.Transparent;
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPass.Checked;
            password.UseSystemPasswordChar = !show;
            cPassword.UseSystemPasswordChar = !show;
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            string fullName = name.Text.Trim();
            string user = userName.Text.Trim();
            string pass = password.Text;
            string confirmPass = cPassword.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cPassword.Clear();
                cPassword.Focus();
                return;
            }

            if (Database.RegisterUser(fullName, user, pass, out string errorMsg))
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NavigateToSignIn();
            }
            else
            {
                MessageBox.Show(errorMsg, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToSignIn_Click(object sender, EventArgs e)
        {
            NavigateToSignIn();
        }

        private void NavigateToSignIn()
        {
            signIn signInForm = new signIn();
            signInForm.Show();
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

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}