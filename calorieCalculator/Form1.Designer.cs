namespace calorieCalculator
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_createUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Calorie Tracker Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.Black;
            this.lbl_userName.Location = new System.Drawing.Point(54, 80);
            this.lbl_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(120, 28);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "Username";
            this.lbl_userName.Click += new System.EventHandler(this.lbl_userName_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(59, 124);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(291, 31);
            this.txt_username.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(59, 171);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 44);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(241, 171);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 44);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_createUser
            // 
            this.lbl_createUser.AutoSize = true;
            this.lbl_createUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createUser.ForeColor = System.Drawing.Color.Black;
            this.lbl_createUser.Location = new System.Drawing.Point(4, 10);
            this.lbl_createUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_createUser.Name = "lbl_createUser";
            this.lbl_createUser.Size = new System.Drawing.Size(119, 26);
            this.lbl_createUser.TabIndex = 5;
            this.lbl_createUser.Text = "Create User";
            this.lbl_createUser.Click += new System.EventHandler(this.lbl_createUser_Click);
            this.lbl_createUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_createUser_MouseClick);
            this.lbl_createUser.MouseLeave += new System.EventHandler(this.lbl_createUser_MouseLeave);
            this.lbl_createUser.MouseHover += new System.EventHandler(this.lbl_createUser_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_createUser);
            this.panel1.Location = new System.Drawing.Point(321, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 49);
            this.panel1.TabIndex = 6;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(481, 347);
            this.MinimumSize = new System.Drawing.Size(481, 347);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_createUser;
        private System.Windows.Forms.Panel panel1;
    }
}

