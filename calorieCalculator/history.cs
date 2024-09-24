using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorieCalculator
{
    public partial class history : Form
    {
        int caloriesInServing = 0;
        int caloriesPerHundred = 0;
        public history()
        {
            InitializeComponent();
            // Initialize date picker
            DateTime selectedDate = dateTimePicker_logHistory.Value;
            formattedDate = selectedDate.ToString("yyyy/MM/dd") + " 12:00:00 AM";
            populateDGVBreakfast(formattedDate);
            populateDGVLunch(formattedDate);
            populateDGVDinner(formattedDate);
            mealTotal();
            setCalorieTotal();


            // Hide add food panel
            panel_addFood.Width = 0;
            panel_addFood.Height = 0;
        }

        readonly Database database = new Database();
       
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
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }
        private void ReadServingFile(string foodName)
        {

            // text document directory
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filePath = Path.Combine(appDataPath, "Calorie Tracker", "isServing.txt");


            List<String> existingServings = new List<String>();
            if (File.Exists(filePath))
            {
                existingServings = File.ReadAllLines(filePath).ToList();

                if (existingServings.Contains(foodName))
                {
                    checkBox_serving.Enabled = true;
                    checkBox_serving.ForeColor = Color.LightGreen;
                    checkBox_serving.Checked = true;

                }
                else
                {
                    checkBox_serving.ForeColor = Color.Gainsboro;
                    checkBox_serving.Checked = false;
                    checkBox_serving.Enabled = false;

                }

            }
        }
        private bool ValidateForm()
        {
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
                foodNameblankcount++;
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
            if (!((txt_quantity.Text == "") && (txt_quantity.Text == "The quantity must not be blank.")))
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

            int invalidcount = foodNameblankcount + foodNamelengthcount + quantityblankcount + quantitynumbercount + mealtypecount;

            if (invalidcount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void FilterDataGridViewByFoodName(string foodName)
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
                        DataView dv = new DataView(dt)
                        {
                            RowFilter = $"FoodName LIKE '%{foodName}%'"
                        };
                        DGV_manageFood.DataSource = dv;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }
        private void populateDGVBreakfast(string date)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                   
                    string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.CurrentUser);
                        cmd.Parameters.AddWithValue("@MealType", "Breakfast");
                        cmd.Parameters.AddWithValue("@Date", date);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_breakfast.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }
        private void populateDGVLunch(string date)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    
                    string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.CurrentUser);
                        cmd.Parameters.AddWithValue("@MealType", "Lunch");
                        cmd.Parameters.AddWithValue("@Date", date);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_lunch.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }
        private void populateDGVDinner(string date)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                   
                    string query = "SELECT MealID, FoodName, CaloriesInServing FROM Meals WHERE Username = @Username AND MealType = @MealType AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Database.GlobalVariables.CurrentUser);
                        cmd.Parameters.AddWithValue("@MealType", "Dinner");
                        cmd.Parameters.AddWithValue("@Date", date);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGV_dinner.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }
        private void setCalorieTotal()
        { 
            string username = Database.GlobalVariables.CurrentUser;
            int foodTotal = totalBreakfastCalories(username, formattedDate) + totalLunchCalories(username, formattedDate) + totalDinnerCalories(username, formattedDate);
            lbl_total.Text = foodTotal.ToString();
        }
        private int totalBreakfastCalories(string username, string date)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();
                   

                    string query = "SELECT SUM(CaloriesInServing) AS TotalBreakfastCalories FROM Meals WHERE Username = @Username AND MealType = 'Breakfast' AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Date", date);

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
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
                return 0;
            }
        }
        private int totalLunchCalories(string username, string date)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                 

                    string query = "SELECT SUM(CaloriesInServing) AS TotalLunchCalories FROM Meals WHERE Username = @Username AND MealType = 'Lunch' AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Date", date);

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
                MessageBox.Show("Ops, something went wrong: " + ex.Message);
                return 0;
            }

        }
        private int totalDinnerCalories(string username, string date)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();
                    

                    string query = "SELECT SUM(CaloriesInServing) AS TotalDinnerCalories FROM Meals WHERE Username = @Username AND MealType = 'Dinner' AND Date = @Date";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Date", date);

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

                MessageBox.Show("Ops, something went wrong: " + ex.Message);
                return 0;
            }

        }

        private void mealTotal()
        {
            lbl_breakfastTotal.Text = "Total - " + totalBreakfastCalories(Database.GlobalVariables.CurrentUser, formattedDate);
            lbl_lunchTotal.Text = "Total - " + totalLunchCalories(Database.GlobalVariables.CurrentUser, formattedDate);
            lbl_dinnerTotal.Text = "Total - " + totalDinnerCalories(Database.GlobalVariables.CurrentUser, formattedDate);
        }

        private void DeleteMeal(int mealId)
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
                MessageBox.Show("Ops something went wrong: " + ex.Message);
            }
        }
        string formattedDate;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker_logHistory.Value;
            formattedDate = selectedDate.ToString("yyyy/MM/dd") + " 12:00:00 AM";
            populateDGVBreakfast(formattedDate);
            populateDGVLunch(formattedDate);
            populateDGVDinner(formattedDate);
            mealTotal(); 
            setCalorieTotal();

        }

        private void history_Load(object sender, EventArgs e)
        {

        }

        private void lbl_addFood_MouseHover(object sender, EventArgs e)
        {
            lbl_Food.ForeColor = Color.Red;
        }

        private void lbl_addFood_Click(object sender, EventArgs e)
        {
            // show add food Panel 1451, 492
            if (panel_addFood.Width == 0 && panel_addFood.Height == 0)
            {
                panel_addFood.Width = 1451;
                panel_addFood.Height = 492;
                PopulateDataGridView();
                lbl_Food.Text = "Hide Food";
            }
            else {
                panel_addFood.Width = 0;
                panel_addFood.Height = 0;
                lbl_Food.Text = "Modify Food";
            }
            
            
        }
        private void ClearFields()
        {
            txt_foodName.Clear();
            txt_quantity.Clear();
            checkBox_serving.Checked = false;
            checkBox_serving.ForeColor = Color.Gainsboro;
        }

        private void lbl_addFood_MouseLeave(object sender, EventArgs e)
        {
            lbl_Food.ForeColor = Color.Gainsboro;
        }

        private void DGV_manageFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_manageFood.Rows[e.RowIndex];

                txt_foodName.Text = row.Cells["FoodName"].Value.ToString();
                caloriesPerHundred = Convert.ToInt32(row.Cells["Calories"].Value.ToString());
            }
            ReadServingFile(txt_foodName.Text);
        }

        private void txt_search_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterDataGridViewByFoodName(txt_search.Text);
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            // setting up date for date picker 
            DateTime selectedDate = dateTimePicker_logHistory.Value;
            formattedDate = selectedDate.ToString("yyyy/MM/dd") + " 12:00:00 AM";

            try
            {
                if (ValidateForm() == true && !string.IsNullOrEmpty(selectedDate.ToString()))
                {
                    if (checkBox_serving.ForeColor == Color.LightGreen && checkBox_serving.Checked == false)
                    {
                        MessageBox.Show("Warning: It's recommended you tick the 'Is It A Serving?' checkbox for more accurate calorie calculations!!!.");
                        caloriesInServing = 0;
                    }

                    else if (checkBox_serving.Checked == true)
                    {
                        double userInput = Math.Round(Convert.ToDouble(txt_quantity.Text) * caloriesPerHundred);
                        caloriesInServing = Convert.ToInt32(userInput);
                    }

                    else
                    {
                        int quantity = Convert.ToInt32(txt_quantity.Text);

                        double totalCalories = (caloriesPerHundred / 100.0) * quantity;
                        caloriesInServing = Convert.ToInt32(Math.Round(totalCalories));
                    }

                    string userName = Database.GlobalVariables.CurrentUser;
                    string foodName = txt_foodName.Text;
                    string mealType = comboBox_mealType.SelectedItem.ToString();

                   

                    
                    DateTime timeObj = DateTime.Now;
                    string time = timeObj.ToString("HH:mm:ss");

                    database.InsertMeal(userName, foodName, mealType, formattedDate, time, caloriesInServing);

                    ClearFields();
                    populateDGVBreakfast(formattedDate);
                    populateDGVLunch(formattedDate);
                    populateDGVDinner(formattedDate);
                    mealTotal();
                    setCalorieTotal();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter only whole numbers in calories: " + ex.Message);
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
            // setting up date for date picker 
            DateTime selectedDate = dateTimePicker_logHistory.Value;
            formattedDate = selectedDate.ToString("yyyy/MM/dd") + " 12:00:00 AM";

            if (txt_mealID.Text == "")
            {
                MessageBox.Show("Please click the meal (foodname) one of the tables first.");
                txt_mealID.BackColor = Color.Red;
            }
            else
            {
                txt_mealID.BackColor = Color.White;
                int mealID = Convert.ToInt32(txt_mealID.Text);

                DeleteMeal(mealID);
                txt_mealID.Clear();
                populateDGVBreakfast(formattedDate);
                populateDGVLunch(formattedDate);
                populateDGVDinner(formattedDate);
                mealTotal();
                setCalorieTotal();
            }
        }
    }
}
