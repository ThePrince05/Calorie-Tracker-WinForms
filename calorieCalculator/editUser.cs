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
    public partial class editUser : Form
    {
       

        public editUser()
        {
            InitializeComponent();
            DisplayUserInfo(Database.GlobalVariables.CurrentUser);
        }
        readonly Database database = new Database();

        private void DisplayUserInfo(string username)
        {
                      
            txt_currentName.Text = Database.GlobalVariables.CurrentName;
            txt_currentSurname.Text = Database.GlobalVariables.CurrentSurname;
            txt_currentGender.Text = Database.GlobalVariables.CurrentGender;
            txt_currentAge.Text = Database.GlobalVariables.CurrentAge.ToString();
            txt_currentHeight.Text = Database.GlobalVariables.CurrentHeight.ToString();
            txt_currentWeight.Text = Database.GlobalVariables.CurrentWeight.ToString();
            txt_currentCalories.Text = Database.GlobalVariables.CurrentTargetCalories.ToString();


        }

        
        private void ClearFields() {
            txt_name.Clear();
            txt_surname.Clear();
            txt_age.Clear();
            txt_userHeight.Clear();
            txt_userWeight.Clear();
            txt_calories.Clear();

        }
        //validation
        private bool ValidateForm()
        {
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

            int caloriesblankcount = 0;
            int caloriesnumbercount = 0;

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
                nameblankcount++;
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
            if (!((txt_userHeight.Text == "") && (txt_userHeight.Text == "The height must not be blank.")))
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


            // is calories number
            if ((validation.isNumber(txt_calories.Text) == true) && !(txt_calories.Text == "The calories must be a number."))
            {

                if (caloriesnumbercount > 0)
                {
                    caloriesnumbercount = 0;

                }

            }
            else
            {
                caloriesnumbercount++;
                txt_calories.Text = "The calories must be a number.";

            }

            // is calories blank
            if (!((txt_calories.Text == "") && (txt_calories.Text == "The calories must not be blank.")))
            {

                if (caloriesblankcount > 0)
                {
                    caloriesblankcount = 0;

                }
            }
            else
            {
                caloriesblankcount++;
                txt_calories.Text = "The calories must not be blank.";

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

            if (caloriesblankcount > 0 || caloriesnumbercount > 0)
            {
                txt_calories.BackColor = Color.Red;
            }
            else
            {
                txt_calories.BackColor = Color.White;
            }

            if (combocount > 0)
            {
                comboBox_gender.BackColor = Color.Red;
            }
            else
            {
                comboBox_gender.BackColor = Color.White;
            }


            int invalidcount = namelengthcount + nameblankcount + surnamelengthcount + surnameblankcount + combocount + ageblankcount + agenumbercount + heightblankcount + heightnumbercount + weightblankcount + weightnumbercount + caloriesblankcount + caloriesnumbercount;

            if (invalidcount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void editUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() == true)
                {

                    string Username = Database.GlobalVariables.CurrentUser;
                    string Name = txt_name.Text;
                    string Surname = txt_surname.Text;
                    string Gender = comboBox_gender.SelectedItem.ToString();
                    int Age = Convert.ToInt32(txt_age.Text);
                    double Height = Convert.ToDouble(txt_userHeight.Text);
                    double Weight = Convert.ToDouble(txt_userWeight.Text);
                    int TargetCalories = Convert.ToInt32(txt_calories.Text);


                    MessageBox.Show(database.UpdateUser(Username, Name, Surname, Gender, Age, Height, Weight, TargetCalories) ? "User Updated Successfully" : " User Update Failed");
                }
            } 
            catch(Exception ex) {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);    
            }
        }

        private void editUser_Resize(object sender, EventArgs e)
        {
            
        }

        private void txt_currentHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentCalories_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentName_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txt_currentSurname_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void txt_currentAge_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void txt_currentGender_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_currentHeight_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void txt_currentWeight_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void txt_currentCalories_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_currentName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_currentName_Click(object sender, EventArgs e)
        {
            txt_name.Text = txt_currentName.Text;
        }

        private void txt_currentSurname_Click(object sender, EventArgs e)
        {
            txt_surname.Text = txt_currentSurname.Text;
        }

        private void txt_currentAge_Click(object sender, EventArgs e)
        {
             txt_age.Text = txt_currentAge.Text;
        }

        private void txt_currentGender_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_currentHeight_Click(object sender, EventArgs e)
        {
            txt_userHeight.Text = txt_currentHeight.Text;
        }

        private void txt_currentWeight_Click(object sender, EventArgs e)
        {
            txt_userWeight.Text = txt_currentWeight.Text;
        }

        private void txt_currentCalories_Click(object sender, EventArgs e)
        {
            txt_calories.Text = txt_currentCalories.Text;
        }

        private void btn_save_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() == true)
                {

                    string Username = Database.GlobalVariables.CurrentUser;
                    string Name = txt_name.Text;
                    string Surname = txt_surname.Text;
                    string Gender = comboBox_gender.SelectedItem.ToString();
                    int Age = Convert.ToInt32(txt_age.Text);
                    double Height = Convert.ToDouble(txt_userHeight.Text);
                    double Weight = Convert.ToDouble(txt_userWeight.Text);
                    int TargetCalories = Convert.ToInt32(txt_calories.Text);


                    MessageBox.Show(database.UpdateUser(Username, Name, Surname, Gender, Age, Height, Weight, TargetCalories) ? "User Updated Successfully" : " User Update Failed");
                    ClearFields();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, something went wrong on: " + ex.Message);
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
