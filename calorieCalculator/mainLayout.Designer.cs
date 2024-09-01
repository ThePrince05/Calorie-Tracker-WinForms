namespace calorieCalculator
{
    partial class mainLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainLayout));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_editProfile = new FontAwesome.Sharp.IconButton();
            this.btn_manageFood = new FontAwesome.Sharp.IconButton();
            this.btn_history = new FontAwesome.Sharp.IconButton();
            this.btn_logMeal = new FontAwesome.Sharp.IconButton();
            this.btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.iconPictureBox_user = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_minimize = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_user)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btn_editProfile);
            this.panelMenu.Controls.Add(this.btn_manageFood);
            this.panelMenu.Controls.Add(this.btn_history);
            this.panelMenu.Controls.Add(this.btn_logMeal);
            this.panelMenu.Controls.Add(this.btn_dashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 670);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btn_editProfile
            // 
            this.btn_editProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_editProfile.FlatAppearance.BorderSize = 0;
            this.btn_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_editProfile.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btn_editProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_editProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editProfile.IconSize = 39;
            this.btn_editProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editProfile.Location = new System.Drawing.Point(0, 600);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_editProfile.Size = new System.Drawing.Size(220, 70);
            this.btn_editProfile.TabIndex = 6;
            this.btn_editProfile.Text = "Edit Profile";
            this.btn_editProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editProfile.UseVisualStyleBackColor = true;
            this.btn_editProfile.Click += new System.EventHandler(this.btn_editProfile_Click);
            // 
            // btn_manageFood
            // 
            this.btn_manageFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manageFood.FlatAppearance.BorderSize = 0;
            this.btn_manageFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_manageFood.IconChar = FontAwesome.Sharp.IconChar.Carrot;
            this.btn_manageFood.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_manageFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_manageFood.IconSize = 32;
            this.btn_manageFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageFood.Location = new System.Drawing.Point(0, 372);
            this.btn_manageFood.Name = "btn_manageFood";
            this.btn_manageFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_manageFood.Size = new System.Drawing.Size(220, 70);
            this.btn_manageFood.TabIndex = 5;
            this.btn_manageFood.Text = "Manage Food";
            this.btn_manageFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_manageFood.UseVisualStyleBackColor = true;
            this.btn_manageFood.Click += new System.EventHandler(this.btn_manageFood_Click);
            // 
            // btn_history
            // 
            this.btn_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_history.FlatAppearance.BorderSize = 0;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_history.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.btn_history.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_history.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_history.IconSize = 32;
            this.btn_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.Location = new System.Drawing.Point(0, 302);
            this.btn_history.Name = "btn_history";
            this.btn_history.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_history.Size = new System.Drawing.Size(220, 70);
            this.btn_history.TabIndex = 4;
            this.btn_history.Text = "History";
            this.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_logMeal
            // 
            this.btn_logMeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logMeal.FlatAppearance.BorderSize = 0;
            this.btn_logMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logMeal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_logMeal.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btn_logMeal.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_logMeal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logMeal.IconSize = 32;
            this.btn_logMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logMeal.Location = new System.Drawing.Point(0, 232);
            this.btn_logMeal.Name = "btn_logMeal";
            this.btn_logMeal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_logMeal.Size = new System.Drawing.Size(220, 70);
            this.btn_logMeal.TabIndex = 3;
            this.btn_logMeal.Text = "Log Meal";
            this.btn_logMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logMeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logMeal.UseVisualStyleBackColor = true;
            this.btn_logMeal.Click += new System.EventHandler(this.btn_logMeal_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.HeartPulse;
            this.btn_dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dashboard.IconSize = 32;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 162);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(220, 70);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lbl_logout);
            this.panelLogo.Controls.Add(this.lbl_username);
            this.panelLogo.Controls.Add(this.iconPictureBox_user);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 162);
            this.panelLogo.TabIndex = 2;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_logout.Location = new System.Drawing.Point(122, 128);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(64, 22);
            this.lbl_logout.TabIndex = 4;
            this.lbl_logout.Text = "Logout";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            this.lbl_logout.MouseLeave += new System.EventHandler(this.lbl_logout_MouseLeave);
            this.lbl_logout.MouseHover += new System.EventHandler(this.lbl_logout_MouseHover);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_username.Location = new System.Drawing.Point(46, 88);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(27, 20);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "??";
            // 
            // iconPictureBox_user
            // 
            this.iconPictureBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox_user.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox_user.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox_user.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_user.IconSize = 54;
            this.iconPictureBox_user.Location = new System.Drawing.Point(81, 12);
            this.iconPictureBox_user.Name = "iconPictureBox_user";
            this.iconPictureBox_user.Size = new System.Drawing.Size(57, 54);
            this.iconPictureBox_user.TabIndex = 2;
            this.iconPictureBox_user.TabStop = false;
            this.iconPictureBox_user.Click += new System.EventHandler(this.iconPictureBox_user_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btn_minimize);
            this.panelTitleBar.Controls.Add(this.btn_close);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(980, 75);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_close.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.Location = new System.Drawing.Point(924, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(56, 75);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitleChildForm.Location = new System.Drawing.Point(646, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(180, 42);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Welcome";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(980, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(980, 586);
            this.panelDesktop.TabIndex = 4;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "Listen up, meatbag !!!";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(10, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 258);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(721, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Calorie Tracker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_minimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimize.Location = new System.Drawing.Point(868, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(56, 75);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // mainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 670);
            this.Name = "mainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainLayout";
            this.Load += new System.EventHandler(this.mainLayout_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_user)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_dashboard;
        private FontAwesome.Sharp.IconButton btn_manageFood;
        private FontAwesome.Sharp.IconButton btn_history;
        private FontAwesome.Sharp.IconButton btn_logMeal;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_user;
        private System.Windows.Forms.Label lbl_username;
        private FontAwesome.Sharp.IconButton btn_editProfile;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton btn_minimize;
    }
}