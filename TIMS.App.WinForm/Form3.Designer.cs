namespace TIMS.App.WinForm
{
    partial class Form3
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
            this.Page3Text = new System.Windows.Forms.Label();
            this.Page3Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Page3Text
            // 
            this.Page3Text.AutoSize = true;
            this.Page3Text.Location = new System.Drawing.Point(285, 167);
            this.Page3Text.Name = "Page3Text";
            this.Page3Text.Size = new System.Drawing.Size(35, 13);
            this.Page3Text.TabIndex = 5;
            this.Page3Text.Text = "label1";
            // 
            // Page3Next
            // 
            this.Page3Next.Location = new System.Drawing.Point(12, 183);
            this.Page3Next.Name = "Page3Next";
            this.Page3Next.Size = new System.Drawing.Size(776, 49);
            this.Page3Next.TabIndex = 3;
            this.Page3Next.Text = "button1";
            this.Page3Next.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Page3Text);
            this.Controls.Add(this.Page3Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Page3Text;
        private System.Windows.Forms.Button Page3Next;
    }
}