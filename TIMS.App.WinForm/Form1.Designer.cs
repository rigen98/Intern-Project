namespace TIMS.App.WinForm
{
    partial class Form1
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
            this.Page1Text = new System.Windows.Forms.Label();
            this.Page1Button = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Page1Text
            // 
            this.Page1Text.AutoSize = true;
            this.Page1Text.Location = new System.Drawing.Point(347, 105);
            this.Page1Text.Name = "Page1Text";
            this.Page1Text.Size = new System.Drawing.Size(28, 13);
            this.Page1Text.TabIndex = 3;
            this.Page1Text.Text = "Text";
            // 
            // Page1Button
            // 
            this.Page1Button.Location = new System.Drawing.Point(494, 162);
            this.Page1Button.Name = "Page1Button";
            this.Page1Button.Size = new System.Drawing.Size(243, 43);
            this.Page1Button.TabIndex = 2;
            this.Page1Button.Text = "Button";
            this.Page1Button.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(134, 174);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(340, 174);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(46, 177);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(82, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height(in Meter)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(293, 177);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.Page1Text);
            this.Controls.Add(this.Page1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Page1Text;
        private System.Windows.Forms.Button Page1Button;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
    }
}