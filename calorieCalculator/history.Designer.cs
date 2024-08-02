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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_manageFood = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_breakfast)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_manageFood
            // 
            this.lbl_manageFood.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manageFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_manageFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_manageFood.Location = new System.Drawing.Point(593, 9);
            this.lbl_manageFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manageFood.Name = "lbl_manageFood";
            this.lbl_manageFood.Size = new System.Drawing.Size(279, 47);
            this.lbl_manageFood.TabIndex = 3;
            this.lbl_manageFood.Text = "Log History";
            // 
            // dateTimePicker_logHistory
            // 
            this.dateTimePicker_logHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_logHistory.Location = new System.Drawing.Point(556, 74);
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
            this.lbl_dinner.Location = new System.Drawing.Point(1091, 158);
            this.lbl_dinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dinner.Name = "lbl_dinner";
            this.lbl_dinner.Size = new System.Drawing.Size(131, 37);
            this.lbl_dinner.TabIndex = 63;
            this.lbl_dinner.Text = "Dinner";
            // 
            // DGV_dinner
            // 
            this.DGV_dinner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_dinner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dinner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.DGV_dinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dinner.Location = new System.Drawing.Point(955, 199);
            this.DGV_dinner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_dinner.Name = "DGV_dinner";
            this.DGV_dinner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dinner.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.DGV_dinner.RowHeadersWidth = 51;
            this.DGV_dinner.RowTemplate.Height = 24;
            this.DGV_dinner.Size = new System.Drawing.Size(422, 191);
            this.DGV_dinner.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(634, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 61;
            this.label4.Text = "Lunch";
            // 
            // DGV_lunch
            // 
            this.DGV_lunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_lunch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_lunch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.DGV_lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_lunch.Location = new System.Drawing.Point(497, 199);
            this.DGV_lunch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_lunch.Name = "DGV_lunch";
            this.DGV_lunch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_lunch.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.DGV_lunch.RowHeadersWidth = 51;
            this.DGV_lunch.RowTemplate.Height = 24;
            this.DGV_lunch.Size = new System.Drawing.Size(422, 191);
            this.DGV_lunch.TabIndex = 60;
            // 
            // lbl_breakfast
            // 
            this.lbl_breakfast.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breakfast.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_breakfast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_breakfast.Location = new System.Drawing.Point(171, 158);
            this.lbl_breakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_breakfast.Name = "lbl_breakfast";
            this.lbl_breakfast.Size = new System.Drawing.Size(152, 37);
            this.lbl_breakfast.TabIndex = 59;
            this.lbl_breakfast.Text = "Breakfast";
            // 
            // DGV_breakfast
            // 
            this.DGV_breakfast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_breakfast.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DGV_breakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_breakfast.DefaultCellStyle = dataGridViewCellStyle35;
            this.DGV_breakfast.Location = new System.Drawing.Point(35, 199);
            this.DGV_breakfast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_breakfast.Name = "DGV_breakfast";
            this.DGV_breakfast.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_breakfast.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.DGV_breakfast.RowHeadersWidth = 51;
            this.DGV_breakfast.RowTemplate.Height = 24;
            this.DGV_breakfast.Size = new System.Drawing.Size(422, 191);
            this.DGV_breakfast.TabIndex = 58;
            // 
            // lbl_dinnerTotal
            // 
            this.lbl_dinnerTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinnerTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_dinnerTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dinnerTotal.Location = new System.Drawing.Point(1075, 403);
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
            this.lbl_lunchTotal.Location = new System.Drawing.Point(613, 403);
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
            this.lbl_breakfastTotal.Location = new System.Drawing.Point(147, 403);
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
            this.label8.Location = new System.Drawing.Point(614, 471);
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
            this.lbl_total.Location = new System.Drawing.Point(680, 508);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(192, 37);
            this.lbl_total.TabIndex = 86;
            this.lbl_total.Text = "??";
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1420, 570);
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
            this.Controls.Add(this.lbl_manageFood);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "history";
            this.Text = "History";
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_breakfast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageFood;
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
    }
}