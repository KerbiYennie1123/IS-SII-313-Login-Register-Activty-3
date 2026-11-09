namespace Kirbs_Act_3
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnRefresh = new Button();
            btnDashboard = new Button();
            panelHeader = new Panel();
            lblWelcomeUser = new Label();
            lblTitle = new Label();
            panelContent = new Panel();
            YochiroWave = new PictureBox();
            dataGridViewUsers = new DataGridView();
            lblGridTitle = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YochiroWave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 32, 38);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnRefresh);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 620);
            panelSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(236, 42, 108);
            btnLogout.Location = new Point(0, 540);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 50);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(0, 268);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(240, 50);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh Users";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(45, 48, 56);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 208);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(240, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(lblWelcomeUser);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(240, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(762, 70);
            panelHeader.TabIndex = 1;
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.FromArgb(60, 60, 60);
            lblWelcomeUser.Location = new Point(480, 20);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(146, 25);
            lblWelcomeUser.TabIndex = 1;
            lblWelcomeUser.Text = "Welcome, User!";
            lblWelcomeUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Swis721 Blk BT", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(25, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Arki Information System";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(245, 247, 250);
            panelContent.Controls.Add(YochiroWave);
            panelContent.Controls.Add(dataGridViewUsers);
            panelContent.Controls.Add(lblGridTitle);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 70);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(762, 550);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // YochiroWave
            // 
            YochiroWave.BackColor = Color.WhiteSmoke;
            YochiroWave.Image = (Image)resources.GetObject("YochiroWave.Image");
            YochiroWave.Location = new Point(447, 151);
            YochiroWave.Name = "YochiroWave";
            YochiroWave.Size = new Size(434, 399);
            YochiroWave.SizeMode = PictureBoxSizeMode.StretchImage;
            YochiroWave.TabIndex = 4;
            YochiroWave.TabStop = false;
            YochiroWave.Click += YochiroWave_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.WhiteSmoke;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(30, 75);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(700, 430);
            dataGridViewUsers.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblGridTitle.Location = new Point(30, 25);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(279, 32);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Registered System Users";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 620);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Arki Information System";
            Load += Dashboard_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YochiroWave).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelHeader;
        private Panel panelContent;
        private Button btnDashboard;
        private Button btnRefresh;
        private Button btnLogout;
        private Label lblTitle;
        private Label lblWelcomeUser;
        private Label lblGridTitle;
        private DataGridView dataGridViewUsers;
        private PictureBox pictureBox1;
        private PictureBox YochiroWave;
    }
}