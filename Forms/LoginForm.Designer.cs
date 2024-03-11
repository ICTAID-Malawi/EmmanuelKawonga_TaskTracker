namespace TaskTrackerApp
{
    partial class LoginForm
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
            this.button_login = new System.Windows.Forms.Button();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_reglink = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.White;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(250, 397);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(259, 49);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textbox.Location = new System.Drawing.Point(230, 321);
            this.Password_textbox.Multiline = true;
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(319, 33);
            this.Password_textbox.TabIndex = 4;
            // 
            // Email_textbox
            // 
            this.Email_textbox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_textbox.Location = new System.Drawing.Point(230, 237);
            this.Email_textbox.Multiline = true;
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(319, 33);
            this.Email_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(104, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(649, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(50, 39);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_reglink
            // 
            this.label_reglink.AutoSize = true;
            this.label_reglink.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reglink.ForeColor = System.Drawing.Color.Red;
            this.label_reglink.Location = new System.Drawing.Point(385, 469);
            this.label_reglink.Name = "label_reglink";
            this.label_reglink.Size = new System.Drawing.Size(124, 24);
            this.label_reglink.TabIndex = 12;
            this.label_reglink.Text = "Register now";
            this.label_reglink.Click += new System.EventHandler(this.labelreglink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Don\'t have an account ?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 659);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_reglink);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Email_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_reglink;
        private System.Windows.Forms.Label label3;
    }
}