namespace ButtonsAndHadlers
{
    partial class MainWindowForUsers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnactiveButton = new System.Windows.Forms.Button();
            this.SecondBlocked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnactiveButton
            // 
            this.UnactiveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UnactiveButton.Font = new System.Drawing.Font("GOST type B", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnactiveButton.Location = new System.Drawing.Point(90, 102);
            this.UnactiveButton.Name = "UnactiveButton";
            this.UnactiveButton.Size = new System.Drawing.Size(281, 164);
            this.UnactiveButton.TabIndex = 0;
            this.UnactiveButton.Text = "Unactive button";
            this.UnactiveButton.UseVisualStyleBackColor = false;
            this.UnactiveButton.Click += new System.EventHandler(this.UnactiveButton_Click);
            // 
            // SecondBlocked
            // 
            this.SecondBlocked.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SecondBlocked.Font = new System.Drawing.Font("GOST type B", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondBlocked.Location = new System.Drawing.Point(525, 102);
            this.SecondBlocked.Name = "SecondBlocked";
            this.SecondBlocked.Size = new System.Drawing.Size(281, 164);
            this.SecondBlocked.TabIndex = 1;
            this.SecondBlocked.Text = "Second blocked";
            this.SecondBlocked.UseVisualStyleBackColor = false;
            this.SecondBlocked.Click += new System.EventHandler(this.SecondBlocked_Click);
            // 
            // MainWindowForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 393);
            this.Controls.Add(this.SecondBlocked);
            this.Controls.Add(this.UnactiveButton);
            this.Name = "MainWindowForUsers";
            this.Text = "Main Window For Users";
            this.Resize += new System.EventHandler(this.EnablerResizer);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnactiveButton;
        private System.Windows.Forms.Button SecondBlocked;
    }
}

