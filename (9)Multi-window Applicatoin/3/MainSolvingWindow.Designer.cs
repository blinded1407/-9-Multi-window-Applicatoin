namespace SolvingHardMath
{
    partial class MainSolvingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSolvingWindow));
            this.TroubleNeedToBeSolved = new System.Windows.Forms.PictureBox();
            this.y = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.WriteY = new System.Windows.Forms.TextBox();
            this.WriteZ = new System.Windows.Forms.TextBox();
            this.sh = new System.Windows.Forms.RadioButton();
            this.x2 = new System.Windows.Forms.RadioButton();
            this.ex = new System.Windows.Forms.RadioButton();
            this.Result = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Label();
            this.WriteX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TroubleNeedToBeSolved)).BeginInit();
            this.SuspendLayout();
            // 
            // TroubleNeedToBeSolved
            // 
            //this.TroubleNeedToBeSolved.Image = ((System.Drawing.Image)(resources.GetObject("TroubleNeedToBeSolved.Image")));
            this.TroubleNeedToBeSolved.Location = new System.Drawing.Point(443, 12);
            this.TroubleNeedToBeSolved.Name = "TroubleNeedToBeSolved";
            this.TroubleNeedToBeSolved.Size = new System.Drawing.Size(498, 117);
            this.TroubleNeedToBeSolved.TabIndex = 0;
            this.TroubleNeedToBeSolved.TabStop = false;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y.Location = new System.Drawing.Point(595, 145);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(86, 49);
            this.y.TabIndex = 1;
            this.y.Text = "Y =";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z.Location = new System.Drawing.Point(777, 145);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(85, 49);
            this.z.TabIndex = 2;
            this.z.Text = "Z =";
            // 
            // WriteY
            // 
            this.WriteY.Location = new System.Drawing.Point(672, 156);
            this.WriteY.Name = "WriteY";
            this.WriteY.Size = new System.Drawing.Size(100, 22);
            this.WriteY.TabIndex = 3;
            // 
            // WriteZ
            // 
            this.WriteZ.Location = new System.Drawing.Point(858, 156);
            this.WriteZ.Name = "WriteZ";
            this.WriteZ.Size = new System.Drawing.Size(100, 22);
            this.WriteZ.TabIndex = 4;
            // 
            // sh
            // 
            this.sh.AutoSize = true;
            this.sh.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sh.Location = new System.Drawing.Point(493, 215);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(96, 34);
            this.sh.TabIndex = 5;
            this.sh.TabStop = true;
            this.sh.Text = "sh(X)";
            this.sh.UseVisualStyleBackColor = true;
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2.Location = new System.Drawing.Point(649, 215);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(77, 34);
            this.x2.TabIndex = 6;
            this.x2.TabStop = true;
            this.x2.Text = "x^2";
            this.x2.UseVisualStyleBackColor = true;
            // 
            // ex
            // 
            this.ex.AutoSize = true;
            this.ex.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ex.Location = new System.Drawing.Point(792, 215);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(77, 34);
            this.ex.TabIndex = 7;
            this.ex.TabStop = true;
            this.ex.Text = "e^x";
            this.ex.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(493, 255);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(376, 177);
            this.Result.TabIndex = 8;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(493, 457);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(173, 60);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(696, 457);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(173, 60);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(412, 145);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(87, 49);
            this.x.TabIndex = 11;
            this.x.Text = "X =";
            // 
            // WriteX
            // 
            this.WriteX.Location = new System.Drawing.Point(494, 156);
            this.WriteX.Name = "WriteX";
            this.WriteX.Size = new System.Drawing.Size(100, 22);
            this.WriteX.TabIndex = 12;
            // 
            // MainSolvingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.WriteX);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.sh);
            this.Controls.Add(this.WriteZ);
            this.Controls.Add(this.WriteY);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.TroubleNeedToBeSolved);
            this.Name = "MainSolvingWindow";
            this.Text = "MainSolvingWindow";
            ((System.ComponentModel.ISupportInitialize)(this.TroubleNeedToBeSolved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TroubleNeedToBeSolved;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.TextBox WriteY;
        private System.Windows.Forms.TextBox WriteZ;
        private System.Windows.Forms.RadioButton sh;
        private System.Windows.Forms.RadioButton x2;
        private System.Windows.Forms.RadioButton ex;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox WriteX;
    }
}

