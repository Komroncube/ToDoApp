using ClassServises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = ClassServises.Status;

namespace WinFormsApp1
{
    public partial class task_manager : Form
    {
        private DataTable todolistview;
        private bool isediting;
        private bool isvalid;
        List<Taskdoing> tasks;
        private Taskdoing task;
        LoginPage loginpage;
        Action<DataTable, List<Taskdoing>> AddElements;
        public task_manager(string id)
        {
            InitializeComponent();

            tasks = new List<Taskdoing>();
            tasks.Loaddata(id);
            AddElements = Taskdoing.TaskToTable;
            todolistview = new DataTable();
            todolistview.Columns.Add("Id");
            todolistview.Columns.Add("Title");
            todolistview.Columns.Add("Description");
            todolistview.Columns.Add("Due date");
            todolistview.Columns.Add("Priority");
            todolistview.Columns.Add("Status");
            dataview.DataSource = todolistview;

            AddElements(todolistview, tasks);
            dataview.Columns[0].Visible = false;
            sort.DropDownStyle = ComboBoxStyle.DropDownList;
            status_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            status_combo.DataSource = Enum.GetValues(typeof(Status));
            status_combo.SelectedIndex = -1;
            priority_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            priority_combo.DataSource = Enum.GetValues(typeof(Priority));
            priority_combo.SelectedIndex = -1;
            sort.DropDownStyle = ComboBoxStyle.DropDownList;
            sort.DataSource = Enum.GetValues(typeof(Status));
            sort.SelectedIndex = -1;


        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
            title_lbl.ForeColor = Color.Cyan;
            priority_lbl.ForeColor = Color.Cyan;
            status_lbl.ForeColor = Color.Cyan;
            ClearFields();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            isediting = true;
            title_input.Text = todolistview.Rows[dataview.CurrentCell.RowIndex].ItemArray[1].ToString();
            desc_input.Text = todolistview.Rows[dataview.CurrentCell.RowIndex].ItemArray[2].ToString();
            string day = todolistview.Rows[dataview.CurrentCell.RowIndex].ItemArray[3].ToString();
            DateTime dt = DateTime.Parse(day);
            //DateOnly dateOnly = new DateOnly(dt.Year, dt.Month, dt.Day);
            due_input.Value = dt;
            int priority_item = priority_combo.FindStringExact(todolistview.Rows[dataview.CurrentCell.RowIndex].ItemArray[4].ToString());
            priority_combo.SelectedIndex = priority_item;
            int status_item = status_combo.FindStringExact(todolistview.Rows[dataview.CurrentCell.RowIndex].ItemArray[5].ToString());
            status_combo.SelectedIndex = status_item;

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string item = todolistview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString();
                int removeindex = tasks.FindIndex(x => x.Id.ToString() == item);
                if (removeindex != -1)
                {
                    tasks.RemoveAt(removeindex);
                    tasks.Savedata();
                    todolistview.Rows[dataview.CurrentCell.RowIndex].Delete();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            title_lbl.ForeColor = Color.Cyan;
            priority_lbl.ForeColor = Color.Cyan;
            status_lbl.ForeColor = Color.Cyan;
            isvalid = true;
            if (status_combo.SelectedIndex == -1)
            {
                status_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (priority_combo.SelectedIndex == -1)
            {
                priority_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (title_input.Text == "")
            {
                title_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (isvalid)
            {
                task = new Taskdoing();
                if (isediting)
                {
                    string item = todolistview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString();
                    int itemindex = tasks.FindIndex(x => x.Id.ToString() == item);
                    tasks[itemindex].Title = title_input.Text;
                    tasks[itemindex].Description = desc_input.Text;
                    DateTime dt = due_input.Value;
                    tasks[itemindex].DueDate = new DateOnly(dt.Year, dt.Month, dt.Day);

                    string selectedpriority = priority_combo.SelectedItem.ToString();
                    if (Enum.TryParse(selectedpriority, out Priority priorityvalue))
                    {
                        tasks[itemindex].Priority = priorityvalue;
                    }

                    string selectedstatus = status_combo.SelectedItem.ToString();
                    if (Enum.TryParse(selectedstatus, out ClassServises.Status statusvalue))
                    {
                        tasks[itemindex].Status = statusvalue;
                    }
                    todolistview.Rows[dataview.CurrentCell.RowIndex]["Title"] = title_input.Text;
                    todolistview.Rows[dataview.CurrentCell.RowIndex]["Description"] = desc_input.Text;
                    todolistview.Rows[dataview.CurrentCell.RowIndex]["Due date"] = tasks[itemindex].DueDate.ToString();
                    todolistview.Rows[dataview.CurrentCell.RowIndex]["Priority"] = priority_combo.SelectedItem.ToString();
                    todolistview.Rows[dataview.CurrentCell.RowIndex]["Status"] = status_combo.SelectedItem.ToString();
                }
                else
                {
                    task.Title = title_input.Text;
                    task.Description = desc_input.Text;
                    DateTime dt = due_input.Value;
                    task.DueDate = new DateOnly(dt.Year, dt.Month, dt.Day);
                    string selectedpriority = priority_combo.SelectedItem.ToString();
                    if (Enum.TryParse(selectedpriority, out Priority priorityvalue))
                    {
                        task.Priority = priorityvalue;
                    }
                    string selectedstatus = status_combo.SelectedItem.ToString();
                    if (Enum.TryParse(selectedstatus, out ClassServises.Status statusvalue))
                    {
                        task.Status = statusvalue;
                    }
                    tasks.Add(task);
                    todolistview.Clear();
                    AddElements(todolistview, tasks);
                }
                tasks.Savedata();
                filter();
                isediting = false;
                ClearFields();
            }
        }
        private void ClearFields()
        {
            title_input.Text = "";
            desc_input.Text = "";
            due_input.Text = "";
            priority_combo.SelectedIndex = -1;
            status_combo.SelectedIndex = -1;
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginpage = new LoginPage();
            loginpage.FormClosing += LoginPage_FormClosing;
            loginpage.Show();
            Hide();
        }

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            filter();
        }

        private void filter()
        {
            todolistview.Clear();
            if (sort.SelectedIndex == -1)
            {
                AddElements(todolistview, tasks);
            }
            else
            {
                if (Enum.TryParse(sort.SelectedItem.ToString(), out ClassServises.Status sortvalue))
                {
                    List<Taskdoing> value = tasks.Where(item => item.Status == sortvalue).ToList();
                    AddElements(todolistview, value);
                }
            }
            dataview.Columns[0].Visible = false;
        }
        private void defbtn_Click(object sender, EventArgs e)
        {
            sort.SelectedIndex = -1;
        }
    }
}
