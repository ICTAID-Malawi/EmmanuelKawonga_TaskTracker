namespace WindowsFormsApp1
{
    partial class LandingPage
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
            this.Side_panel = new System.Windows.Forms.Panel();
            this.to_home_button = new System.Windows.Forms.Button();
            this.to_tasks_button = new System.Windows.Forms.Button();
            this.to_activites_button = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Side_panel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Side_panel
            // 
            this.Side_panel.BackColor = System.Drawing.Color.LimeGreen;
            this.Side_panel.Controls.Add(this.to_activites_button);
            this.Side_panel.Controls.Add(this.to_tasks_button);
            this.Side_panel.Controls.Add(this.to_home_button);
            this.Side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_panel.ForeColor = System.Drawing.Color.White;
            this.Side_panel.Location = new System.Drawing.Point(0, 0);
            this.Side_panel.Name = "Side_panel";
            this.Side_panel.Size = new System.Drawing.Size(146, 612);
            this.Side_panel.TabIndex = 0;
            // 
            // to_home_button
            // 
            this.to_home_button.BackColor = System.Drawing.Color.Transparent;
            this.to_home_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.to_home_button.FlatAppearance.BorderSize = 0;
            this.to_home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.to_home_button.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_home_button.ForeColor = System.Drawing.Color.White;
            this.to_home_button.Location = new System.Drawing.Point(12, 145);
            this.to_home_button.Name = "to_home_button";
            this.to_home_button.Size = new System.Drawing.Size(123, 40);
            this.to_home_button.TabIndex = 1;
            this.to_home_button.Text = "Home";
            this.to_home_button.UseVisualStyleBackColor = false;
            this.to_home_button.Click += new System.EventHandler(this.to_home_button_Click);
            // 
            // to_tasks_button
            // 
            this.to_tasks_button.BackColor = System.Drawing.Color.Transparent;
            this.to_tasks_button.FlatAppearance.BorderSize = 0;
            this.to_tasks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.to_tasks_button.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_tasks_button.ForeColor = System.Drawing.Color.White;
            this.to_tasks_button.Location = new System.Drawing.Point(12, 236);
            this.to_tasks_button.Name = "to_tasks_button";
            this.to_tasks_button.Size = new System.Drawing.Size(123, 40);
            this.to_tasks_button.TabIndex = 2;
            this.to_tasks_button.Text = "Tasks";
            this.to_tasks_button.UseVisualStyleBackColor = false;
            this.to_tasks_button.Click += new System.EventHandler(this.to_tasks_button_Click);
            // 
            // to_activites_button
            // 
            this.to_activites_button.BackColor = System.Drawing.Color.Transparent;
            this.to_activites_button.FlatAppearance.BorderSize = 0;
            this.to_activites_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.to_activites_button.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_activites_button.ForeColor = System.Drawing.Color.White;
            this.to_activites_button.Location = new System.Drawing.Point(12, 334);
            this.to_activites_button.Name = "to_activites_button";
            this.to_activites_button.Size = new System.Drawing.Size(123, 40);
            this.to_activites_button.TabIndex = 3;
            this.to_activites_button.Text = "Activities ";
            this.to_activites_button.UseVisualStyleBackColor = false;
            this.to_activites_button.Click += new System.EventHandler(this.to_activites_button_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.label8);
            this.mainpanel.Controls.Add(this.label7);
            this.mainpanel.Controls.Add(this.comboBox1);
            this.mainpanel.Controls.Add(this.progressBar1);
            this.mainpanel.Controls.Add(this.label9);
            this.mainpanel.Controls.Add(this.label6);
            this.mainpanel.Controls.Add(this.label5);
            this.mainpanel.Controls.Add(this.label4);
            this.mainpanel.Controls.Add(this.label3);
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Location = new System.Drawing.Point(146, 64);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1127, 548);
            this.mainpanel.TabIndex = 1;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_date.Location = new System.Drawing.Point(915, 20);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(146, 27);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Month,Date";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 64);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(873, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 27);
            this.label8.TabIndex = 44;
            this.label8.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "00";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Task 1 ",
            "Task 2 ",
            "Task 3"});
            this.comboBox1.Location = new System.Drawing.Point(136, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 29);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.Text = "Select Task";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(299, 368);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(698, 23);
            this.progressBar1.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Task Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 27);
            this.label6.TabIndex = 39;
            this.label6.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(130, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 34);
            this.label5.TabIndex = 38;
            this.label5.Text = "Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(840, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(486, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Complete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(132, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "In Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(138, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tasks";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.Side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            this.Side_panel.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_panel;
        private System.Windows.Forms.Button to_activites_button;
        private System.Windows.Forms.Button to_tasks_button;
        private System.Windows.Forms.Button to_home_button;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}