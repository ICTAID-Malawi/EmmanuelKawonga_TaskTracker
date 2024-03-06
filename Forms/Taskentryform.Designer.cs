namespace WindowsFormsApp1.Forms
{
    partial class Taskentryform
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
            this.label_id = new System.Windows.Forms.Label();
            this.Taskname_textbox = new System.Windows.Forms.TextBox();
            this.Desc_richTextBox = new System.Windows.Forms.RichTextBox();
            this.StartDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.Status_comboBox = new System.Windows.Forms.ComboBox();
            this.CompletionDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.button_committ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(12, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(55, 16);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "label_id";
            this.label_id.Visible = false;
            // 
            // Taskname_textbox
            // 
            this.Taskname_textbox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskname_textbox.Location = new System.Drawing.Point(31, 65);
            this.Taskname_textbox.Multiline = true;
            this.Taskname_textbox.Name = "Taskname_textbox";
            this.Taskname_textbox.Size = new System.Drawing.Size(319, 33);
            this.Taskname_textbox.TabIndex = 16;
            // 
            // Desc_richTextBox
            // 
            this.Desc_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Desc_richTextBox.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_richTextBox.Location = new System.Drawing.Point(31, 121);
            this.Desc_richTextBox.Name = "Desc_richTextBox";
            this.Desc_richTextBox.Size = new System.Drawing.Size(319, 96);
            this.Desc_richTextBox.TabIndex = 19;
            this.Desc_richTextBox.Text = "";
            // 
            // StartDate_Picker
            // 
            this.StartDate_Picker.CalendarFont = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_Picker.Location = new System.Drawing.Point(31, 300);
            this.StartDate_Picker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.StartDate_Picker.MinDate = new System.DateTime(2024, 2, 29, 0, 0, 0, 0);
            this.StartDate_Picker.Name = "StartDate_Picker";
            this.StartDate_Picker.Size = new System.Drawing.Size(319, 22);
            this.StartDate_Picker.TabIndex = 20;
            // 
            // Status_comboBox
            // 
            this.Status_comboBox.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_comboBox.FormattingEnabled = true;
            this.Status_comboBox.Items.AddRange(new object[] {
            "Pending ",
            "Complete"});
            this.Status_comboBox.Location = new System.Drawing.Point(31, 241);
            this.Status_comboBox.Name = "Status_comboBox";
            this.Status_comboBox.Size = new System.Drawing.Size(319, 29);
            this.Status_comboBox.TabIndex = 21;
            this.Status_comboBox.Text = "Status";
            // 
            // CompletionDate_Picker
            // 
            this.CompletionDate_Picker.CalendarFont = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletionDate_Picker.Location = new System.Drawing.Point(31, 344);
            this.CompletionDate_Picker.Name = "CompletionDate_Picker";
            this.CompletionDate_Picker.Size = new System.Drawing.Size(319, 22);
            this.CompletionDate_Picker.TabIndex = 22;
            // 
            // button_committ
            // 
            this.button_committ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_committ.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_committ.Location = new System.Drawing.Point(120, 399);
            this.button_committ.Name = "button_committ";
            this.button_committ.Size = new System.Drawing.Size(123, 39);
            this.button_committ.TabIndex = 23;
            this.button_committ.Text = "Commit";
            this.button_committ.UseVisualStyleBackColor = true;
            this.button_committ.Click += new System.EventHandler(this.button_commit_Click);
            // 
            // Taskentryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 520);
            this.Controls.Add(this.button_committ);
            this.Controls.Add(this.CompletionDate_Picker);
            this.Controls.Add(this.Status_comboBox);
            this.Controls.Add(this.StartDate_Picker);
            this.Controls.Add(this.Desc_richTextBox);
            this.Controls.Add(this.Taskname_textbox);
            this.Controls.Add(this.label_id);
            this.Name = "Taskentryform";
            this.Text = "Taskentryform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox Taskname_textbox;
        private System.Windows.Forms.RichTextBox Desc_richTextBox;
        private System.Windows.Forms.DateTimePicker StartDate_Picker;
        private System.Windows.Forms.ComboBox Status_comboBox;
        private System.Windows.Forms.DateTimePicker CompletionDate_Picker;
        private System.Windows.Forms.Button button_committ;
    }
}