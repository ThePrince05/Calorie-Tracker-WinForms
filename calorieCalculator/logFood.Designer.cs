namespace calorieCalculator
{
    partial class logFood
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
            this.lbl_manageFood = new System.Windows.Forms.Label();
            this.txt_foodName = new System.Windows.Forms.TextBox();
            this.lbl_foodName = new System.Windows.Forms.Label();
            this.txt_qauntity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.DGV_manageFood = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_foodLogged = new System.Windows.Forms.Label();
            this.lbl_breakfast = new System.Windows.Forms.Label();
            this.DGV_breakfast = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_lunch = new System.Windows.Forms.DataGridView();
            this.lbl_dinner = new System.Windows.Forms.Label();
            this.DGV_dinner = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_goalTitle = new System.Windows.Forms.Label();
            this.lbl_goal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_food = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_remaining = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_breakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dinner)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_manageFood
            // 
            this.lbl_manageFood.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manageFood.ForeColor = System.Drawing.Color.Black;
            this.lbl_manageFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_manageFood.Location = new System.Drawing.Point(527, 18);
            this.lbl_manageFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manageFood.Name = "lbl_manageFood";
            this.lbl_manageFood.Size = new System.Drawing.Size(190, 47);
            this.lbl_manageFood.TabIndex = 3;
            this.lbl_manageFood.Text = "Log Food";
            // 
            // txt_foodName
            // 
            this.txt_foodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foodName.Location = new System.Drawing.Point(223, 101);
            this.txt_foodName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.ReadOnly = true;
            this.txt_foodName.Size = new System.Drawing.Size(291, 31);
            this.txt_foodName.TabIndex = 23;
            // 
            // lbl_foodName
            // 
            this.lbl_foodName.AutoSize = true;
            this.lbl_foodName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodName.ForeColor = System.Drawing.Color.Black;
            this.lbl_foodName.Location = new System.Drawing.Point(218, 70);
            this.lbl_foodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodName.Name = "lbl_foodName";
            this.lbl_foodName.Size = new System.Drawing.Size(130, 28);
            this.lbl_foodName.TabIndex = 22;
            this.lbl_foodName.Text = "Food Name";
            // 
            // txt_qauntity
            // 
            this.txt_qauntity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qauntity.Location = new System.Drawing.Point(223, 175);
            this.txt_qauntity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_qauntity.Name = "txt_qauntity";
            this.txt_qauntity.Size = new System.Drawing.Size(291, 31);
            this.txt_qauntity.TabIndex = 25;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantity.Location = new System.Drawing.Point(218, 143);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(206, 28);
            this.lbl_quantity.TabIndex = 24;
            this.lbl_quantity.Text = "Quantity in Grams";
            // 
            // DGV_manageFood
            // 
            this.DGV_manageFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_manageFood.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV_manageFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_manageFood.Location = new System.Drawing.Point(722, 88);
            this.DGV_manageFood.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_manageFood.Name = "DGV_manageFood";
            this.DGV_manageFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_manageFood.RowHeadersWidth = 51;
            this.DGV_manageFood.RowTemplate.Height = 24;
            this.DGV_manageFood.Size = new System.Drawing.Size(422, 241);
            this.DGV_manageFood.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(833, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Food Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(218, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Meal Type";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Breakfast",
            "Lunch",
            "Dinner"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(223, 252);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(291, 31);
            this.comboBox2.TabIndex = 30;
            // 
            // btn_log
            // 
            this.btn_log.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Location = new System.Drawing.Point(287, 300);
            this.btn_log.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(137, 41);
            this.btn_log.TabIndex = 49;
            this.btn_log.Text = "Log";
            this.btn_log.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 9);
            this.panel1.TabIndex = 50;
            // 
            // lbl_foodLogged
            // 
            this.lbl_foodLogged.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline);
            this.lbl_foodLogged.ForeColor = System.Drawing.Color.Black;
            this.lbl_foodLogged.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_foodLogged.Location = new System.Drawing.Point(566, 382);
            this.lbl_foodLogged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_foodLogged.Name = "lbl_foodLogged";
            this.lbl_foodLogged.Size = new System.Drawing.Size(258, 47);
            this.lbl_foodLogged.TabIndex = 51;
            this.lbl_foodLogged.Text = "Food Logged";
            // 
            // lbl_breakfast
            // 
            this.lbl_breakfast.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breakfast.ForeColor = System.Drawing.Color.Black;
            this.lbl_breakfast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_breakfast.Location = new System.Drawing.Point(168, 442);
            this.lbl_breakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_breakfast.Name = "lbl_breakfast";
            this.lbl_breakfast.Size = new System.Drawing.Size(152, 37);
            this.lbl_breakfast.TabIndex = 53;
            this.lbl_breakfast.Text = "Breakfast";
            // 
            // DGV_breakfast
            // 
            this.DGV_breakfast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_breakfast.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV_breakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_breakfast.Location = new System.Drawing.Point(32, 483);
            this.DGV_breakfast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_breakfast.Name = "DGV_breakfast";
            this.DGV_breakfast.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_breakfast.RowHeadersWidth = 51;
            this.DGV_breakfast.RowTemplate.Height = 24;
            this.DGV_breakfast.Size = new System.Drawing.Size(422, 241);
            this.DGV_breakfast.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(631, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 55;
            this.label4.Text = "Lunch";
            // 
            // DGV_lunch
            // 
            this.DGV_lunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_lunch.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV_lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_lunch.Location = new System.Drawing.Point(494, 483);
            this.DGV_lunch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_lunch.Name = "DGV_lunch";
            this.DGV_lunch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_lunch.RowHeadersWidth = 51;
            this.DGV_lunch.RowTemplate.Height = 24;
            this.DGV_lunch.Size = new System.Drawing.Size(422, 241);
            this.DGV_lunch.TabIndex = 54;
            // 
            // lbl_dinner
            // 
            this.lbl_dinner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinner.ForeColor = System.Drawing.Color.Black;
            this.lbl_dinner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dinner.Location = new System.Drawing.Point(1088, 442);
            this.lbl_dinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dinner.Name = "lbl_dinner";
            this.lbl_dinner.Size = new System.Drawing.Size(131, 37);
            this.lbl_dinner.TabIndex = 57;
            this.lbl_dinner.Text = "Dinner";
            // 
            // DGV_dinner
            // 
            this.DGV_dinner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_dinner.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV_dinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dinner.Location = new System.Drawing.Point(952, 483);
            this.DGV_dinner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_dinner.Name = "DGV_dinner";
            this.DGV_dinner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_dinner.RowHeadersWidth = 51;
            this.DGV_dinner.RowTemplate.Height = 24;
            this.DGV_dinner.Size = new System.Drawing.Size(422, 241);
            this.DGV_dinner.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(619, 806);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 58;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(619, 768);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 31);
            this.textBox1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(632, 737);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Meal ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(12, 865);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1417, 9);
            this.panel2.TabIndex = 61;
            // 
            // lbl_goalTitle
            // 
            this.lbl_goalTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline);
            this.lbl_goalTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_goalTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_goalTitle.Location = new System.Drawing.Point(508, 886);
            this.lbl_goalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_goalTitle.Name = "lbl_goalTitle";
            this.lbl_goalTitle.Size = new System.Drawing.Size(347, 47);
            this.lbl_goalTitle.TabIndex = 62;
            this.lbl_goalTitle.Text = "Calories Reaming";
            // 
            // lbl_goal
            // 
            this.lbl_goal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goal.ForeColor = System.Drawing.Color.Black;
            this.lbl_goal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_goal.Location = new System.Drawing.Point(501, 947);
            this.lbl_goal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_goal.Name = "lbl_goal";
            this.lbl_goal.Size = new System.Drawing.Size(50, 37);
            this.lbl_goal.TabIndex = 63;
            this.lbl_goal.Text = "??";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(582, 947);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 37);
            this.label5.TabIndex = 64;
            this.label5.Text = "-";
            // 
            // lbl_food
            // 
            this.lbl_food.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food.ForeColor = System.Drawing.Color.Black;
            this.lbl_food.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_food.Location = new System.Drawing.Point(640, 947);
            this.lbl_food.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_food.Name = "lbl_food";
            this.lbl_food.Size = new System.Drawing.Size(50, 37);
            this.lbl_food.TabIndex = 65;
            this.lbl_food.Text = "??";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(733, 947);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 37);
            this.label6.TabIndex = 66;
            this.label6.Text = "=";
            // 
            // lbl_remaining
            // 
            this.lbl_remaining.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remaining.ForeColor = System.Drawing.Color.Black;
            this.lbl_remaining.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_remaining.Location = new System.Drawing.Point(805, 947);
            this.lbl_remaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_remaining.Name = "lbl_remaining";
            this.lbl_remaining.Size = new System.Drawing.Size(50, 37);
            this.lbl_remaining.TabIndex = 67;
            this.lbl_remaining.Text = "??";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(489, 993);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 37);
            this.label7.TabIndex = 68;
            this.label7.Text = "Goal";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(632, 993);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 37);
            this.label8.TabIndex = 69;
            this.label8.Text = "Food";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(782, 993);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 37);
            this.label9.TabIndex = 70;
            this.label9.Text = "Remaining";
            // 
            // logFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1441, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_remaining);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_food);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_goal);
            this.Controls.Add(this.lbl_goalTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_dinner);
            this.Controls.Add(this.DGV_dinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_lunch);
            this.Controls.Add(this.lbl_breakfast);
            this.Controls.Add(this.DGV_breakfast);
            this.Controls.Add(this.lbl_foodLogged);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_manageFood);
            this.Controls.Add(this.txt_qauntity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_foodName);
            this.Controls.Add(this.lbl_foodName);
            this.Controls.Add(this.lbl_manageFood);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "logFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logFood";
            this.Load += new System.EventHandler(this.logFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_manageFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_breakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageFood;
        private System.Windows.Forms.TextBox txt_foodName;
        private System.Windows.Forms.Label lbl_foodName;
        private System.Windows.Forms.TextBox txt_qauntity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.DataGridView DGV_manageFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_foodLogged;
        private System.Windows.Forms.Label lbl_breakfast;
        private System.Windows.Forms.DataGridView DGV_breakfast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_lunch;
        private System.Windows.Forms.Label lbl_dinner;
        private System.Windows.Forms.DataGridView DGV_dinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_goalTitle;
        private System.Windows.Forms.Label lbl_goal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_food;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_remaining;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}