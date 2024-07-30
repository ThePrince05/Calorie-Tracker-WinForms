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

        
       Database database = new Database();

        // for the username combobox
        private void PopulateComboBox()
        {
            string connectionString = "Data Source=" + database.GetDatabasePath(); // Replace with your database path
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
                this.Hide();
                
                Form editUser = new editUser();
                editUser.Show();
            }
            else { 
                comboBox_username.BackColor = Color.Red;
                MessageBox.Show("Please select a username");
            }
        }
    }
}
