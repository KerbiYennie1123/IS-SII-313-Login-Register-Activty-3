namespace Kirbs_Act_3
{
    partial class signIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userName = new TextBox();
            password = new TextBox();
            label5 = new Label();
            showPass = new Button();
            login = new Button();
            label6 = new Label();
            signUp = new Button();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-323, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(814, 722);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 BlkEx BT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 205);
            label1.Name = "label1";
            label1.Size = new Size(399, 56);
            label1.TabIndex = 1;
            label1.Text = "Information";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 360);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 1;
            label2.Text = "Welcome Back!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Blk BT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.Location = new Point(548, 82);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 2;
            label3.Text = "Sign In";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(550, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // userName
            // 
            userName.BackColor = Color.FromArgb(248, 249, 250);
            userName.BorderStyle = BorderStyle.FixedSingle;
            userName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(553, 182);
            userName.Name = "userName";
            userName.PlaceholderText = "Enter your username";
            userName.Size = new Size(275, 32);
            userName.TabIndex = 4;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(248, 249, 250);
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(553, 262);
            password.Name = "password";
            password.PlaceholderText = "Enter your password";
            password.Size = new Size(195, 32);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(550, 235);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // showPass
            // 
            showPass.BackColor = Color.FromArgb(238, 240, 243);
            showPass.Cursor = Cursors.Hand;
            showPass.FlatAppearance.BorderColor = Color.Silver;
            showPass.FlatStyle = FlatStyle.Flat;
            showPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPass.ForeColor = Color.FromArgb(50, 50, 50);
            showPass.Location = new Point(754, 262);
            showPass.Name = "showPass";
            showPass.Size = new Size(74, 32);
            showPass.TabIndex = 7;
            showPass.Text = "Show";
            showPass.UseVisualStyleBackColor = false;
            showPass.Click += showPass_Click;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(236, 42, 108);
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(553, 355);
            login.Name = "login";
            login.Size = new Size(275, 42);
            login.TabIndex = 9;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(90, 90, 90);
            label6.Location = new Point(553, 422);
            label6.Name = "label6";
            label6.Size = new Size(171, 21);
            label6.TabIndex = 10;
            label6.Text = "Don't have an account?";
            // 
            // signUp
            // 
            signUp.BackColor = Color.Transparent;
            signUp.Cursor = Cursors.Hand;
            signUp.FlatAppearance.BorderSize = 0;
            signUp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signUp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            signUp.FlatStyle = FlatStyle.Flat;
            signUp.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUp.ForeColor = Color.FromArgb(236, 42, 108);
            signUp.Location = new Point(724, 417);
            signUp.Name = "signUp";
            signUp.Size = new Size(80, 30);
            signUp.TabIndex = 11;
            signUp.Text = "Sign Up";
            signUp.UseVisualStyleBackColor = false;
            signUp.Click += signUp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Swis721 BlkEx BT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 275);
            label7.Name = "label7";
            label7.Size = new Size(265, 56);
            label7.TabIndex = 12;
            label7.Text = "System";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(64, 64, 64);
            checkBox1.Location = new Point(553, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // signIn
            // 
            AcceptButton = login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 566);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(signUp);
            Controls.Add(label6);
            Controls.Add(login);
            Controls.Add(showPass);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(userName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "signIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in - Arki Information System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox userName;
        private TextBox password;
        private Label label5;
        private Button showPass;
        private Button login;
        private Label label6;
        private Button signUp;
        private PictureBox pictureBox2;
        private Label label7;
        private CheckBox checkBox1;
    }
}