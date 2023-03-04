namespace SwapLetters
{
    partial class MyMessageBox
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
            this.smthTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smthTXT
            // 
            this.smthTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smthTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smthTXT.Location = new System.Drawing.Point(0, 0);
            this.smthTXT.Name = "smthTXT";
            this.smthTXT.Size = new System.Drawing.Size(482, 203);
            this.smthTXT.TabIndex = 0;
            this.smthTXT.Text = "smthTXT";
            this.smthTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.smthTXT);
            this.Name = "MyMessageBox";
            this.Text = "MyMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label smthTXT;
    }
}