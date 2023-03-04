namespace Tabulation
{
    partial class Tabulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabulation));
            this.X0 = new System.Windows.Forms.Label();
            this.Xk = new System.Windows.Forms.Label();
            this.dX = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B = new System.Windows.Forms.Label();
            this.WriteX0 = new System.Windows.Forms.TextBox();
            this.WriteXk = new System.Windows.Forms.TextBox();
            this.WritedX = new System.Windows.Forms.TextBox();
            this.Writeb = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // X0
            // 
            this.X0.AutoSize = true;
            this.X0.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X0.Location = new System.Drawing.Point(382, 126);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(68, 33);
            this.X0.TabIndex = 1;
            this.X0.Text = "X₀ =";
            // 
            // Xk
            // 
            this.Xk.AutoSize = true;
            this.Xk.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xk.Location = new System.Drawing.Point(566, 126);
            this.Xk.Name = "Xk";
            this.Xk.Size = new System.Drawing.Size(74, 33);
            this.Xk.TabIndex = 2;
            this.Xk.Text = "Xk =";
            // 
            // dX
            // 
            this.dX.AutoSize = true;
            this.dX.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dX.Location = new System.Drawing.Point(758, 126);
            this.dX.Name = "dX";
            this.dX.Size = new System.Drawing.Size(75, 33);
            this.dX.TabIndex = 3;
            this.dX.Text = "dX =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(953, 126);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(56, 33);
            this.B.TabIndex = 6;
            this.B.Text = "b =";
            // 
            // WriteX0
            // 
            this.WriteX0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteX0.Location = new System.Drawing.Point(456, 126);
            this.WriteX0.Name = "WriteX0";
            this.WriteX0.Size = new System.Drawing.Size(92, 30);
            this.WriteX0.TabIndex = 7;
            // 
            // WriteXk
            // 
            this.WriteXk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteXk.Location = new System.Drawing.Point(646, 126);
            this.WriteXk.Multiline = true;
            this.WriteXk.Name = "WriteXk";
            this.WriteXk.Size = new System.Drawing.Size(92, 30);
            this.WriteXk.TabIndex = 8;
            // 
            // WritedX
            // 
            this.WritedX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WritedX.Location = new System.Drawing.Point(839, 126);
            this.WritedX.Multiline = true;
            this.WritedX.Name = "WritedX";
            this.WritedX.Size = new System.Drawing.Size(92, 30);
            this.WritedX.TabIndex = 9;
            // 
            // Writeb
            // 
            this.Writeb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Writeb.Location = new System.Drawing.Point(1015, 126);
            this.Writeb.Multiline = true;
            this.Writeb.Name = "Writeb";
            this.Writeb.Size = new System.Drawing.Size(92, 30);
            this.Writeb.TabIndex = 11;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(572, 287);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(359, 142);
            this.Result.TabIndex = 12;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(572, 206);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(159, 40);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(772, 206);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(159, 40);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Writeb);
            this.Controls.Add(this.WritedX);
            this.Controls.Add(this.WriteXk);
            this.Controls.Add(this.WriteX0);
            this.Controls.Add(this.B);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dX);
            this.Controls.Add(this.Xk);
            this.Controls.Add(this.X0);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label X0;
        private System.Windows.Forms.Label Xk;
        private System.Windows.Forms.Label dX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.TextBox WriteX0;
        private System.Windows.Forms.TextBox WriteXk;
        private System.Windows.Forms.TextBox WritedX;
        private System.Windows.Forms.TextBox Writeb;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
    }
}

