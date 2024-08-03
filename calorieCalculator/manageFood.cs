using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorieCalculator
{
    public partial class manageFood : Form
    {
        public manageFood()
        {
            InitializeComponent();
            PopulateDataGridView();
            
        }
        Database database = new Database();

        //kilojoules calculator
        internal int KilojoulesToCalories(double kilojoules)
        {
            int calories = Convert.ToInt32(Math.Round(kilojoules * 0.239));
            return calories;
        }

        //validation
        private bool validateForm()
        {

            int foodnamelengthcount = 0;
            int foodnameblankcount = 0;

            int caloriesnumbercount = 0;
            int caloriesblankcount = 0;

            int measurementcount = 0;

            // food name length
            if ((txt_foodName.Text.Length >= 3) && !(txt_foodName.Text == "Food Name must be at least 3 characters long."))
            {
                if (foodnamelengthcount > 0)
                {
                    foodnamelengthcount = 0;
                }

            }
            else
            {
                foodnamelengthcount++;
                txt_foodName.Text = "Food Name must be at least 3 characters long.";

            }

            // if food name is blank
            if (!((txt_foodName.Text == "") && (txt_foodName.Text == "Food Name can't be blank.")))
            {
                if (foodnameblankcount > 0)
                {
                    foodnameblankcount = 0;

                }

            }
            else
            {
                foodnameblankcount = foodnameblankcount + 1;
                txt_foodName.Text = "Food Name can't be blank.";

            }

            // is calories number
            Validation validation = new Validation();

            if ((validation.isNumber(txt_calories.Text) == true) && !(txt_calories.Text == "Calories must be a number."))
            {

                if (caloriesnumbercount > 0)
                {
                    caloriesnumbercount = 0;

                }
            }
            else
            {
                caloriesnumbercount++;
                txt_calories.Text = "Calories must be a number.";

            }

            // is calories blank
            if (!((txt_calories.Text == "") && (txt_calories.Text == "Calories must not be blank.")))
            {

                if (caloriesblankcount > 0)
                {
                    caloriesblankcount = 0;

                }
            }
            else
            {
                caloriesblankcount++;
                txt_calories.Text = "Calories must not be blank.";

            }


            if (radioButton_calories.Checked)
            {
                if (measurementcount > 0)
                {
                    measurementcount = 0;
                }
            }
            else if (radioButton_kilojoules.Checked)
            {
                if (measurementcount > 0)
                {
                    measurementcount = 0;
                }
            }
            else
            {
                measurementcount++;
            }



            // setting up the back ground colour of the textboxes 
            if (foodnameblankcount > 0 || foodnamelengthcount > 0)
            {
                txt_foodName.BackColor = Color.Red;
            }
            else
            {
                txt_foodName.BackColor = Color.White;
            }

            if (caloriesblankcount > 0 || caloriesnumbercount > 0)
            {
                txt_calories.BackColor = Color.Red;
            }
            else
            {
                txt_calories.BackColor = Color.White;
            }

            if (measurementcount > 0)
            {
                groupBox1.BackColor = Color.Red;
                MessageBox.Show("Select a measurement.");
            }
            else { 
                groupBox1.BackColor= Color.White;
            }

            int invalidcount = foodnameblankcount + foodnamelengthcount + caloriesblankcount + caloriesnumbercount + measurementcount;

            if (invalidcount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

            private void PopulateDataGridView()
            {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    string query = "SELECT FoodID, FoodName, Calories FROM Foods";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_manageFood.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Opps something went wrong on: " + ex.Message);
            }

            }
        private void clearFields() {
            txt_foodID.Clear();
            txt_foodName.Clear();
            txt_calories.Clear();
            radioButton_calories.Checked = false;
            radioButton_kilojoules.Checked = false;
        } 
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void txt_calories_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Calories_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try {
                if (validateForm() == true) {
                    string foodName = txt_foodName.Text;
                    int calories = 0;

                    if (radioButton_kilojoules.Checked) {
                        calories = KilojoulesToCalories(Convert.ToDouble(txt_calories.Text));
                    }

                    if (radioButton_calories.Checked) {
                        calories = Convert.ToInt32(txt_calories.Text);
                    }

                    database.insertFood(foodName, calories);
                    PopulateDataGridView();
                    clearFields();
                }
            }
            catch{
                MessageBox.Show("Enter only whole numbers in calories.");
            }

        }

        private void addFood_Load(object sender, EventArgs e)
        {

        }

        private void DGV_manageFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.DGV_manageFood.Rows[e.RowIndex];

                txt_foodID.Text = row.Cells["FoodID"].Value.ToString();
                txt_foodName.Text = row.Cells["FoodName"].Value.ToString();
                txt_calories.Text = row.Cells["Calories"].Value.ToString();
                radioButton_calories.Checked = true;
                radioButton_kilojoules.Checked = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!(txt_foodID.Text == ""))
            {
                int foodID = Convert.ToInt32(txt_foodID.Text);
                database.deleteFood(foodID);
                PopulateDataGridView();
                clearFields();
            }
            else {
                MessageBox.Show("Please click on the food name in the table before deleting");
            }

            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm() == true && !(txt_foodID.Text == ""))
                {

                    int foodID = Convert.ToInt32(txt_foodID.Text);
                    string foodName = txt_foodName.Text;
                    int calories = 0;

                    if (radioButton_kilojoules.Checked)
                    {
                        calories = KilojoulesToCalories(Convert.ToDouble(txt_calories.Text));
                    }

                    if (radioButton_calories.Checked)
                    {
                        calories = Convert.ToInt32(txt_calories.Text);
                    }

                    database.updateFood(foodID, foodName, calories);
                    PopulateDataGridView();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Please click on the food name in the table before updating");
                }
            }
            catch (Exception) {
                MessageBox.Show("Enter only whole numbers in calories.");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
