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

namespace calorieCalculator
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        readonly Database database = new Database();
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
    }
}
