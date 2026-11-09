namespace Kirbs_Act_3
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            userName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            password = new TextBox();
            label5 = new Label();
            cPassword = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label6 = new Label();
            createAcc = new Button();
            label8 = new Label();
            btnBackToSignIn = new Button();
            lblHaveAccount = new Label();
            chkShowPass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(389, -61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(814, 722);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(709, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 BlkEx BT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 30, 30);
            label1.Location = new Point(475, 205);
            label1.Name = "label1";
            label1.Size = new Size(399, 56);
            label1.TabIndex = 16;
            label1.Text = "Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Swis721 BlkEx BT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(30, 30, 30);
            label7.Location = new Point(609, 275);
            label7.Name = "label7";
            label7.Size = new Size(265, 56);
            label7.TabIndex = 17;
            label7.Text = "System";
            // 
            // userName
            // 
            userName.BackColor = Color.FromArgb(248, 249, 250);
            userName.BorderStyle = BorderStyle.FixedSingle;
            userName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(45, 197);
            userName.Name = "userName";
            userName.PlaceholderText = "Choose a username";
            userName.Size = new Size(275, 32);
            userName.TabIndex = 2;
            userName.TextChanged += userName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(42, 172);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 18;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.Location = new Point(42, 42);
            label3.Name = "label3";
            label3.Size = new Size(271, 36);
            label3.TabIndex = 20;
            label3.Text = "Create Account";
            label3.Click += label3_Click;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(248, 249, 250);
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(45, 269);
            password.Name = "password";
            password.PlaceholderText = "Create a password";
            password.Size = new Size(275, 32);
            password.TabIndex = 3;
            password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(42, 244);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 21;
            label5.Text = "Password";
            // 
            // cPassword
            // 
            cPassword.BackColor = Color.FromArgb(248, 249, 250);
            cPassword.BorderStyle = BorderStyle.FixedSingle;
            cPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cPassword.Location = new Point(45, 341);
            cPassword.Name = "cPassword";
            cPassword.PlaceholderText = "Re-enter your password";
            cPassword.Size = new Size(275, 32);
            cPassword.TabIndex = 4;
            cPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(42, 316);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 23;
            label2.Text = "Confirm Password";
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(248, 249, 250);
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(45, 125);
            name.Name = "name";
            name.PlaceholderText = "Enter your full name";
            name.Size = new Size(275, 32);
            name.TabIndex = 1;
            name.TextChanged += name_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(42, 100);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 25;
            label6.Text = "Full Name";
            // 
            // createAcc
            // 
            createAcc.BackColor = Color.FromArgb(236, 42, 108);
            createAcc.Cursor = Cursors.Hand;
            createAcc.FlatAppearance.BorderSize = 0;
            createAcc.FlatStyle = FlatStyle.Flat;
            createAcc.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAcc.ForeColor = Color.White;
            createAcc.Location = new Point(45, 422);
            createAcc.Name = "createAcc";
            createAcc.Size = new Size(275, 42);
            createAcc.TabIndex = 6;
            createAcc.Text = "Create Account";
            createAcc.UseVisualStyleBackColor = false;
            createAcc.Click += createAcc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(40, 40, 40);
            label8.Location = new Point(730, 355);
            label8.Name = "label8";
            label8.Size = new Size(138, 30);
            label8.TabIndex = 28;
            label8.Text = "Join us now!";
            // 
            // btnBackToSignIn
            // 
            btnBackToSignIn.BackColor = Color.Transparent;
            btnBackToSignIn.Cursor = Cursors.Hand;
            btnBackToSignIn.FlatAppearance.BorderSize = 0;
            btnBackToSignIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBackToSignIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBackToSignIn.FlatStyle = FlatStyle.Flat;
            btnBackToSignIn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToSignIn.ForeColor = Color.FromArgb(236, 42, 108);
            btnBackToSignIn.Location = new Point(230, 477);
            btnBackToSignIn.Name = "btnBackToSignIn";
            btnBackToSignIn.Size = new Size(76, 30);
            btnBackToSignIn.TabIndex = 7;
            btnBackToSignIn.Text = "Sign In";
            btnBackToSignIn.UseVisualStyleBackColor = false;
            btnBackToSignIn.Click += btnBackToSignIn_Click;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.BackColor = Color.Transparent;
            lblHaveAccount.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHaveAccount.ForeColor = Color.FromArgb(90, 90, 90);
            lblHaveAccount.Location = new Point(45, 482);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(186, 21);
            lblHaveAccount.TabIndex = 29;
            lblHaveAccount.Text = "Already have an account?";
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPass.ForeColor = Color.FromArgb(64, 64, 64);
            chkShowPass.Location = new Point(45, 383);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(140, 24);
            chkShowPass.TabIndex = 5;
            chkShowPass.Text = "Show passwords";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // SignUp
            // 
            AcceptButton = createAcc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 566);
            Controls.Add(btnBackToSignIn);
            Controls.Add(lblHaveAccount);
            Controls.Add(chkShowPass);
            Controls.Add(label8);
            Controls.Add(createAcc);
            Controls.Add(name);
            Controls.Add(label6);
            Controls.Add(cPassword);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(userName);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up - Arki Information System";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private TextBox userName;
        private TextBox password;
        private TextBox cPassword;
        private TextBox name;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label6;
        private Button createAcc;
        private Label label8;
        private Button btnBackToSignIn;
        private Label lblHaveAccount;
        private CheckBox chkShowPass;
    }
}