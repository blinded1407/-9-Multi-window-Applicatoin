namespace MadeGraph
{
    partial class SecondError
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
            this.lbError.Location = new System.Drawing.Point(12, 106);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(550, 38);
            this.lbError.TabIndex = 0;
            this.lbError.Text = "Xmin must to be less than Xmax!!!";
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.Black;
            this.Closer.ForeColor = System.Drawing.Color.Red;
            this.Closer.Location = new System.Drawing.Point(545, 13);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(50, 50);
            this.Closer.TabIndex = 1;
            this.Closer.Text = "X";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // SecondError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 153);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.lbError);
            this.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SecondError";
            this.Text = "Error!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button Closer;
    }
}