using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace calorieCalculator
{
    public partial class logFood : Form
    {
        int caloriesInServing = 0;
        int caloriesPerHundred = 0;
        public logFood()
        {
            InitializeComponent();
            PopulateDataGridView();
            populateDGVBreakfast();
            populateDGVLunch();
            populateDGVDinner();
        }
        private void clearFields() {
            txt_foodName.Clear();
            txt_quantity.Clear();
        }

        Database database = new Database();
        private void PopulateDataGridView()
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
        private void populateDGVBreakfast()
        {
            string databasePath = database.GetDatabasePath();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
            {
                conn.Open();

                string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.currentUser);
                    cmd.Parameters.AddWithValue("@MealType", "Breakfast");

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGV_breakfast.DataSource = dt;
                }
            }
        }
        private void populateDGVLunch()
        {
            string databasePath = database.GetDatabasePath();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
            {
                conn.Open();

                string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.currentUser);
                    cmd.Parameters.AddWithValue("@MealType", "Lunch");

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGV_lunch.DataSource = dt;
                }
            }
        }
        private void populateDGVDinner()
        {
            string databasePath = database.GetDatabasePath();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
            {
                conn.Open();

                string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.currentUser);
                    cmd.Parameters.AddWithValue("@MealType", "Dinner");

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGV_dinner.DataSource = dt;
                }
            }
        }
        private bool validateForm()
        {
            int invalidcount = 0;
            int foodNamelengthcount = 0;
            int foodNameblankcount = 0;

            int quantityblankcount = 0;
            int quantitynumbercount = 0;

            int mealtypecount = 0;

            // food name length
            if ((txt_foodName.Text.Length >= 3) && !(txt_foodName.Text == "Food Name must be at least 3 characters long."))
            {
                if (foodNamelengthcount > 0)
                {
                    foodNamelengthcount = 0;
                }

            }
            else
            {
                foodNamelengthcount++;
                txt_foodName.Text = "Food Name must be at least 3 characters long.";

            }

            // if food name is blank
            if (!((txt_foodName.Text == "") && (txt_foodName.Text == "Food Name can't be blank.")))
            {
                if (foodNameblankcount > 0)
                {
                    foodNameblankcount = 0;

                }

            }
            else
            {
                foodNameblankcount = foodNameblankcount + 1;
                txt_foodName.Text = "Food Name can't be blank.";

            }

            // is quantity number
            Validation validation = new Validation();

            if ((validation.isNumber(txt_quantity.Text) == true) && !(txt_quantity.Text == "The quantity must be a number."))
            {

                if (quantitynumbercount > 0)
                {
                    quantitynumbercount = 0;

                }
            }
            else
            {
                quantitynumbercount++;
                txt_quantity.Text = "The quantity must be a number.";

            }

            // is quantity blank
            if (!((txt_quantity.Text == "") && (txt_quantity.Text == "The quanity must not be blank.")))
            {

                if (quantityblankcount > 0)
                {
                    quantityblankcount = 0;

                }
            }
            else
            {
                quantityblankcount++;
                txt_quantity.Text = "The quantity must not be blank.";

            }

            // mealtype
            if (!(comboBox_mealType.SelectedIndex == -1))
            {
                if (mealtypecount > 0)
                {
                    mealtypecount = 0;
                }

            }
            else
            {
                mealtypecount++;
                MessageBox.Show("Please select a meal type");
            }

            // setting up the back ground colour of the textboxes
            if (foodNameblankcount > 0 || foodNamelengthcount > 0)
            {
                txt_foodName.BackColor = Color.Red;
            }
            else
            {
                txt_foodName.BackColor = Color.White;
            }

            if (quantityblankcount > 0 || quantitynumbercount > 0)
            {
                txt_quantity.BackColor = Color.Red;
            }
            else
            {
                txt_quantity.BackColor = Color.White;
            }

            if (mealtypecount > 0)
            {
                comboBox_mealType.BackColor = Color.Red;
            }
            else
            {
                comboBox_mealType.BackColor = Color.White;
            }

            invalidcount = foodNameblankcount + foodNamelengthcount + quantityblankcount + quantitynumbercount + mealtypecount;

            if (invalidcount > 0)
            {
                return false;
            }
            else { 
                return true;
            }

        }
        private void logFood_Load(object sender, EventArgs e)
        {

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm() == true)
                {

                    if (checkBox_fruit.Checked == true)
                    {
                        caloriesInServing = Convert.ToInt32(txt_quantity.Text) * caloriesPerHundred;
                    }
                    else 
                    { 
                        
                        int quantity = Convert.ToInt32(txt_quantity.Text);
                        int caloriesPerGram = caloriesPerHundred / 100;
                        caloriesInServing = caloriesPerGram * quantity;
                    }

                        string userName = Database.GlobalVariables.currentUser;
                        string foodName = txt_foodName.Text;
                        string mealType = comboBox_mealType.SelectedItem.ToString();
                        
                        DateTime dateObj = DateTime.Today;
                        string date = dateObj.ToString();

                        DateTime timeObj = DateTime.Now;
                        string time = timeObj.ToString("HH:mm:ss");

                        database.insertMeal(userName, foodName, mealType, date, time, caloriesInServing);

                        clearFields();
                        populateDGVBreakfast();
                        populateDGVLunch();
                        populateDGVDinner();

                }
            }
            catch {
                MessageBox.Show("Enter only whole numbers in calories.");
            }
        }

        private void DGV_manageFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_manageFood.Rows[e.RowIndex];

                txt_foodName.Text = row.Cells["FoodName"].Value.ToString();
                caloriesPerHundred = Convert.ToInt32(row.Cells["Calories"].Value.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
