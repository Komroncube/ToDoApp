global using ClassServises;

namespace WinFormsApp1
{
    public partial class LoginPage : Form
    {
        public task_manager task_Manager;
        Create_user create_User;
        public string userid = "";
        public LoginPage()
        {
            InitializeComponent();
            logint_txt.Select();

            create_User = new Create_user();
            create_User.FormClosing += CreateUser_FormClosing;
            var con = new DBConnect();
            
        }
        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }
        private void task_Manager_Fromclosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
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

        private void signin_btn_Click(object sender, EventArgs e)
        {

            error.Hide();
            //if (FileService.Checkuser(username_input.Text, password_input.Text, out userid) == false || DBConnect.CheckUser(username_input.Text, password_input.Text, out userid)==false)
            //{
            //    error.Text = "Invalid username or password";
            //    error.Show();
            //}
            if (DBConnect.CheckUser(username_input.Text, password_input.Text, out userid) == false)
            {
                error.Text = "Invalid username or password";
                error.Show();
            }
            else
            {
                task_Manager = new task_manager(userid);
                task_Manager.FormClosing += task_Manager_Fromclosing;

                task_Manager.Show();
                Hide();
            }

        }

        private void singup_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            create_User.Show();
            Hide();
        }
    }
}