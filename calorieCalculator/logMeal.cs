using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace calorieCalculator
{
    public partial class logMeal : Form
    {
        int caloriesInServing = 0;
        int caloriesPerHundred = 0;
        public logMeal()
        {
            InitializeComponent();
            PopulateDataGridView();
            populateDGVBreakfast();
            populateDGVLunch();
            populateDGVDinner();
            mealTotal();
            setCalorieLabels();
        }

        private void setCalorieLabels() {
            int targetCalories = Database.GlobalVariables.targetCalories;
            lbl_goal.Text = targetCalories.ToString();

            string username = Database.GlobalVariables.currentUser;
            int foodTotal = totalBreakfastCalories(username) + totalLunchCalories(username) + totalDinnerCalories(username);
            lbl_food.Text = foodTotal.ToString();

            int remaining = targetCalories - foodTotal;
            lbl_remaining.Text = remaining.ToString();
        }
        private void filterDataGridViewByFoodName(string foodName)
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
                        DataView dv = new DataView(dt);
                        dv.RowFilter = $"FoodName LIKE '%{foodName}%'";
                        DGV_manageFood.DataSource = dv;

                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
            }
        }
        private void clearFields() {
            txt_foodName.Clear();
            txt_quantity.Clear();
            checkBox_serving.Checked = false;
        }

        Database database = new Database();
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
            catch(Exception ex) {
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
            }
        }
        private void populateDGVBreakfast()
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    DateTime obj = DateTime.Today;
                    string today = obj.ToString();

                    string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.currentUser);
                        cmd.Parameters.AddWithValue("@MealType", "Breakfast");
                        cmd.Parameters.AddWithValue("@Date", today);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_breakfast.DataSource = dt;
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
            }
        }
        private void populateDGVLunch()
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    DateTime obj = DateTime.Today;
                    string today = obj.ToString();

                    string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.currentUser);
                        cmd.Parameters.AddWithValue("@MealType", "Lunch");
                        cmd.Parameters.AddWithValue("@Date", today);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_lunch.DataSource = dt;
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
            }
        }
        private void populateDGVDinner()
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    DateTime obj = DateTime.Today;
                    string today = obj.ToString();

                    string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.currentUser);
                        cmd.Parameters.AddWithValue("@MealType", "Dinner");
                        cmd.Parameters.AddWithValue("@Date", today);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_dinner.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
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
        private int totalBreakfastCalories(string username)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();
                    DateTime obj = DateTime.Today;
                    string today = obj.ToString();

                    string query = "SELECT SUM(CaloriesInServing) AS TotalBreakfastCalories FROM Meals WHERE Username = @Username AND MealType = 'Breakfast' AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Date", today);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return 0; // Or handle the case where no data is found
                        }
                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
                return 0;
            }
        }
        private int totalLunchCalories(string username)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    DateTime obj = DateTime.Today;
                    string today = obj.ToString();

                    string query = "SELECT SUM(CaloriesInServing) AS TotalLunchCalories FROM Meals WHERE Username = @Username AND MealType = 'Lunch' AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Date", today);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return 0; // Or handle the case where no data is found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps, something went wrong: " + ex.Message);
                return 0;
            }

        }
        private int totalDinnerCalories(string username)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();
                    DateTime obj = DateTime.Today;
                    string today = obj.ToString();

                    string query = "SELECT SUM(CaloriesInServing) AS TotalDinnerCalories FROM Meals WHERE Username = @Username AND MealType = 'Dinner' AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Date", today);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return 0; // Or handle the case where no data is found
                        }
                    }
                }
            }
            catch(Exception ex){

                MessageBox.Show("Opps, something went wrong: " + ex.Message);
                return 0;
            }

        }

        private void mealTotal() {
            lbl_breakfastTotal.Text = "Total - " + totalBreakfastCalories(Database.GlobalVariables.currentUser);
            lbl_lunchTotal.Text = "Total - " + totalLunchCalories(Database.GlobalVariables.currentUser);
            lbl_dinnerTotal.Text = "Total - " + totalDinnerCalories(Database.GlobalVariables.currentUser);
        }
        
        private void deleteMeal(int mealId)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    string query = "DELETE FROM Meals WHERE MealID = @MealID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MealID", mealId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Meal deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting meal");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps something went wrong: " + ex.Message);
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

                    if (checkBox_serving.Checked == true)
                    {
                        double userInput = Math.Round(Convert.ToDouble(txt_quantity.Text) * caloriesPerHundred); 

                        caloriesInServing = Convert.ToInt32(userInput);
                    }
                    else 
                    { 
                        
                       int quantity = Convert.ToInt32(txt_quantity.Text);
                        //long caloriesTotal = (caloriesPerHundred / 100) * quantity;
                        //caloriesInServing = Convert.ToInt32(caloriesTotal);

                        double totalCalories = (caloriesPerHundred / 100.0) * quantity;
                        caloriesInServing = Convert.ToInt32(Math.Round(totalCalories));
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
                        mealTotal();
                        setCalorieLabels();

                }
            }
            catch(Exception ex){
                MessageBox.Show("Enter only whole numbers in calories: " + ex.Message);
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            int validation = 0;
            if (txt_search.Text =="" || txt_search.Text.Length < 3) { 
               validation = 1;
               txt_search.BackColor = Color.Red;
                MessageBox.Show("Enter a food name that it at least three characters long.");
            }
            else
            {
                txt_search.BackColor = Color.White;
                validation = 0;
            }

            if (validation == 0) {
                filterDataGridViewByFoodName(txt_search.Text);
            }
            
        }

        private void DGV_breakfast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_breakfast.Rows[e.RowIndex];

                txt_mealID.Text = row.Cells["MealID"].Value.ToString();
                
            }
        }

        private void DGV_lunch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_lunch.Rows[e.RowIndex];

                txt_mealID.Text = row.Cells["MealID"].Value.ToString();

            }
        }

        private void DGV_dinner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_dinner.Rows[e.RowIndex];

                txt_mealID.Text = row.Cells["MealID"].Value.ToString();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_mealID.Text == "")
            {
                MessageBox.Show("Please click the meal (foodname) on the table first.");
                txt_mealID.BackColor = Color.Red;
            }
            else {
                txt_mealID.BackColor = Color.White;
                int mealID = Convert.ToInt32(txt_mealID.Text);

                deleteMeal(mealID);
                txt_mealID.Clear();
                populateDGVBreakfast();
                populateDGVLunch();
                populateDGVDinner();
                mealTotal();
                setCalorieLabels();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void lbl_goal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_breakfastTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
