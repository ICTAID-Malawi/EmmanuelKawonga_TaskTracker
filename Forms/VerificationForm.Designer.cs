namespace WindowsFormsApp1.Forms
{
    partial class VerificationForm
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
            this.textBox_verify = new System.Windows.Forms.TextBox();
            this.button_verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_verify
            // 
            this.textBox_verify.Location = new System.Drawing.Point(240, 149);
            this.textBox_verify.Name = "textBox_verify";
            this.textBox_verify.Size = new System.Drawing.Size(421, 22);
            this.textBox_verify.TabIndex = 0;
            this.textBox_verify.TextChanged += new System.EventHandler(this.textBox_verify_TextChanged);
            // 
            // button_verify
            // 
            this.button_verify.Location = new System.Drawing.Point(414, 233);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(75, 23);
            this.button_verify.TabIndex = 1;
            this.button_verify.Text = "button1";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // VerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_verify);
            this.Controls.Add(this.textBox_verify);
            this.Name = "VerificationForm";
            this.Text = "VerificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_verify;
        private System.Windows.Forms.Button button_verify;
    }
}