namespace MassivAndResult
{
    partial class MainWindow
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
            this.FirstTitle = new System.Windows.Forms.Label();
            this.ChangedMassive = new System.Windows.Forms.Label();
            this.MassiveBox = new System.Windows.Forms.TextBox();
            this.ChangedMassiveBox = new System.Windows.Forms.TextBox();
            this.Fill = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstTitle
            // 
            this.FirstTitle.AutoSize = true;
            this.FirstTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTitle.Location = new System.Drawing.Point(267, 60);
            this.FirstTitle.Name = "FirstTitle";
            this.FirstTitle.Size = new System.Drawing.Size(197, 32);
            this.FirstTitle.TabIndex = 0;
            this.FirstTitle.Text = "Your Massive";
            // 
            // ChangedMassive
            // 
            this.ChangedMassive.AutoSize = true;
            this.ChangedMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangedMassive.Location = new System.Drawing.Point(807, 60);
            this.ChangedMassive.Name = "ChangedMassive";
            this.ChangedMassive.Size = new System.Drawing.Size(283, 32);
            this.ChangedMassive.TabIndex = 1;
            this.ChangedMassive.Text = "Only Even Numbers";
            // 
            // MassiveBox
            // 
            this.MassiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MassiveBox.Location = new System.Drawing.Point(253, 95);
            this.MassiveBox.Multiline = true;
            this.MassiveBox.Name = "MassiveBox";
            this.MassiveBox.Size = new System.Drawing.Size(223, 362);
            this.MassiveBox.TabIndex = 2;
            // 
            // ChangedMassiveBox
            // 
            this.ChangedMassiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangedMassiveBox.Location = new System.Drawing.Point(839, 95);
            this.ChangedMassiveBox.Multiline = true;
            this.ChangedMassiveBox.Name = "ChangedMassiveBox";
            this.ChangedMassiveBox.Size = new System.Drawing.Size(223, 362);
            this.ChangedMassiveBox.TabIndex = 3;
            // 
            // Fill
            // 
            this.Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fill.Location = new System.Drawing.Point(253, 479);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(223, 104);
            this.Fill.TabIndex = 4;
            this.Fill.Text = "Fill in an array!";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(839, 479);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(223, 104);
            this.Change.TabIndex = 5;
            this.Change.Text = "Make Changes!";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(552, 446);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(223, 54);
            this.Result.TabIndex = 6;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(552, 529);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(223, 54);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(552, 362);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(223, 54);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Calculate!";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.ChangedMassiveBox);
            this.Controls.Add(this.MassiveBox);
            this.Controls.Add(this.ChangedMassive);
            this.Controls.Add(this.FirstTitle);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstTitle;
        private System.Windows.Forms.Label ChangedMassive;
        private System.Windows.Forms.TextBox MassiveBox;
        private System.Windows.Forms.TextBox ChangedMassiveBox;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Calculate;
    }
}

