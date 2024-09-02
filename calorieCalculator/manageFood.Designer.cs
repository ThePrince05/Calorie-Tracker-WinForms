namespace calorieCalculator
{
    partial class manageFood
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
            this.DGV_manageFood = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_foodName = new System.Windows.Forms.TextBox();
            this.lbl_foodName = new System.Windows.Forms.Label();
            this.txt_calories = new System.Windows.Forms.TextBox();
            this.lbl_calories = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_foodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_calories = new System.Windows.Forms.RadioButton();
            this.radioButton_kilojoules = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_serving = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_manageFood
            // 
            this.DGV_manageFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_manageFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGV_manageFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_manageFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_manageFood.Location = new System.Drawing.Point(902, 224);
            this.DGV_manageFood.Name = "DGV_manageFood";
            this.DGV_manageFood.ReadOnly = true;
            this.DGV_manageFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_manageFood.RowHeadersWidth = 51;
            this.DGV_manageFood.RowTemplate.Height = 24;
            this.DGV_manageFood.Size = new System.Drawing.Size(433, 481);
            this.DGV_manageFood.TabIndex = 3;
            this.DGV_manageFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_manageFood_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(767, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 481);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_foodName
            // 
            this.txt_foodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodName.Location = new System.Drawing.Point(286, 335);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.Size = new System.Drawing.Size(301, 31);
            this.txt_foodName.TabIndex = 21;
            this.txt_foodName.TextChanged += new System.EventHandler(this.txt_foodName_TextChanged);
            // 
            // lbl_foodName
            // 
            this.lbl_foodName.AutoSize = true;
            this.lbl_foodName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_foodName.Location = new System.Drawing.Point(281, 304);
            this.lbl_foodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodName.Name = "lbl_foodName";
            this.lbl_foodName.Size = new System.Drawing.Size(130, 28);
            this.lbl_foodName.TabIndex = 20;
            this.lbl_foodName.Text = "Food Name";
            this.lbl_foodName.Click += new System.EventHandler(this.lbl_foodName_Click);
            // 
            // txt_calories
            // 
            this.txt_calories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calories.Location = new System.Drawing.Point(281, 499);
            this.txt_calories.Name = "txt_calories";
            this.txt_calories.Size = new System.Drawing.Size(301, 31);
            this.txt_calories.TabIndex = 23;
            this.txt_calories.TextChanged += new System.EventHandler(this.txt_calories_TextChanged);
            // 
            // lbl_calories
            // 
            this.lbl_calories.AutoSize = true;
            this.lbl_calories.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calories.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_calories.Location = new System.Drawing.Point(276, 468);
            this.lbl_calories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_calories.Name = "lbl_calories";
            this.lbl_calories.Size = new System.Drawing.Size(325, 28);
            this.lbl_calories.TabIndex = 22;
            this.lbl_calories.Text = "Per 100 grams or Per Serving";
            this.lbl_calories.Click += new System.EventHandler(this.lbl_calories_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(281, 605);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(147, 41);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(440, 605);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 41);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_foodID
            // 
            this.txt_foodID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodID.Location = new System.Drawing.Point(286, 255);
            this.txt_foodID.Name = "txt_foodID";
            this.txt_foodID.ReadOnly = true;
            this.txt_foodID.Size = new System.Drawing.Size(96, 31);
            this.txt_foodID.TabIndex = 51;
            this.txt_foodID.TextChanged += new System.EventHandler(this.txt_foodID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(281, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Food ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_calories
            // 
            this.radioButton_calories.AutoSize = true;
            this.radioButton_calories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_calories.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton_calories.Location = new System.Drawing.Point(6, 24);
            this.radioButton_calories.Name = "radioButton_calories";
            this.radioButton_calories.Size = new System.Drawing.Size(112, 27);
            this.radioButton_calories.TabIndex = 52;
            this.radioButton_calories.TabStop = true;
            this.radioButton_calories.Text = "Calories";
            this.radioButton_calories.UseVisualStyleBackColor = true;
            this.radioButton_calories.CheckedChanged += new System.EventHandler(this.radioButton_calories_CheckedChanged);
            // 
            // radioButton_kilojoules
            // 
            this.radioButton_kilojoules.AutoSize = true;
            this.radioButton_kilojoules.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_kilojoules.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton_kilojoules.Location = new System.Drawing.Point(128, 24);
            this.radioButton_kilojoules.Name = "radioButton_kilojoules";
            this.radioButton_kilojoules.Size = new System.Drawing.Size(125, 27);
            this.radioButton_kilojoules.TabIndex = 53;
            this.radioButton_kilojoules.TabStop = true;
            this.radioButton_kilojoules.Text = "Kilojoules";
            this.radioButton_kilojoules.UseVisualStyleBackColor = true;
            this.radioButton_kilojoules.CheckedChanged += new System.EventHandler(this.radioButton_kilojoules_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_kilojoules);
            this.groupBox1.Controls.Add(this.radioButton_calories);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(286, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 64);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurement";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(440, 664);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 41);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(281, 664);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(147, 41);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AppleAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 169;
            this.iconPictureBox1.Location = new System.Drawing.Point(685, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(171, 169);
            this.iconPictureBox1.TabIndex = 57;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(1364, 339);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(137, 41);
            this.btn_cancel.TabIndex = 86;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(1364, 292);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(137, 41);
            this.btn_search.TabIndex = 85;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(1364, 237);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(161, 31);
            this.txt_search.TabIndex = 84;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(1359, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 28);
            this.label11.TabIndex = 83;
            this.label11.Text = "Search";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // checkBox_serving
            // 
            this.checkBox_serving.AutoSize = true;
            this.checkBox_serving.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_serving.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_serving.Location = new System.Drawing.Point(281, 548);
            this.checkBox_serving.Name = "checkBox_serving";
            this.checkBox_serving.Size = new System.Drawing.Size(197, 31);
            this.checkBox_serving.TabIndex = 87;
            this.checkBox_serving.Text = "Is it a Serving?";
            this.checkBox_serving.UseVisualStyleBackColor = true;
            this.checkBox_serving.CheckedChanged += new System.EventHandler(this.checkBox_serving_CheckedChanged);
            // 
            // manageFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1537, 840);
            this.Controls.Add(this.checkBox_serving);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_foodID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_calories);
            this.Controls.Add(this.lbl_calories);
            this.Controls.Add(this.txt_foodName);
            this.Controls.Add(this.lbl_foodName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_manageFood);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "manageFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Food";
            this.Load += new System.EventHandler(this.addFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_manageFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_foodName;
        private System.Windows.Forms.Label lbl_foodName;
        private System.Windows.Forms.TextBox txt_calories;
        private System.Windows.Forms.Label lbl_calories;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_foodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_calories;
        private System.Windows.Forms.RadioButton radioButton_kilojoules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_serving;
    }
}