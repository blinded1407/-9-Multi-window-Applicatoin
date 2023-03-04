namespace _1
{
    partial class Error
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
            this.lbError = new System.Windows.Forms.Label();
            this.Closer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbError.Location = new System.Drawing.Point(12, 31);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(394, 33);
            this.lbError.TabIndex = 0;
            this.lbError.Text = "Write any meanings, please!";
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Closer.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closer.ForeColor = System.Drawing.Color.Red;
            this.Closer.Location = new System.Drawing.Point(416, 13);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(50, 40);
            this.Closer.TabIndex = 1;
            this.Closer.Text = "X";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 73);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.lbError);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button Closer;
    }
}