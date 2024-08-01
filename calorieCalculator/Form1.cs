using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace calorieCalculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PopulateComboBox();
            database.CreateDatabaseAndTables();
        }
        public static class GlobalVariables
        {
            public static int TargetCalories { get; set; }
        }

        private void getTargetCalories(string username)
        {
            try
            {
                string databasePath = database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databasePath}"))
                {
                    conn.Open();

                    string query = "SELECT TargetCalories FROM Users WHERE Username = @Username";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            Database.GlobalVariables.targetCalories = Convert.ToInt32(result);
                        }
                        else
                        {
                            Database.GlobalVariables.targetCalories = 0;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Opps something went wrong on: " + ex.Message);
            }
        }


        Database database = new Database();

        // for the username combobox
        private void PopulateComboBox()
        {
            try
            {
                string connectionString = "Data Source=" + database.GetDatabasePath();
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Username FROM Users";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox_username.Items.Add(reader.GetString(0));

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show( "Opps, something went wrong on: " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           Database database = new Database();

            database.GetDatabasePath();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_userName_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_createUser_Click(object sender, EventArgs e)
        {
            Form newUser = new addUser();

            newUser.Show();
        }

        private void lbl_createUser_MouseHover(object sender, EventArgs e)
        {
            lbl_createUser.ForeColor = Color.Red;
        }

        private void lbl_createUser_MouseLeave(object sender, EventArgs e)
        {
            lbl_createUser.ForeColor = Color.Black;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            lbl_createUser.ForeColor = Color.Red;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            lbl_createUser.ForeColor = Color.Black;
        }

        private void lbl_createUser_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Form newUser = new addUser();
            newUser.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox_username.Items.Clear();
            PopulateComboBox();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (comboBox_username.SelectedIndex != -1)
            {
                Database.GlobalVariables.currentUser = comboBox_username.SelectedItem.ToString();
                getTargetCalories(comboBox_username.SelectedItem.ToString());
                this.Hide();
                
                Form form = new logFood();
                form.Show();
            }
            else { 
                comboBox_username.BackColor = Color.Red;
                MessageBox.Show("Please select a username");
            }
        }

        private void comboBox_username_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
