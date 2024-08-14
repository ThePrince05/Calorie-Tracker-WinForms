using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorieCalculator
{
    public partial class deleteUser : Form
    {
        public deleteUser()
        {
            InitializeComponent();
            PopulateComboBox();
        }
        

        readonly Database database = new Database();
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
            catch (Exception ex)
            {

                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }

        private void deleteUser_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            comboBox_username.Items.Clear();
            PopulateComboBox();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (comboBox_username.SelectedIndex != -1)
            {
                database.DeleteUser(comboBox_username.SelectedItem.ToString());
                this.Close();
 
               
            }
            else
            {
                comboBox_username.BackColor = Color.Red;
                MessageBox.Show("Please select a username");
            }
        }
    }
}
