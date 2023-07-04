namespace WinFormsApp1
{
    partial class task_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(task_manager));
            todo_label = new Label();
            title_lbl = new Label();
            desc_lbl = new Label();
            due_lbl = new Label();
            priority_lbl = new Label();
            status_lbl = new Label();
            title_input = new TextBox();
            desc_input = new TextBox();
            due_input = new DateTimePicker();
            priority_combo = new ComboBox();
            taskBindingSource = new BindingSource(components);
            status_combo = new ComboBox();
            dataview = new DataGridView();
            new_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            save_btn = new Button();
            order_lbl = new Label();
            sort = new ComboBox();
            logout = new LinkLabel();
            defbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            SuspendLayout();
            // 
            // todo_label
            // 
            todo_label.AutoSize = true;
            todo_label.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            todo_label.ForeColor = Color.Yellow;
            todo_label.Location = new Point(518, 9);
            todo_label.Name = "todo_label";
            todo_label.Size = new Size(164, 45);
            todo_label.TabIndex = 0;
            todo_label.Text = "To Do List";
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            title_lbl.ForeColor = Color.Cyan;
            title_lbl.Location = new Point(12, 65);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(77, 32);
            title_lbl.TabIndex = 1;
            title_lbl.Text = "Title:";
            title_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // desc_lbl
            // 
            desc_lbl.AutoSize = true;
            desc_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            desc_lbl.ForeColor = Color.Cyan;
            desc_lbl.Location = new Point(12, 124);
            desc_lbl.Name = "desc_lbl";
            desc_lbl.Size = new Size(165, 32);
            desc_lbl.TabIndex = 1;
            desc_lbl.Text = "Description:";
            desc_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // due_lbl
            // 
            due_lbl.AutoSize = true;
            due_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            due_lbl.ForeColor = Color.Cyan;
            due_lbl.Location = new Point(12, 179);
            due_lbl.Name = "due_lbl";
            due_lbl.Size = new Size(135, 32);
            due_lbl.TabIndex = 1;
            due_lbl.Text = "Due time:";
            due_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // priority_lbl
            // 
            priority_lbl.AutoSize = true;
            priority_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            priority_lbl.ForeColor = Color.Cyan;
            priority_lbl.Location = new Point(12, 238);
            priority_lbl.Name = "priority_lbl";
            priority_lbl.Size = new Size(111, 32);
            priority_lbl.TabIndex = 1;
            priority_lbl.Text = "Priority:";
            priority_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            status_lbl.ForeColor = Color.Cyan;
            status_lbl.Location = new Point(12, 290);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(103, 32);
            status_lbl.TabIndex = 1;
            status_lbl.Text = "Status:";
            status_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // title_input
            // 
            title_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title_input.Location = new Point(181, 65);
            title_input.Name = "title_input";
            title_input.Size = new Size(373, 39);
            title_input.TabIndex = 2;
            // 
            // desc_input
            // 
            desc_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            desc_input.Location = new Point(181, 116);
            desc_input.Name = "desc_input";
            desc_input.Size = new Size(373, 39);
            desc_input.TabIndex = 2;
            // 
            // due_input
            // 
            due_input.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            due_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            due_input.Location = new Point(181, 173);
            due_input.Name = "due_input";
            due_input.Size = new Size(373, 39);
            due_input.TabIndex = 3;
            // 
            // priority_combo
            // 
            priority_combo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priority_combo.FormattingEnabled = true;
            priority_combo.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priority_combo.Location = new Point(181, 230);
            priority_combo.Name = "priority_combo";
            priority_combo.Size = new Size(373, 40);
            priority_combo.TabIndex = 4;
            // 
            // status_combo
            // 
            status_combo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            status_combo.FormattingEnabled = true;
            status_combo.Items.AddRange(new object[] { "Not started", "In progress", "Completed" });
            status_combo.Location = new Point(181, 282);
            status_combo.Name = "status_combo";
            status_combo.Size = new Size(373, 40);
            status_combo.TabIndex = 4;
            // 
            // dataview
            // 
            dataview.AllowUserToAddRows = false;
            dataview.AllowUserToDeleteRows = false;
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataview.BackgroundColor = SystemColors.ControlLight;
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataview.Cursor = Cursors.Hand;
            dataview.Dock = DockStyle.Bottom;
            dataview.GridColor = SystemColors.ScrollBar;
            dataview.Location = new Point(0, 346);
            dataview.Name = "dataview";
            dataview.ReadOnly = true;
            dataview.RowHeadersWidth = 62;
            dataview.RowTemplate.Height = 33;
            dataview.Size = new Size(1178, 328);
            dataview.TabIndex = 5;
            // 
            // new_btn
            // 
            new_btn.BackColor = Color.Transparent;
            new_btn.Cursor = Cursors.Hand;
            new_btn.FlatStyle = FlatStyle.Flat;
            new_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            new_btn.ForeColor = Color.White;
            new_btn.Location = new Point(712, 59);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(140, 81);
            new_btn.TabIndex = 6;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = false;
            new_btn.Click += new_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.Transparent;
            edit_btn.Cursor = Cursors.Hand;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            edit_btn.ForeColor = Color.Cyan;
            edit_btn.Location = new Point(879, 59);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(140, 81);
            edit_btn.TabIndex = 6;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Transparent;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.Red;
            delete_btn.Location = new Point(712, 173);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(140, 81);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Transparent;
            save_btn.Cursor = Cursors.Hand;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.ForeColor = Color.Lime;
            save_btn.Location = new Point(879, 173);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(140, 81);
            save_btn.TabIndex = 6;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // order_lbl
            // 
            order_lbl.AutoSize = true;
            order_lbl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            order_lbl.ForeColor = Color.Cyan;
            order_lbl.Location = new Point(692, 284);
            order_lbl.Name = "order_lbl";
            order_lbl.Size = new Size(95, 32);
            order_lbl.TabIndex = 1;
            order_lbl.Text = "Status";
            order_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // sort
            // 
            sort.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sort.FormattingEnabled = true;
            sort.ImeMode = ImeMode.NoControl;
            sort.Items.AddRange(new object[] { "Title", "Descritption", "Due time", "Priority", "Status" });
            sort.Location = new Point(843, 276);
            sort.Name = "sort";
            sort.Size = new Size(208, 46);
            sort.TabIndex = 4;
            sort.SelectedIndexChanged += sort_SelectedIndexChanged;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.LinkColor = Color.Red;
            logout.Location = new Point(1076, 9);
            logout.Name = "logout";
            logout.Size = new Size(74, 25);
            logout.TabIndex = 7;
            logout.TabStop = true;
            logout.Text = "Log out";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // defbtn
            // 
            defbtn.FlatStyle = FlatStyle.Flat;
            defbtn.ForeColor = Color.Yellow;
            defbtn.Location = new Point(1071, 279);
            defbtn.Name = "defbtn";
            defbtn.Size = new Size(95, 41);
            defbtn.TabIndex = 8;
            defbtn.Text = "Default";
            defbtn.UseVisualStyleBackColor = true;
            defbtn.Click += defbtn_Click;
            // 
            // task_manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1178, 674);
            Controls.Add(defbtn);
            Controls.Add(logout);
            Controls.Add(save_btn);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(new_btn);
            Controls.Add(dataview);
            Controls.Add(status_combo);
            Controls.Add(sort);
            Controls.Add(priority_combo);
            Controls.Add(due_input);
            Controls.Add(desc_input);
            Controls.Add(title_input);
            Controls.Add(order_lbl);
            Controls.Add(status_lbl);
            Controls.Add(priority_lbl);
            Controls.Add(due_lbl);
            Controls.Add(desc_lbl);
            Controls.Add(title_lbl);
            Controls.Add(todo_label);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "task_manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To do list";
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label todo_label;
        private Label title_lbl;
        private Label desc_lbl;
        private Label due_lbl;
        private Label priority_lbl;
        private Label status_lbl;
        private TextBox title_input;
        private TextBox desc_input;
        private DateTimePicker due_input;
        private ComboBox priority_combo;
        private BindingSource taskBindingSource;
        private ComboBox status_combo;
        private DataGridView dataview;
        private Button new_btn;
        private Button edit_btn;
        private Button delete_btn;
        private Button save_btn;
        private Label order_lbl;
        private ComboBox sort;
        private LinkLabel logout;
        private Button defbtn;
    }
}