namespace calorieCalculator
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_userHeight = new System.Windows.Forms.TextBox();
            this.lbl_userHeight = new System.Windows.Forms.Label();
            this.txt_userWeight = new System.Windows.Forms.TextBox();
            this.lbl_userWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(103, 215);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(291, 31);
            this.txt_name.TabIndex = 4;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.Black;
            this.lbl_userName.Location = new System.Drawing.Point(98, 184);
            this.lbl_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(194, 28);
            this.lbl_userName.TabIndex = 3;
            this.lbl_userName.Text = "Enter your Name";
            this.lbl_userName.Click += new System.EventHandler(this.lbl_userName_Click);
            // 
            // txt_userHeight
            // 
            this.txt_userHeight.Location = new System.Drawing.Point(103, 419);
            this.txt_userHeight.Name = "txt_userHeight";
            this.txt_userHeight.Size = new System.Drawing.Size(291, 31);
            this.txt_userHeight.TabIndex = 6;
            this.txt_userHeight.TextChanged += new System.EventHandler(this.txt_userHeight_TextChanged);
            // 
            // lbl_userHeight
            // 
            this.lbl_userHeight.AutoSize = true;
            this.lbl_userHeight.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userHeight.ForeColor = System.Drawing.Color.Black;
            this.lbl_userHeight.Location = new System.Drawing.Point(98, 388);
            this.lbl_userHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userHeight.Name = "lbl_userHeight";
            this.lbl_userHeight.Size = new System.Drawing.Size(205, 28);
            this.lbl_userHeight.TabIndex = 5;
            this.lbl_userHeight.Text = "Enter your Height";
            this.lbl_userHeight.Click += new System.EventHandler(this.lbl_userHeight_Click);
            // 
            // txt_userWeight
            // 
            this.txt_userWeight.Location = new System.Drawing.Point(427, 419);
            this.txt_userWeight.Name = "txt_userWeight";
            this.txt_userWeight.Size = new System.Drawing.Size(291, 31);
            this.txt_userWeight.TabIndex = 8;
            this.txt_userWeight.TextChanged += new System.EventHandler(this.txt_userWeight_TextChanged);
            // 
            // lbl_userWeight
            // 
            this.lbl_userWeight.AutoSize = true;
            this.lbl_userWeight.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userWeight.ForeColor = System.Drawing.Color.Black;
            this.lbl_userWeight.Location = new System.Drawing.Point(422, 389);
            this.lbl_userWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userWeight.Name = "lbl_userWeight";
            this.lbl_userWeight.Size = new System.Drawing.Size(209, 28);
            this.lbl_userWeight.TabIndex = 7;
            this.lbl_userWeight.Text = "Enter your Weight";
            this.lbl_userWeight.Click += new System.EventHandler(this.lbl_userWeight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select your Gender";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(103, 313);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(291, 34);
            this.comboBox_gender.TabIndex = 10;
            this.comboBox_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox_gender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please fill in your details";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(222, 495);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(172, 44);
            this.btn_enter.TabIndex = 12;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(427, 495);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(172, 44);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(427, 215);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(291, 31);
            this.txt_surname.TabIndex = 15;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.ForeColor = System.Drawing.Color.Black;
            this.lbl_surname.Location = new System.Drawing.Point(422, 184);
            this.lbl_surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(229, 28);
            this.lbl_surname.TabIndex = 14;
            this.lbl_surname.Text = "Enter your Surname";
            this.lbl_surname.Click += new System.EventHandler(this.lbl_surname_Click);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_age.Location = new System.Drawing.Point(422, 282);
            this.lbl_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(173, 28);
            this.lbl_age.TabIndex = 16;
            this.lbl_age.Text = "Enter your Age";
            this.lbl_age.Click += new System.EventHandler(this.lbl_age_Click);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(427, 316);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(291, 31);
            this.txt_age.TabIndex = 17;
            this.txt_age.TextChanged += new System.EventHandler(this.txt_age_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(793, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userWeight);
            this.Controls.Add(this.lbl_userWeight);
            this.Controls.Add(this.txt_userHeight);
            this.Controls.Add(this.lbl_userHeight);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_userName);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(811, 610);
            this.MinimumSize = new System.Drawing.Size(643, 610);
            this.Name = "addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addUser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txt_userHeight;
        private System.Windows.Forms.Label lbl_userHeight;
        private System.Windows.Forms.TextBox txt_userWeight;
        private System.Windows.Forms.Label lbl_userWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}