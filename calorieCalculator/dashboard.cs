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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            SetCalorieLabels();
            SetCaloriePercentage();
        }


        readonly Database database = new Database();

        private int GetCaloriePercentage()
        {
            try
            {
                int targetCalories = Database.GlobalVariables.CurrentTargetCalories;

                string username = Database.GlobalVariables.CurrentUser;
                int foodTotal = TotalBreakfastCalories(username) + TotalLunchCalories(username) + TotalDinnerCalories(username);
                int percentage = Convert.ToInt32(Math.Round((double)foodTotal / targetCalories * 100));

                if (percentage >= 100)
                {
                    return 100;

                }
                else if (percentage > 0)
                {
                    return percentage;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
                return 0;
            }

        }

        private void SetCaloriePercentage() {
            try
            {
                ProgressBar.Value = GetCaloriePercentage();
                ProgressBar.Minimum = 0;
                ProgressBar.Maximum = 100;
                ProgressBar.Text = GetCaloriePercentage().ToString() + " %";
                ProgressBar.Update();
            }
            catch (Exception ex) {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }
        private void SetCalorieLabels()
        {
           
            int targetCalories = Database.GlobalVariables.CurrentTargetCalories;
            lbl_goal.Text = targetCalories.ToString();

            string username = Database.GlobalVariables.CurrentUser;
            int foodTotal = TotalBreakfastCalories(username) + TotalLunchCalories(username) + TotalDinnerCalories(username);
            lbl_food.Text = foodTotal.ToString();

            
            int remaining = targetCalories - foodTotal;
            string gender = Database.GlobalVariables.CurrentGender;

            if (remaining <= 0 && gender.Contains("Female")) {
                lbl_bender.Text = "Slow down, little missy.";
                lbl_bender.ForeColor = Color.Red;
            }
            else if (remaining <= 0 && gender.Contains("Male")) {
                lbl_bender.Text = "Slow down, fatso.";
                lbl_bender.ForeColor = Color.Red;
            }
            else if (remaining > 0 && gender.Contains("Male"))
            {
                lbl_bender.Text = "Keep going, my dude.";
                lbl_bender.ForeColor = Color.LightGreen;
            }
            else if (remaining > 0 && gender.Contains("Female"))
            {
                lbl_bender.Text = "Keep going, Girl.";
                lbl_bender.ForeColor = Color.LightGreen;
            }
            else
            {
                lbl_bender.Text = "I don't know what gender you are, but I like you anyway.";
            }

            lbl_remaining.Text = remaining.ToString();
        }
        private int TotalBreakfastCalories(string username)
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
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
                return 0;
            }
        }
        private int TotalLunchCalories(string username)
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
                MessageBox.Show("Ops, something went wrong: " + ex.Message);
                return 0;
            }

        }
        private int TotalDinnerCalories(string username)
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

                MessageBox.Show("Ops, something went wrong: " + ex.Message);
                return 0;
            }

        }
        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lbl_bender_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
