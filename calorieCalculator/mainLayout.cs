using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using FontAwesome.Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace calorieCalculator
{
    public partial class mainLayout : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public mainLayout()
        {


            InitializeComponent();
            lbl_username.Text = Database.GlobalVariables.CurrentUser;
            GetUserInfo(Database.GlobalVariables.CurrentUser);

            CallSchool();

            DateTime today = DateTime.Today;
            Database.GlobalVariables.CurrentTargetCalories = GetHomeCalories(Database.GlobalVariables.CurrentUser, today);

            DateTime dateObj = DateTime.Today;
            string date = dateObj.ToString();


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        readonly Database database = new Database();
        static void CallSchool()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filePath = Path.Combine(appDataPath, "Calorie Tracker", "schoolAttendance.txt");
            string username = Database.GlobalVariables.CurrentUser;

            // Get today's date
            DateTime today = DateTime.Today;

            Database database = new Database();
            // Check if user has already been prompted
            if (CheckAttendance(filePath, username, today))
            {
                //MessageBox.Show("You've already been asked about today's attendance.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Did you go to school today?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string answer;
                int calories = database.GetTargetCaloriesByUsername(Database.GlobalVariables.CurrentUser);

                if (result == DialogResult.Yes)
                {
                    // Perform action if user clicks Yes
                    answer = "Yes";

                }
                else
                {
                    // Perform action if user clicks No
                    answer = "No";
                    calories -= 200;
                }

                // Append attendance data to the file

                WriteAttendance(filePath, username, today, answer, calories);
            }
        }
        static int GetHomeCalories(string username, DateTime today)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filePath = Path.Combine(appDataPath, "Calorie Tracker", "schoolAttendance.txt");

            Database database = new Database();
            int defaultCalories = database.GetTargetCaloriesByUsername(Database.GlobalVariables.CurrentUser);

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(':');
                    if (data.Length == 4 && data[0] == username && data[1] == today.ToString("yyyy-MM-dd") && data[2] == "No")
                    {
                        return Convert.ToInt32(data[3]);
                    }
                }
            }

            return defaultCalories;
        }
        static bool CheckAttendance(string filePath, string username, DateTime today)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split(':');
                if (data[0] == username && data[1] == today.ToString("yyyy-MM-dd"))
                {
                    return true;
                }
            }
            return false;
        }

        static void WriteAttendance(string filePath, string username, DateTime today, string answer, int calories)
        {
            File.AppendAllText(filePath, $"{username}:{today:yyyy-MM-dd}:{answer}:{calories}\n");
        }
        private void GetUserInfo(string username)
        {
            try
            {
                string connectionString = "Data Source=" + database.GetDatabasePath(); // Replace with your database path
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Name, Surname, Gender, Age, Height, Weight, TargetCalories FROM Users WHERE Username = @Username";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Database.GlobalVariables.CurrentName = reader.GetString(0);
                                Database.GlobalVariables.CurrentSurname = reader.GetString(1);
                                Database.GlobalVariables.CurrentGender = reader.GetString(2);
                                Database.GlobalVariables.CurrentAge = reader.GetInt32(3);
                                Database.GlobalVariables.CurrentHeight = reader.GetDouble(4);
                                Database.GlobalVariables.CurrentWeight = reader.GetDouble(5);
                                //Database.GlobalVariables.CurrentTargetCalories = reader.GetInt32(6);
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

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                // iconCurrentChildForm.IconChar = currentBtn.IconChar;
                // iconCurrentChildForm.IconChar = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            // if (iconCurrentChildForm != null) { }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void mainLayout_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new dashboard());
        }

        private void btn_logMeal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new logMeal());
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new history());
        }

        private void btn_manageFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new manageFood());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new editUser());
        }

        private void iconPictureBox_user_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_logout_MouseHover(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.Red;
        }

        private void lbl_logout_MouseLeave(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.RoyalBlue;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            bool MousePointerNotOnTaskBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskBar)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.ShowBalloonTip(2000);
                notifyIcon1.Visible = true;
            }


        }
        private void mainLayout_SizeChanged(object sender, EventArgs e)
        {

           
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
