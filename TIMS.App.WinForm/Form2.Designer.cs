namespace TIMS.App.WinForm
{
    partial class Form2
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
            this.Page2Next = new System.Windows.Forms.Button();
            this.Page2Back = new System.Windows.Forms.Button();
            this.Page2Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Page2Next
            // 
            this.Page2Next.Location = new System.Drawing.Point(12, 186);
            this.Page2Next.Name = "Page2Next";
            this.Page2Next.Size = new System.Drawing.Size(776, 49);
            this.Page2Next.TabIndex = 0;
            this.Page2Next.Text = "button1";
            this.Page2Next.UseVisualStyleBackColor = true;
            // 
            // Page2Back
            // 
            this.Page2Back.Location = new System.Drawing.Point(12, 241);
            this.Page2Back.Name = "Page2Back";
            this.Page2Back.Size = new System.Drawing.Size(776, 45);
            this.Page2Back.TabIndex = 1;
            this.Page2Back.Text = "button2";
            this.Page2Back.UseVisualStyleBackColor = true;
            // 
            // Page2Text
            // 
            this.Page2Text.AutoSize = true;
            this.Page2Text.Location = new System.Drawing.Point(287, 170);
            this.Page2Text.Name = "Page2Text";
            this.Page2Text.Size = new System.Drawing.Size(35, 13);
            this.Page2Text.TabIndex = 2;
            this.Page2Text.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Page2Text);
            this.Controls.Add(this.Page2Back);
            this.Controls.Add(this.Page2Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Page2Next;
        private System.Windows.Forms.Button Page2Back;
        private System.Windows.Forms.Label Page2Text;
    }
}