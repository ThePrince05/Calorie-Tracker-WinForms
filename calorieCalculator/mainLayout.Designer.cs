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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_editProfile = new FontAwesome.Sharp.IconButton();
            this.btn_manageFood = new FontAwesome.Sharp.IconButton();
            this.btn_history = new FontAwesome.Sharp.IconButton();
            this.btn_logMeal = new FontAwesome.Sharp.IconButton();
            this.btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox_user = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_user)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(220, 623);
            this.panelMenu.TabIndex = 1;
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
            this.btn_editProfile.Location = new System.Drawing.Point(0, 563);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_editProfile.Size = new System.Drawing.Size(220, 60);
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
            this.btn_manageFood.Location = new System.Drawing.Point(0, 320);
            this.btn_manageFood.Name = "btn_manageFood";
            this.btn_manageFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_manageFood.Size = new System.Drawing.Size(220, 60);
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
            this.btn_history.Location = new System.Drawing.Point(0, 260);
            this.btn_history.Name = "btn_history";
            this.btn_history.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_history.Size = new System.Drawing.Size(220, 60);
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
            this.btn_logMeal.Location = new System.Drawing.Point(0, 200);
            this.btn_logMeal.Name = "btn_logMeal";
            this.btn_logMeal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_logMeal.Size = new System.Drawing.Size(220, 60);
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
            this.btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.btn_dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dashboard.IconSize = 32;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 140);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(220, 60);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.iconPictureBox_user);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "??";
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
            // 
            // mainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.panelMenu);
            this.Name = "mainLayout";
            this.Text = "mainLayout";
            this.Load += new System.EventHandler(this.mainLayout_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_user)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_editProfile;
    }
}