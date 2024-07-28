using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorieCalculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            txt_username.Clear();
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
    }
}
