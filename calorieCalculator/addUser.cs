using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorieCalculator
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        private bool validateForm() {
            int invalidcount = 0;
            int namelengthcount = 0;
            int nameblankcount = 0;

            int surnamelengthcount = 0;
            int surnameblankcount = 0;

            int combocount = 0;

            int heightblankcount = 0;
            int heightnumbercount = 0;

            int weightblankcount = 0;
            int weightnumbercount = 0;

            // name length
            if (txt_name.Text.Length >= 3 && !(txt_name.Text == "Name must be at least 3 characters long."))
            {
                if (namelengthcount > 0) {
                    namelengthcount = 0;
                    txt_name.BackColor = Color.White;
                }
            }
            else {
                namelengthcount = namelengthcount + 1;
                txt_name.Text = "Name must be at least 3 characters long.";
                txt_name.BackColor = Color.Red;
            }

            // if name is blank
            if (!(txt_name.Text == "" && txt_name.Text == "Name can't be blank."))
            {
                if (nameblankcount > 0) {
                    nameblankcount = 0;
                    txt_name.BackColor = Color.White;
                }
            }
            else
            {
                nameblankcount = nameblankcount + 1;
                txt_name.Text = "Name can't be blank.";
                txt_name.BackColor = Color.Red;
            }


            // surname length
            if (txt_surname.Text.Length >= 3 && !(txt_surname.Text == "Surname must be at least 3 characters long."))
            {
                if (surnamelengthcount > 0)
                {
                    surnamelengthcount = 0;
                    txt_surname.BackColor = Color.White;
                }
            }
            else
            {
                surnamelengthcount = surnamelengthcount + 1;
                txt_surname.Text = "Surname must be at least 3 characters long.";
                txt_surname.BackColor = Color.Red;
            }

            // if surname is blank
            if (!(txt_surname.Text == "" && txt_surname.Text == "Surname can't be blank."))
            {
                if (surnameblankcount > 0)
                {
                    surnameblankcount = 0;
                    txt_surname.BackColor = Color.White;
                }
            }
            else
            {
                surnameblankcount = surnameblankcount + 1;
                txt_surname.Text = "Surname can't be blank.";
                txt_surname.BackColor = Color.Red;
            }

            // is height number
            Validation validation = new Validation();

            if ((validation.isNumber(txt_userHeight.Text).ToString() == "True") && !(txt_userHeight.Text == "The height must be a number."))
            {

                if (heightnumbercount > 0)
                {
                    heightnumbercount = 0;
                    txt_userHeight.BackColor = Color.White;
                }
            }
            else {
                heightnumbercount = heightnumbercount + 1;
                txt_userHeight.Text = "The height must be a number.";
                txt_userHeight.BackColor = Color.Red;
            }

            // is height blank
            if (!(txt_userHeight.Text == "" && txt_userHeight.Text == "The height must not be blank."))
            {

                if (heightblankcount > 0)
                {
                    heightblankcount = 0;
                    txt_userHeight.BackColor = Color.White;
                }
            }
            else
            {
                heightblankcount = heightblankcount + 1;
                txt_userHeight.Text = "The height must not be blank.";
                txt_userHeight.BackColor = Color.Red;
            }

            // is weight number
           
             if (validation.isNumber(txt_userWeight.Text) == true && !(txt_userWeight.Text == "The weight must be a number."))
            {

                if (weightnumbercount > 0)
                {
                    weightnumbercount = 0;
                    txt_userWeight.BackColor = Color.White;
                }
            }
            else
            {
                weightnumbercount = weightnumbercount + 1;
                txt_userWeight.Text = "The weight must be a number.";
                txt_userWeight.BackColor = Color.Red;
            }

            // is weight blank
            if (!(txt_userWeight.Text == "" && txt_userWeight.Text == "The weight must not be blank."))
            {

                if (weightblankcount > 0)
                {
                    weightblankcount = 0;
                    txt_userWeight.BackColor = Color.White;
                }
            }
            else
            {
                weightblankcount = weightblankcount + 1;
                txt_userWeight.Text = "The weight must not be blank.";
                txt_userWeight.BackColor = Color.Red;
            }
            

            //gender
            if (!(comboBox_gender.SelectedIndex == -1))
            {
                if (combocount > 0)
                {
                    combocount = 0;
                }
                comboBox_gender.BackColor = Color.White;
            }
            else
            {
                comboBox_gender.BackColor = Color.Red;
                MessageBox.Show("Please select a gender");
            }

            invalidcount = namelengthcount + nameblankcount + surnamelengthcount + surnameblankcount + combocount + heightblankcount + heightnumbercount + weightblankcount + weightnumbercount;

            if (invalidcount == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

       // private string generateUsername() { 
        //    Random rnd = new Random();
        //    int randNum = rnd.Next(0,4);


       // }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_surname.Clear();
            txt_userHeight.Clear();
            txt_userWeight.Clear();
           
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
           MessageBox.Show(validateForm() == true ? "Yes" : "No" );
        }
    }
}
