namespace WinFormsApp1
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            logint_txt = new Label();
            username_input = new TextBox();
            password_input = new TextBox();
            signin_btn = new Button();
            singup_link = new LinkLabel();
            Show = new CheckBox();
            error = new Label();
            SuspendLayout();
            // 
            // logint_txt
            // 
            logint_txt.AutoSize = true;
            logint_txt.Font = new Font("Times New Roman", 28F, FontStyle.Regular, GraphicsUnit.Point);
            logint_txt.ForeColor = SystemColors.ControlLightLight;
            logint_txt.Location = new Point(93, 53);
            logint_txt.Name = "logint_txt";
            logint_txt.Size = new Size(533, 64);
            logint_txt.TabIndex = 0;
            logint_txt.Text = "Sign into your account";
            logint_txt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // username_input
            // 
            username_input.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            username_input.Location = new Point(210, 203);
            username_input.Name = "username_input";
            username_input.PlaceholderText = "username";
            username_input.Size = new Size(320, 50);
            username_input.TabIndex = 1;
            // 
            // password_input
            // 
            password_input.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            password_input.Location = new Point(210, 287);
            password_input.Name = "password_input";
            password_input.PlaceholderText = "password";
            password_input.Size = new Size(320, 50);
            password_input.TabIndex = 1;
            password_input.UseSystemPasswordChar = true;
            // 
            // signin_btn
            // 
            signin_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signin_btn.ImageAlign = ContentAlignment.TopCenter;
            signin_btn.Location = new Point(300, 366);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(152, 44);
            signin_btn.TabIndex = 2;
            signin_btn.Text = "Sign in";
            signin_btn.UseVisualStyleBackColor = true;
            signin_btn.Click += signin_btn_Click;
            // 
            // singup_link
            // 
            singup_link.ActiveLinkColor = Color.DarkGray;
            singup_link.AutoSize = true;
            singup_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            singup_link.LinkColor = Color.White;
            singup_link.Location = new Point(324, 432);
            singup_link.Name = "singup_link";
            singup_link.Size = new Size(96, 32);
            singup_link.TabIndex = 3;
            singup_link.TabStop = true;
            singup_link.Text = "Sign up";
            singup_link.LinkClicked += singup_link_LinkClicked;
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Show.ForeColor = SystemColors.ControlLightLight;
            Show.Location = new Point(542, 298);
            Show.Name = "Show";
            Show.Size = new Size(84, 29);
            Show.TabIndex = 4;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = true;
            Show.CheckedChanged += Show_CheckedChanged;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            error.ForeColor = Color.Red;
            error.Location = new Point(203, 141);
            error.Name = "error";
            error.Size = new Size(0, 32);
            error.TabIndex = 5;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(724, 740);
            Controls.Add(error);
            Controls.Add(Show);
            Controls.Add(singup_link);
            Controls.Add(signin_btn);
            Controls.Add(password_input);
            Controls.Add(username_input);
            Controls.Add(logint_txt);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logint_txt;
        private TextBox username_input;
        private TextBox password_input;
        private Button signin_btn;
        private LinkLabel singup_link;
        private CheckBox Show;
        private Label error;
    }
}