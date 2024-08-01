using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace calorieCalculator
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        private void clearFields() {
            txt_name.Clear();
            txt_surname.Clear();
            txt_age.Clear();
            txt_userHeight.Clear();
            txt_userWeight.Clear();
        }

        private int caloriesIntake(int age, double height, double weight, string gender) {
            int calories = 0;
            
            if (gender.Contains("Female"))
            {
                double BMR = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                calories = Convert.ToInt32(Math.Round(BMR * 1.375));
            }

            if (gender.Contains("Male"))
            {
                double BMR = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                calories = Convert.ToInt32(Math.Round(BMR * 1.375));
               
            }

            return calories;
        }
        private bool validateForm()
        {
            int invalidcount = 0;
            int namelengthcount = 0;
            int nameblankcount = 0;

            int surnamelengthcount = 0;
            int surnameblankcount = 0;

            int combocount = 0;

            int ageblankcount = 0;
            int agenumbercount = 0;

            int heightblankcount = 0;
            int heightnumbercount = 0;

            int weightblankcount = 0;
            int weightnumbercount = 0;

                // name length
                if ((txt_name.Text.Length >= 3) && !(txt_name.Text == "Name must be at least 3 characters long."))
                {
                    if (namelengthcount > 0)
                    {
                        namelengthcount = 0;
                    }

                }
                else
                {
                    namelengthcount++;
                    txt_name.Text = "Name must be at least 3 characters long.";

                }

                // if name is blank
                if (!((txt_name.Text == "") && (txt_name.Text == "Name can't be blank.")))
                {
                    if (nameblankcount > 0)
                    {
                        nameblankcount = 0;

                    }

                }
                else
                {
                    nameblankcount = nameblankcount + 1;
                    txt_name.Text = "Name can't be blank.";

                }


                // surname length
                if ((txt_surname.Text.Length >= 3) && !(txt_surname.Text == "Surname must be at least 3 characters long."))
                {
                    if (surnamelengthcount > 0)
                    {
                        surnamelengthcount = 0;

                    }
                }
                else
                {
                    surnamelengthcount++;
                    txt_surname.Text = "Surname must be at least 3 characters long.";

                }

                // if surname is blank
                if (!((txt_surname.Text == "") && (txt_surname.Text == "Surname can't be blank.")))
                {
                    if (surnameblankcount > 0)
                    {
                        surnameblankcount = 0;

                    }
                }
                else
                {
                    surnameblankcount++;
                    txt_surname.Text = "Surname can't be blank.";

                }

                // is age number
                Validation validation = new Validation();

                if ((validation.isNumber(txt_age.Text) == true) && !(txt_age.Text == "The age must be a number."))
                {

                    if (agenumbercount > 0)
                    {
                        agenumbercount = 0;

                    }
                }
                else
                {
                    agenumbercount++;
                    txt_age.Text = "The age must be a number.";

                }

                // is age blank
                if (!((txt_age.Text == "") && (txt_age.Text == "The age must not be blank.")))
                {

                    if (ageblankcount > 0)
                    {
                        ageblankcount = 0;

                    }
                }
                else
                {
                    ageblankcount++;
                    txt_age.Text = "The age must not be blank.";

                }



            // is height number

                if ((validation.isNumber(txt_userHeight.Text) == true) && !(txt_userHeight.Text == "The height must be a number."))
                {

                    if (heightnumbercount > 0)
                    {
                        heightnumbercount = 0;

                    }
                }
                else
                {
                    heightnumbercount++;
                    txt_userHeight.Text = "The height must be a number.";

                }

                // is height blank
                if (!((txt_userHeight.Text == "" ) && (txt_userHeight.Text == "The height must not be blank.")))
                {

                    if (heightblankcount > 0)
                    {
                        heightblankcount = 0;

                    }
                }
                else
                {
                    heightblankcount++;
                    txt_userHeight.Text = "The height must not be blank.";

                }

                // is weight number
                if ((validation.isNumber(txt_userWeight.Text) == true) && !(txt_userWeight.Text == "The weight must be a number."))
                {

                    if (weightnumbercount > 0)
                    {
                        weightnumbercount = 0;

                    }
                   
                }
                else
                {
                    weightnumbercount++;
                    txt_userWeight.Text = "The weight must be a number.";

                }

                // is weight blank
                if (!((txt_userWeight.Text == "") && (txt_userWeight.Text == "The weight must not be blank.")))
                    {

                        if (weightblankcount > 0)
                        {
                            weightblankcount = 0;

                        }
                    }
                else
                {
                    weightblankcount++;
                    txt_userWeight.Text = "The weight must not be blank.";

                }


                //gender
                if (!(comboBox_gender.SelectedIndex == -1))
                {
                    if (combocount > 0)
                    {
                        combocount = 0;
                    }
                    
                }
                else
                {
                    combocount++;
                    MessageBox.Show("Please select a gender");
                }


                // setting up the back ground colour of the textboxes
                if (nameblankcount > 0 || namelengthcount > 0)
                {
                    txt_name.BackColor = Color.Red;
                }
                else
                {
                    txt_name.BackColor = Color.White;
                }

                if (surnameblankcount > 0 || surnamelengthcount > 0)
                {
                    txt_surname.BackColor = Color.Red;
                }
                else
                {
                    txt_surname.BackColor = Color.White;
                }

                if (ageblankcount > 0 || agenumbercount > 0)
                {
                    txt_age.BackColor = Color.Red;
                }
                else
                {
                    txt_age.BackColor = Color.White;
                }


            if (heightblankcount > 0 || heightnumbercount > 0)
                {
                    txt_userHeight.BackColor = Color.Red;
                }
                else
                {
                    txt_userHeight.BackColor = Color.White;
                }

                if (weightblankcount > 0 || weightnumbercount > 0)
                {
                    txt_userWeight.BackColor = Color.Red;
                }
                else
                {
                    txt_userWeight.BackColor = Color.White;
                }

                if (combocount > 0)
                {
                    comboBox_gender.BackColor = Color.Red;
                }
                else
                {
                    comboBox_gender.BackColor = Color.White;
                }


            invalidcount = namelengthcount + nameblankcount + surnamelengthcount + surnameblankcount + combocount + ageblankcount + agenumbercount + heightblankcount + heightnumbercount + weightblankcount + weightnumbercount;

                if (invalidcount == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

         
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();

                if (validateForm() == true)
                {

                    string Username = database.generateUsername(txt_name.Text);
                    string Name = txt_name.Text;
                    string Surname = txt_surname.Text;
                    string Gender = comboBox_gender.SelectedItem.ToString();
                    int Age = Convert.ToInt32(txt_age.Text);
                    double Height = Convert.ToDouble(txt_userHeight.Text);
                    double Weight = Convert.ToDouble(txt_userWeight.Text);
                    int TargetCalories = caloriesIntake(Age, Height, Weight, Gender);


                    database.insertUser(Username, Name, Surname, Gender, Age, Height, Weight, TargetCalories);
                    clearFields();

                    this.Close();
                }
            } catch(Exception ex) {
                MessageBox.Show("Opps, something went wrong on: " + ex.Message);
            }
        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }

        private void lbl_surname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_userHeight_Click(object sender, EventArgs e)
        {

        }

        private void lbl_userWeight_Click(object sender, EventArgs e)
        {

        }

        private void txt_userHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_userWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_userName_Click(object sender, EventArgs e)
        {

        }
    }
}
