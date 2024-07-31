
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace calorieCalculator
{
    internal class Database
    {

        internal static class GlobalVariables
        {
            internal static string currentUser { get; set; }
        }
        internal string generateUsername(string firstname) {

            int count = 1; // Number of unique numbers to generate

            // text document directory
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filePath = Path.Combine(appDataPath,"Calorie Tracker", "unique_numbers.txt");

            // Create the directory if it doesn't exist
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            List<int> existingNumbers = new List<int>();
            if (File.Exists(filePath))
            {
                existingNumbers = File.ReadAllLines(filePath).Select(int.Parse).ToList();
            }

            List<int> uniqueNumbers = new List<int>();
            Random random = new Random();

            int userNumber = 0;
            while (uniqueNumbers.Count < count)
            {
                int number = random.Next(1000, 10000);
                if (!existingNumbers.Contains(number) && !uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                    userNumber = number;
                }
            }

            // Write numbers to the text file
            // Append numbers to the text file
            using (StreamWriter writer = File.AppendText(filePath))
            {
                foreach (int number in uniqueNumbers)
                {
                    writer.WriteLine(number);
                }
            }

            string username = firstname + userNumber;
            MessageBox.Show("Your new username is: " + username);
            return username;
            
        }

        // Create the database folder for the application
        internal string GetDatabasePath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string databasePath = Path.Combine(appDataPath, "Calorie Tracker", "calorieTracker.db"); // Replace "YourAppName" with your application's name

            // Create the necessary directories if they don't exist
            Directory.CreateDirectory(Path.GetDirectoryName(databasePath));

            return databasePath;
        }

        internal void CreateDatabaseAndTables()
        {
            string databasePath = GetDatabasePath();

            if (!File.Exists(databasePath))
            {
                using (var conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    try
                    {
                        conn.Open();

                    // Create tables (if not exist)
                    string createTablesQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                      Username Text PRIMARY KEY,
                      Name TEXT,
                      Surname TEXT,
                      Gender TEXT,
                      Age INTEGER,
                      Height REAL,
                      Weight REAL,
                      TargetCalories INTEGER
                    );

                    CREATE TABLE IF NOT EXISTS Foods (
                      FoodID INTEGER PRIMARY KEY AUTOINCREMENT,
                      FoodName TEXT,
                      Calories INTEGER
                    );

                    CREATE TABLE IF NOT EXISTS Meals (
                      MealID INTEGER PRIMARY KEY AUTOINCREMENT,
                      Username TEXT,
                      FoodName TEXT,
                      MealType TEXT,
                      Date TEXT,
                      Time TEXT,
                      CaloriesInServing INT,
                      FOREIGN KEY (Username) REFERENCES Users(Username)
                    ); ";

                    using (var cmd = new SQLiteCommand(createTablesQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Consider logging successful database and table creation
                    MessageBox.Show("Database and tables created successfully.");
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show($"Error creating database or tables: {ex.Message}");
                    }
                }
            }
            else
            {
                // MessageBox.Show("Database already exists.");
            }
        }
        internal void insertUser(string username, string name,string surname, string gender, int age, double height, double weight, int targetCalories) {
            try
            {
                string databasePath = GetDatabasePath();
                SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}");
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Users (Username, Name, Surname, Gender, Age, Height, Weight, TargetCalories) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@TargetCalories", targetCalories);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("User Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps something went wrong");
            }
        }
        internal void insertFood(string foodName, int calories)
        {
            try
            {
                string databasePath = GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    string query = "INSERT INTO Foods (FoodName, Calories) VALUES (@FoodName, @Calories)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FoodName", foodName);
                        cmd.Parameters.AddWithValue("@Calories", calories);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Food saved successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error adding food");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps something went wrong");
            }
        }
        internal void deleteFood(int foodId)
        {
            try
            {
                string databasePath = GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    string query = "DELETE FROM Foods WHERE FoodID = @FoodID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FoodID", foodId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Food deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting food");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps something went wrong");
            }
        }

        internal void updateFood(int foodId, string foodName, int calories)
        {
            try
            {
                string databasePath = GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    string query = "UPDATE Foods SET FoodName = @NewFoodName, Calories = @NewCalories WHERE FoodID = @FoodID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewFoodName", foodName);
                        cmd.Parameters.AddWithValue("@NewCalories", calories);
                        cmd.Parameters.AddWithValue("@FoodID", foodId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Food updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error updating food information");
                        }
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Opps something went wrong");
            }
        }

        internal void updateUser(string username, string name, string surname, string gender, int age, double height, double weight, int targetCalories)
        {
            try
            {
                string databasePath = GetDatabasePath();
                SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}");
                conn.Open();

                string query = "UPDATE Users SET Name = @Name, Surname = @Surname, Gender = @Gender, Age = @Age, Height = @Height, Weight = @Weight, TargetCalories = @TargetCalories WHERE Username = @Username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@TargetCalories", targetCalories);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error updating user information");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps something went wrong");
            }

        }

    }
}
