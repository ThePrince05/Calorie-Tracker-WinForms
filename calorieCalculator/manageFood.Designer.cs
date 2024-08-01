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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageFood));
            this.lbl_manageFood = new System.Windows.Forms.Label();
            this.DGV_manageFood = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_foodName = new System.Windows.Forms.TextBox();
            this.lbl_foodName = new System.Windows.Forms.Label();
            this.txt_calories = new System.Windows.Forms.TextBox();
            this.lbl_calories = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_foodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_calories = new System.Windows.Forms.RadioButton();
            this.radioButton_kilojoules = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_manageFood
            // 
            this.lbl_manageFood.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manageFood.ForeColor = System.Drawing.Color.Black;
            this.lbl_manageFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_manageFood.Location = new System.Drawing.Point(297, 9);
            this.lbl_manageFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manageFood.Name = "lbl_manageFood";
            this.lbl_manageFood.Size = new System.Drawing.Size(270, 47);
            this.lbl_manageFood.TabIndex = 2;
            this.lbl_manageFood.Text = "Manage Food";
            // 
            // DGV_manageFood
            // 
            this.DGV_manageFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_manageFood.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV_manageFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_manageFood.Location = new System.Drawing.Point(465, 271);
            this.DGV_manageFood.Name = "DGV_manageFood";
            this.DGV_manageFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_manageFood.RowHeadersWidth = 51;
            this.DGV_manageFood.RowTemplate.Height = 24;
            this.DGV_manageFood.Size = new System.Drawing.Size(423, 450);
            this.DGV_manageFood.TabIndex = 3;
            this.DGV_manageFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_manageFood_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(411, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_foodName
            // 
            this.txt_foodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodName.Location = new System.Drawing.Point(18, 382);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.Size = new System.Drawing.Size(291, 31);
            this.txt_foodName.TabIndex = 21;
            // 
            // lbl_foodName
            // 
            this.lbl_foodName.AutoSize = true;
            this.lbl_foodName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodName.ForeColor = System.Drawing.Color.Black;
            this.lbl_foodName.Location = new System.Drawing.Point(13, 351);
            this.lbl_foodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodName.Name = "lbl_foodName";
            this.lbl_foodName.Size = new System.Drawing.Size(130, 28);
            this.lbl_foodName.TabIndex = 20;
            this.lbl_foodName.Text = "Food Name";
            // 
            // txt_calories
            // 
            this.txt_calories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calories.Location = new System.Drawing.Point(13, 546);
            this.txt_calories.Name = "txt_calories";
            this.txt_calories.Size = new System.Drawing.Size(291, 31);
            this.txt_calories.TabIndex = 23;
            this.txt_calories.TextChanged += new System.EventHandler(this.txt_calories_TextChanged);
            // 
            // lbl_calories
            // 
            this.lbl_calories.AutoSize = true;
            this.lbl_calories.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calories.ForeColor = System.Drawing.Color.Black;
            this.lbl_calories.Location = new System.Drawing.Point(8, 515);
            this.lbl_calories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_calories.Name = "lbl_calories";
            this.lbl_calories.Size = new System.Drawing.Size(164, 28);
            this.lbl_calories.TabIndex = 22;
            this.lbl_calories.Text = "Per 100 grams";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(13, 621);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 41);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(172, 621);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(137, 41);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_foodID
            // 
            this.txt_foodID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodID.Location = new System.Drawing.Point(18, 302);
            this.txt_foodID.Name = "txt_foodID";
            this.txt_foodID.ReadOnly = true;
            this.txt_foodID.Size = new System.Drawing.Size(86, 31);
            this.txt_foodID.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Food ID";
            // 
            // radioButton_calories
            // 
            this.radioButton_calories.AutoSize = true;
            this.radioButton_calories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_calories.Location = new System.Drawing.Point(6, 24);
            this.radioButton_calories.Name = "radioButton_calories";
            this.radioButton_calories.Size = new System.Drawing.Size(112, 27);
            this.radioButton_calories.TabIndex = 52;
            this.radioButton_calories.TabStop = true;
            this.radioButton_calories.Text = "Calories";
            this.radioButton_calories.UseVisualStyleBackColor = true;
            // 
            // radioButton_kilojoules
            // 
            this.radioButton_kilojoules.AutoSize = true;
            this.radioButton_kilojoules.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_kilojoules.Location = new System.Drawing.Point(128, 24);
            this.radioButton_kilojoules.Name = "radioButton_kilojoules";
            this.radioButton_kilojoules.Size = new System.Drawing.Size(125, 27);
            this.radioButton_kilojoules.TabIndex = 53;
            this.radioButton_kilojoules.TabStop = true;
            this.radioButton_kilojoules.Text = "Kilojoules";
            this.radioButton_kilojoules.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_kilojoules);
            this.groupBox1.Controls.Add(this.radioButton_calories);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 64);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurement";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(172, 680);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 41);
            this.btn_delete.TabIndex = 55;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(13, 680);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 41);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // addFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 767);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_foodID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_calories);
            this.Controls.Add(this.lbl_calories);
            this.Controls.Add(this.txt_foodName);
            this.Controls.Add(this.lbl_foodName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_manageFood);
            this.Controls.Add(this.lbl_manageFood);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Name = "addFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFood";
            this.Load += new System.EventHandler(this.addFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageFood;
        private System.Windows.Forms.DataGridView DGV_manageFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_foodName;
        private System.Windows.Forms.Label lbl_foodName;
        private System.Windows.Forms.TextBox txt_calories;
        private System.Windows.Forms.Label lbl_calories;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_foodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_calories;
        private System.Windows.Forms.RadioButton radioButton_kilojoules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}