namespace _9_Multi_window_Applicatoin
{
    partial class MessageMoment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageMoment));
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.MiniOrMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 32;
            this.lbHistory.Location = new System.Drawing.Point(15, 15);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(6);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(500, 740);
            this.lbHistory.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(524, 15);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(300, 50);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear history!";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MiniOrMax
            // 
            this.MiniOrMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MiniOrMax.BackgroundImage")));
            this.MiniOrMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MiniOrMax.Location = new System.Drawing.Point(1447, 9);
            this.MiniOrMax.Name = "MiniOrMax";
            this.MiniOrMax.Size = new System.Drawing.Size(75, 50);
            this.MiniOrMax.TabIndex = 3;
            this.MiniOrMax.UseVisualStyleBackColor = true;
            this.MiniOrMax.Click += new System.EventHandler(this.MiniOrMax_Click);
            // 
            // MessageMoment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.MiniOrMax);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.lbHistory);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MessageMoment";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button MiniOrMax;
    }
}