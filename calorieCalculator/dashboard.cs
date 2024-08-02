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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            setCalorieLabels();
        }
        Database database = new Database();

        private void setCalorieLabels()
        {
            int targetCalories = Database.GlobalVariables.targetCalories;
            lbl_goal.Text = targetCalories.ToString();

            string username = Database.GlobalVariables.currentUser;
            int foodTotal = totalBreakfastCalories(username) + totalLunchCalories(username) + totalDinnerCalories(username);
            lbl_food.Text = foodTotal.ToString();

            
            int remaining = targetCalories - foodTotal;

            if (remaining <=0) { 
                lbl_bender.Text = "Slow down, little missy.";
                lbl_bender.ForeColor = Color.Red;
            }
            else
            {
                lbl_bender.Text = "You go, Girl.";
                lbl_bender.ForeColor = Color.LightGreen;
            }

            lbl_remaining.Text = remaining.ToString();
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
            catch (Exception ex)
            {
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
            catch (Exception ex)
            {

                MessageBox.Show("Opps, something went wrong: " + ex.Message);
                return 0;
            }

        }
        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
