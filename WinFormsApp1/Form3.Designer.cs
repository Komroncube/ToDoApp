namespace WinFormsApp1
{
    partial class Create_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_user));
            sign_lbl = new Label();
            fname_lbl = new Label();
            lname_lbl = new Label();
            birth_lbl = new Label();
            username_lbl = new Label();
            pass_lbl = new Label();
            fname_input = new TextBox();
            lname_input = new TextBox();
            date_input = new DateTimePicker();
            username_input = new TextBox();
            Show = new CheckBox();
            password_input = new TextBox();
            save_btn = new Button();
            button2 = new Button();
            error = new Label();
            age = new Label();
            SuspendLayout();
            // 
            // sign_lbl
            // 
            sign_lbl.AutoSize = true;
            sign_lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            sign_lbl.ForeColor = Color.Yellow;
            sign_lbl.Location = new Point(215, 22);
            sign_lbl.Name = "sign_lbl";
            sign_lbl.Size = new Size(134, 45);
            sign_lbl.TabIndex = 0;
            sign_lbl.Text = "Sign up";
            // 
            // fname_lbl
            // 
            fname_lbl.AutoSize = true;
            fname_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fname_lbl.ForeColor = Color.Aqua;
            fname_lbl.Location = new Point(22, 100);
            fname_lbl.Name = "fname_lbl";
            fname_lbl.Size = new Size(125, 32);
            fname_lbl.TabIndex = 0;
            fname_lbl.Text = "First name";
            // 
            // lname_lbl
            // 
            lname_lbl.AutoSize = true;
            lname_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lname_lbl.ForeColor = Color.Aqua;
            lname_lbl.Location = new Point(22, 161);
            lname_lbl.Name = "lname_lbl";
            lname_lbl.Size = new Size(122, 32);
            lname_lbl.TabIndex = 0;
            lname_lbl.Text = "Last name";
            // 
            // birth_lbl
            // 
            birth_lbl.AutoSize = true;
            birth_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birth_lbl.ForeColor = Color.Aqua;
            birth_lbl.Location = new Point(22, 231);
            birth_lbl.Name = "birth_lbl";
            birth_lbl.Size = new Size(118, 32);
            birth_lbl.TabIndex = 0;
            birth_lbl.Text = "Birth date";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.Aqua;
            username_lbl.Location = new Point(26, 293);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(121, 32);
            username_lbl.TabIndex = 0;
            username_lbl.Text = "Username";
            // 
            // pass_lbl
            // 
            pass_lbl.AutoSize = true;
            pass_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pass_lbl.ForeColor = Color.Aqua;
            pass_lbl.Location = new Point(22, 350);
            pass_lbl.Name = "pass_lbl";
            pass_lbl.Size = new Size(111, 32);
            pass_lbl.TabIndex = 0;
            pass_lbl.Text = "Password";
            // 
            // fname_input
            // 
            fname_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fname_input.Location = new Point(190, 100);
            fname_input.Name = "fname_input";
            fname_input.Size = new Size(238, 39);
            fname_input.TabIndex = 1;
            // 
            // lname_input
            // 
            lname_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lname_input.Location = new Point(190, 161);
            lname_input.Name = "lname_input";
            lname_input.Size = new Size(238, 39);
            lname_input.TabIndex = 1;
            // 
            // date_input
            // 
            date_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_input.Location = new Point(190, 224);
            date_input.Name = "date_input";
            date_input.Size = new Size(238, 39);
            date_input.TabIndex = 2;
            // 
            // username_input
            // 
            username_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_input.Location = new Point(190, 286);
            username_input.Name = "username_input";
            username_input.Size = new Size(238, 39);
            username_input.TabIndex = 1;
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Show.ForeColor = SystemColors.ControlLightLight;
            Show.Location = new Point(450, 355);
            Show.Name = "Show";
            Show.Size = new Size(84, 29);
            Show.TabIndex = 6;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = true;
            Show.CheckedChanged += Show_CheckedChanged;
            // 
            // password_input
            // 
            password_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_input.Location = new Point(190, 350);
            password_input.Name = "password_input";
            password_input.Size = new Size(238, 39);
            password_input.TabIndex = 5;
            password_input.UseSystemPasswordChar = true;
            // 
            // save_btn
            // 
            save_btn.Cursor = Cursors.Hand;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save_btn.ForeColor = Color.Lime;
            save_btn.Location = new Point(416, 566);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(118, 57);
            save_btn.TabIndex = 7;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(281, 566);
            button2.Name = "button2";
            button2.Size = new Size(118, 57);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.FromArgb(192, 0, 0);
            error.Location = new Point(169, 405);
            error.Name = "error";
            error.Size = new Size(281, 75);
            error.TabIndex = 8;
            error.Text = "* At least one lowercase character\r\n* At least one uppercase character\r\n* At least one digit";
            error.Visible = false;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            age.ForeColor = Color.FromArgb(192, 0, 0);
            age.Location = new Point(445, 224);
            age.Name = "age";
            age.Size = new Size(93, 32);
            age.TabIndex = 9;
            age.Text = "3 age+";
            age.Visible = false;
            // 
            // Create_user
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(589, 635);
            Controls.Add(age);
            Controls.Add(error);
            Controls.Add(button2);
            Controls.Add(save_btn);
            Controls.Add(Show);
            Controls.Add(password_input);
            Controls.Add(date_input);
            Controls.Add(username_input);
            Controls.Add(lname_input);
            Controls.Add(fname_input);
            Controls.Add(pass_lbl);
            Controls.Add(username_lbl);
            Controls.Add(birth_lbl);
            Controls.Add(lname_lbl);
            Controls.Add(fname_lbl);
            Controls.Add(sign_lbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Create_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sign_lbl;
        private Label fname_lbl;
        private Label lname_lbl;
        private Label birth_lbl;
        private Label username_lbl;
        private Label pass_lbl;
        private TextBox fname_input;
        private TextBox lname_input;
        private DateTimePicker date_input;
        private TextBox username_input;
        private CheckBox Show;
        private TextBox password_input;
        private Button save_btn;
        private Button button2;
        private Label error;
        private Label age;
    }
}