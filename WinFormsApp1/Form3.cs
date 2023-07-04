using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Create_user : Form
    {
        private bool isvalid = true;
        public Create_user()
        {
            InitializeComponent();
        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Show.Checked == true)
            {
                password_input.UseSystemPasswordChar = false;
            }
            else
            {
                password_input.UseSystemPasswordChar = true;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            fname_lbl.ForeColor = Color.Cyan;
            lname_lbl.ForeColor = Color.Cyan;
            birth_lbl.ForeColor = Color.Cyan;
            username_lbl.ForeColor = Color.Cyan;
            pass_lbl.ForeColor = Color.Cyan;
            age.Visible = false;
            isvalid = true;
            error.Visible = false;
            if (fname_input.Text == "")
            {
                fname_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (lname_input.Text == "")
            {
                lname_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            var dt = DateTime.Now;
            var birthdt = date_input.Value;


            if (dt < birthdt.AddYears(3))
            {
                birth_lbl.ForeColor = Color.Red;
                age.Visible = true;
                isvalid = false;
            }
            if (username_input.Text == "" || !FileService.Checkuser(username_input.Text))
            {
                username_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (!ValidatePassword(password_input.Text))
            {
                pass_lbl.ForeColor = Color.Red;
                isvalid = false;
                error.Visible = true;
            }

            if (isvalid)
            {
                User user = new User();
                user.FirstName = fname_input.Text.Trim();
                user.LastName = lname_input.Text.Trim();
                var value = date_input.Value;
                user.BirthDate = new DateOnly(value.Year, value.Month, value.Day);
                user.Username = username_input.Text.Trim();
                user.Password = password_input.Text.Trim();
                FileService.CreateUser(user);
                SwitchWindow();
            }
        }
        private bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$";
            return Regex.IsMatch(password, pattern);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchWindow();
        }
        private void SwitchWindow()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.FormClosing += LoginPage_FormClosing;
            loginPage.Show();
            Hide();
        }
        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }
    }
}
