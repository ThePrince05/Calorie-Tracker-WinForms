
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;


namespace calorieCalculator
{
    internal class Database
    {
        // Create the database folder for the application
        internal string GetDatabasePath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string databasePath = Path.Combine(appDataPath, "Calorie Tracker", "calorieTracker.db"); // Replace "YourAppName" with your application's name

            // Create the necessary directories if they don't exist
            Directory.CreateDirectory(Path.GetDirectoryName(databasePath));

            return databasePath;
        }

        private void CreateDatabaseAndTables()
        {
            string databasePath = GetDatabasePath();
            SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}");
            conn.Open();

            // Create tables (if not exist)
            string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Height REAL,
                    Weight REAL,
                    TargetCalories INTEGER
                );

                -- Add other table creation statements

                    CREATE TABLE IF NOT EXISTS Foods (
                    FoodID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Calories INTEGER,
                    Protein REAL,
                    Carbohydrates REAL,
                    Fat REAL
                );

                CREATE TABLE IF NOT EXISTS Meals (
                    MealID INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserID INTEGER,
                    Date TEXT,
                    Time TEXT,
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );

                CREATE TABLE IF NOT EXISTS MealItems (
                    MealItemID INTEGER PRIMARY KEY AUTOINCREMENT,
                    MealID INTEGER,
                    FoodID INTEGER,
                    Quantity INTEGER,
                    FOREIGN KEY (MealID) REFERENCES Meals(MealID),
                    FOREIGN KEY (FoodID) REFERENCES Foods(FoodID)
                );
                ";
                

            using (SQLiteCommand cmd = new SQLiteCommand(createTablesQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

    }
}
