namespace Lab3.Task2
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
            this.userCustomControl21 = new Lab3.Task2.UserCustomControl2();
            this.SuspendLayout();
            // 
            // userCustomControl21
            // 
            this.userCustomControl21.Location = new System.Drawing.Point(12, 12);
            this.userCustomControl21.Name = "userCustomControl21";
            this.userCustomControl21.Size = new System.Drawing.Size(78, 22);
            this.userCustomControl21.TabIndex = 0;
            this.userCustomControl21.Text = "userCustomControl21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 295);
            this.Controls.Add(this.userCustomControl21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserCustomControl2 userCustomControl21;
    }
}

