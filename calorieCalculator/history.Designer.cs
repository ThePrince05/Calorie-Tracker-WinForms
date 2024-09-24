namespace calorieCalculator
{
    partial class history
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_logHistory = new System.Windows.Forms.DateTimePicker();
            this.lbl_dinner = new System.Windows.Forms.Label();
            this.DGV_dinner = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_lunch = new System.Windows.Forms.DataGridView();
            this.lbl_breakfast = new System.Windows.Forms.Label();
            this.DGV_breakfast = new System.Windows.Forms.DataGridView();
            this.lbl_dinnerTotal = new System.Windows.Forms.Label();
            this.lbl_lunchTotal = new System.Windows.Forms.Label();
            this.lbl_breakfastTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel_addFood = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_mealID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_serving = new System.Windows.Forms.CheckBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.comboBox_mealType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_manageFood = new System.Windows.Forms.DataGridView();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_foodName = new System.Windows.Forms.TextBox();
            this.lbl_foodName = new System.Windows.Forms.Label();
            this.lbl_Food = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_breakfast)).BeginInit();
            this.panel_addFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_logHistory
            // 
            this.dateTimePicker_logHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_logHistory.Location = new System.Drawing.Point(594, 30);
            this.dateTimePicker_logHistory.Name = "dateTimePicker_logHistory";
            this.dateTimePicker_logHistory.Size = new System.Drawing.Size(284, 31);
            this.dateTimePicker_logHistory.TabIndex = 4;
            this.dateTimePicker_logHistory.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_dinner
            // 
            this.lbl_dinner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinner.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_dinner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dinner.Location = new System.Drawing.Point(1137, 120);
            this.lbl_dinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dinner.Name = "lbl_dinner";
            this.lbl_dinner.Size = new System.Drawing.Size(131, 30);
            this.lbl_dinner.TabIndex = 63;
            this.lbl_dinner.Text = "Dinner";
            // 
            // DGV_dinner
            // 
            this.DGV_dinner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_dinner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGV_dinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dinner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_dinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dinner.Location = new System.Drawing.Point(993, 153);
            this.DGV_dinner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_dinner.Name = "DGV_dinner";
            this.DGV_dinner.ReadOnly = true;
            this.DGV_dinner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dinner.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_dinner.RowHeadersWidth = 51;
            this.DGV_dinner.RowTemplate.Height = 24;
            this.DGV_dinner.Size = new System.Drawing.Size(422, 191);
            this.DGV_dinner.TabIndex = 62;
            this.DGV_dinner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_dinner_CellContentClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(688, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 61;
            this.label4.Text = "Lunch";
            // 
            // DGV_lunch
            // 
            this.DGV_lunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_lunch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGV_lunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_lunch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_lunch.Location = new System.Drawing.Point(535, 153);
            this.DGV_lunch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_lunch.Name = "DGV_lunch";
            this.DGV_lunch.ReadOnly = true;
            this.DGV_lunch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_lunch.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_lunch.RowHeadersWidth = 51;
            this.DGV_lunch.RowTemplate.Height = 24;
            this.DGV_lunch.Size = new System.Drawing.Size(422, 191);
            this.DGV_lunch.TabIndex = 60;
            this.DGV_lunch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_lunch_CellContentClick);
            // 
            // lbl_breakfast
            // 
            this.lbl_breakfast.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breakfast.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_breakfast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_breakfast.Location = new System.Drawing.Point(208, 120);
            this.lbl_breakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_breakfast.Name = "lbl_breakfast";
            this.lbl_breakfast.Size = new System.Drawing.Size(152, 30);
            this.lbl_breakfast.TabIndex = 59;
            this.lbl_breakfast.Text = "Breakfast";
            // 
            // DGV_breakfast
            // 
            this.DGV_breakfast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_breakfast.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGV_breakfast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_breakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_breakfast.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_breakfast.Location = new System.Drawing.Point(73, 153);
            this.DGV_breakfast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_breakfast.Name = "DGV_breakfast";
            this.DGV_breakfast.ReadOnly = true;
            this.DGV_breakfast.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_breakfast.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_breakfast.RowHeadersWidth = 51;
            this.DGV_breakfast.RowTemplate.Height = 24;
            this.DGV_breakfast.Size = new System.Drawing.Size(422, 191);
            this.DGV_breakfast.TabIndex = 58;
            this.DGV_breakfast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_breakfast_CellContentClick);
            // 
            // lbl_dinnerTotal
            // 
            this.lbl_dinnerTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinnerTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_dinnerTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dinnerTotal.Location = new System.Drawing.Point(1113, 357);
            this.lbl_dinnerTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dinnerTotal.Name = "lbl_dinnerTotal";
            this.lbl_dinnerTotal.Size = new System.Drawing.Size(192, 37);
            this.lbl_dinnerTotal.TabIndex = 84;
            this.lbl_dinnerTotal.Text = "??";
            // 
            // lbl_lunchTotal
            // 
            this.lbl_lunchTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lunchTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_lunchTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_lunchTotal.Location = new System.Drawing.Point(651, 357);
            this.lbl_lunchTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lunchTotal.Name = "lbl_lunchTotal";
            this.lbl_lunchTotal.Size = new System.Drawing.Size(192, 37);
            this.lbl_lunchTotal.TabIndex = 83;
            this.lbl_lunchTotal.Text = "??";
            // 
            // lbl_breakfastTotal
            // 
            this.lbl_breakfastTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breakfastTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_breakfastTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_breakfastTotal.Location = new System.Drawing.Point(185, 357);
            this.lbl_breakfastTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_breakfastTotal.Name = "lbl_breakfastTotal";
            this.lbl_breakfastTotal.Size = new System.Drawing.Size(192, 37);
            this.lbl_breakfastTotal.TabIndex = 82;
            this.lbl_breakfastTotal.Text = "??";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(652, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 37);
            this.label8.TabIndex = 85;
            this.label8.Text = "Total Calories";
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_total.Location = new System.Drawing.Point(718, 462);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(192, 37);
            this.lbl_total.TabIndex = 86;
            this.lbl_total.Text = "??";
            // 
            // panel_addFood
            // 
            this.panel_addFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_addFood.Controls.Add(this.btn_delete);
            this.panel_addFood.Controls.Add(this.txt_mealID);
            this.panel_addFood.Controls.Add(this.label3);
            this.panel_addFood.Controls.Add(this.btn_cancel);
            this.panel_addFood.Controls.Add(this.txt_search);
            this.panel_addFood.Controls.Add(this.label11);
            this.panel_addFood.Controls.Add(this.checkBox_serving);
            this.panel_addFood.Controls.Add(this.btn_log);
            this.panel_addFood.Controls.Add(this.comboBox_mealType);
            this.panel_addFood.Controls.Add(this.label2);
            this.panel_addFood.Controls.Add(this.label1);
            this.panel_addFood.Controls.Add(this.DGV_manageFood);
            this.panel_addFood.Controls.Add(this.txt_quantity);
            this.panel_addFood.Controls.Add(this.lbl_quantity);
            this.panel_addFood.Controls.Add(this.txt_foodName);
            this.panel_addFood.Controls.Add(this.lbl_foodName);
            this.panel_addFood.Location = new System.Drawing.Point(12, 551);
            this.panel_addFood.Name = "panel_addFood";
            this.panel_addFood.Size = new System.Drawing.Size(1451, 492);
            this.panel_addFood.TabIndex = 87;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(750, 374);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 41);
            this.btn_delete.TabIndex = 99;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_mealID
            // 
            this.txt_mealID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mealID.Location = new System.Drawing.Point(567, 382);
            this.txt_mealID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_mealID.Name = "txt_mealID";
            this.txt_mealID.ReadOnly = true;
            this.txt_mealID.Size = new System.Drawing.Size(123, 31);
            this.txt_mealID.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(563, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 97;
            this.label3.Text = "Meal ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(1248, 150);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(137, 41);
            this.btn_cancel.TabIndex = 96;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(1246, 94);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(161, 31);
            this.txt_search.TabIndex = 94;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            this.txt_search.Validating += new System.ComponentModel.CancelEventHandler(this.txt_search_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(1241, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 28);
            this.label11.TabIndex = 93;
            this.label11.Text = "Search";
            // 
            // checkBox_serving
            // 
            this.checkBox_serving.AutoSize = true;
            this.checkBox_serving.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_serving.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_serving.Location = new System.Drawing.Point(397, 156);
            this.checkBox_serving.Name = "checkBox_serving";
            this.checkBox_serving.Size = new System.Drawing.Size(197, 31);
            this.checkBox_serving.TabIndex = 92;
            this.checkBox_serving.Text = "Is it a Serving?";
            this.checkBox_serving.UseVisualStyleBackColor = true;
            // 
            // btn_log
            // 
            this.btn_log.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.Color.Black;
            this.btn_log.Location = new System.Drawing.Point(295, 242);
            this.btn_log.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(137, 41);
            this.btn_log.TabIndex = 91;
            this.btn_log.Text = "Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // comboBox_mealType
            // 
            this.comboBox_mealType.AutoCompleteCustomSource.AddRange(new string[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.comboBox_mealType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_mealType.FormattingEnabled = true;
            this.comboBox_mealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.comboBox_mealType.Location = new System.Drawing.Point(43, 156);
            this.comboBox_mealType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_mealType.Name = "comboBox_mealType";
            this.comboBox_mealType.Size = new System.Drawing.Size(291, 35);
            this.comboBox_mealType.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 89;
            this.label2.Text = "Meal Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(870, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 88;
            this.label1.Text = "Food Database";
            // 
            // DGV_manageFood
            // 
            this.DGV_manageFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_manageFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGV_manageFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_manageFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_manageFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_manageFood.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_manageFood.DefaultCellStyle = dataGridViewCellStyle16;
            this.DGV_manageFood.Location = new System.Drawing.Point(770, 56);
            this.DGV_manageFood.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_manageFood.Name = "DGV_manageFood";
            this.DGV_manageFood.ReadOnly = true;
            this.DGV_manageFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_manageFood.RowHeadersWidth = 51;
            this.DGV_manageFood.RowTemplate.Height = 24;
            this.DGV_manageFood.Size = new System.Drawing.Size(422, 241);
            this.DGV_manageFood.TabIndex = 87;
            this.DGV_manageFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_manageFood_CellContentClick);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(361, 78);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(291, 31);
            this.txt_quantity.TabIndex = 86;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_quantity.Location = new System.Drawing.Point(356, 46);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(264, 28);
            this.lbl_quantity.TabIndex = 85;
            this.lbl_quantity.Text = "Food Quantity in Grams";
            // 
            // txt_foodName
            // 
            this.txt_foodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodName.Location = new System.Drawing.Point(43, 77);
            this.txt_foodName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.ReadOnly = true;
            this.txt_foodName.Size = new System.Drawing.Size(291, 31);
            this.txt_foodName.TabIndex = 84;
            // 
            // lbl_foodName
            // 
            this.lbl_foodName.AutoSize = true;
            this.lbl_foodName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_foodName.Location = new System.Drawing.Point(38, 46);
            this.lbl_foodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodName.Name = "lbl_foodName";
            this.lbl_foodName.Size = new System.Drawing.Size(130, 28);
            this.lbl_foodName.TabIndex = 83;
            this.lbl_foodName.Text = "Food Name";
            // 
            // lbl_Food
            // 
            this.lbl_Food.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Food.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Food.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Food.Location = new System.Drawing.Point(1323, 517);
            this.lbl_Food.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Food.Name = "lbl_Food";
            this.lbl_Food.Size = new System.Drawing.Size(139, 31);
            this.lbl_Food.TabIndex = 88;
            this.lbl_Food.Text = "Modify Food";
            this.lbl_Food.Click += new System.EventHandler(this.lbl_addFood_Click);
            this.lbl_Food.MouseLeave += new System.EventHandler(this.lbl_addFood_MouseLeave);
            this.lbl_Food.MouseHover += new System.EventHandler(this.lbl_addFood_MouseHover);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1475, 1055);
            this.Controls.Add(this.lbl_Food);
            this.Controls.Add(this.panel_addFood);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_dinnerTotal);
            this.Controls.Add(this.lbl_lunchTotal);
            this.Controls.Add(this.lbl_breakfastTotal);
            this.Controls.Add(this.lbl_dinner);
            this.Controls.Add(this.DGV_dinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_lunch);
            this.Controls.Add(this.lbl_breakfast);
            this.Controls.Add(this.DGV_breakfast);
            this.Controls.Add(this.dateTimePicker_logHistory);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "history";
            this.Text = "History";
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_breakfast)).EndInit();
            this.panel_addFood.ResumeLayout(false);
            this.panel_addFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_logHistory;
        private System.Windows.Forms.Label lbl_dinner;
        private System.Windows.Forms.DataGridView DGV_dinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_lunch;
        private System.Windows.Forms.Label lbl_breakfast;
        private System.Windows.Forms.DataGridView DGV_breakfast;
        private System.Windows.Forms.Label lbl_dinnerTotal;
        private System.Windows.Forms.Label lbl_lunchTotal;
        private System.Windows.Forms.Label lbl_breakfastTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel_addFood;
        private System.Windows.Forms.Label lbl_Food;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_serving;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.ComboBox comboBox_mealType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_manageFood;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_foodName;
        private System.Windows.Forms.Label lbl_foodName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_mealID;
        private System.Windows.Forms.Label label3;
    }
}