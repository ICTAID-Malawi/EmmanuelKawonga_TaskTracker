namespace TaskTrackerApp
{
    partial class TaskPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_id = new System.Windows.Forms.Label();
            this.button_committ = new System.Windows.Forms.Button();
            this.CompletionDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.Status_comboBox = new System.Windows.Forms.ComboBox();
            this.StartDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.Desc_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Taskname_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(497, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tasks";
            // 
            // button_add
            // 
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(484, 399);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 39);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(961, 399);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(123, 39);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(358, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 301);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(12, 22);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(55, 16);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "label_id";
            this.label_id.Click += new System.EventHandler(this.alabel_id_Click);
            // 
            // button_committ
            // 
            this.button_committ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_committ.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_committ.Location = new System.Drawing.Point(101, 399);
            this.button_committ.Name = "button_committ";
            this.button_committ.Size = new System.Drawing.Size(123, 39);
            this.button_committ.TabIndex = 29;
            this.button_committ.Text = "Commit";
            this.button_committ.UseVisualStyleBackColor = true;
            this.button_committ.Click += new System.EventHandler(this.Button_committ_Click);
            // 
            // CompletionDate_Picker
            // 
            this.CompletionDate_Picker.CalendarFont = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletionDate_Picker.Location = new System.Drawing.Point(12, 344);
            this.CompletionDate_Picker.Name = "CompletionDate_Picker";
            this.CompletionDate_Picker.Size = new System.Drawing.Size(319, 22);
            this.CompletionDate_Picker.TabIndex = 28;
            this.CompletionDate_Picker.ValueChanged += new System.EventHandler(this.CompletionDate_Picker_ValueChanged);
            // 
            // Status_comboBox
            // 
            this.Status_comboBox.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_comboBox.FormattingEnabled = true;
            this.Status_comboBox.Items.AddRange(new object[] {
            "Pending ",
            "Complete"});
            this.Status_comboBox.Location = new System.Drawing.Point(12, 241);
            this.Status_comboBox.Name = "Status_comboBox";
            this.Status_comboBox.Size = new System.Drawing.Size(319, 29);
            this.Status_comboBox.TabIndex = 27;
            this.Status_comboBox.Text = "Status";
            // 
            // StartDate_Picker
            // 
            this.StartDate_Picker.CalendarFont = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_Picker.Location = new System.Drawing.Point(12, 300);
            this.StartDate_Picker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.StartDate_Picker.MinDate = new System.DateTime(2024, 2, 29, 0, 0, 0, 0);
            this.StartDate_Picker.Name = "StartDate_Picker";
            this.StartDate_Picker.Size = new System.Drawing.Size(319, 22);
            this.StartDate_Picker.TabIndex = 26;
            // 
            // Desc_richTextBox
            // 
            this.Desc_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Desc_richTextBox.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_richTextBox.Location = new System.Drawing.Point(12, 121);
            this.Desc_richTextBox.Name = "Desc_richTextBox";
            this.Desc_richTextBox.Size = new System.Drawing.Size(319, 96);
            this.Desc_richTextBox.TabIndex = 25;
            this.Desc_richTextBox.Text = "";
            // 
            // Taskname_textbox
            // 
            this.Taskname_textbox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskname_textbox.Location = new System.Drawing.Point(12, 65);
            this.Taskname_textbox.Multiline = true;
            this.Taskname_textbox.Name = "Taskname_textbox";
            this.Taskname_textbox.Size = new System.Drawing.Size(319, 33);
            this.Taskname_textbox.TabIndex = 24;
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 548);
            this.Controls.Add(this.button_committ);
            this.Controls.Add(this.CompletionDate_Picker);
            this.Controls.Add(this.Status_comboBox);
            this.Controls.Add(this.StartDate_Picker);
            this.Controls.Add(this.Desc_richTextBox);
            this.Controls.Add(this.Taskname_textbox);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskPage";
            this.Text = "TaskPage";
            this.Load += new System.EventHandler(this.TaskPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_committ;
        private System.Windows.Forms.DateTimePicker CompletionDate_Picker;
        private System.Windows.Forms.ComboBox Status_comboBox;
        private System.Windows.Forms.DateTimePicker StartDate_Picker;
        private System.Windows.Forms.RichTextBox Desc_richTextBox;
        private System.Windows.Forms.TextBox Taskname_textbox;
    }
}