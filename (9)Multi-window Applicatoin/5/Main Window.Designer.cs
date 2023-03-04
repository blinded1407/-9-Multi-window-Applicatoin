namespace SwapLetters
{
    partial class Form1
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
            this.i = new System.Windows.Forms.Label();
            this.j = new System.Windows.Forms.Label();
            this.engText = new System.Windows.Forms.TextBox();
            this.WriteJ = new System.Windows.Forms.TextBox();
            this.WriteI = new System.Windows.Forms.TextBox();
            this.SwapLetters = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i.Location = new System.Drawing.Point(50, 202);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(35, 29);
            this.i.TabIndex = 0;
            this.i.Text = "i=";
            // 
            // j
            // 
            this.j.AutoSize = true;
            this.j.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.j.Location = new System.Drawing.Point(50, 262);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(35, 29);
            this.j.TabIndex = 1;
            this.j.Text = "j=";
            // 
            // engText
            // 
            this.engText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engText.Location = new System.Drawing.Point(12, 77);
            this.engText.Multiline = true;
            this.engText.Name = "engText";
            this.engText.Size = new System.Drawing.Size(1065, 95);
            this.engText.TabIndex = 2;
            this.engText.Text = "I gonna take my horse to the old town road im gonna ride till i cant no more";
            // 
            // WriteJ
            // 
            this.WriteJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteJ.Location = new System.Drawing.Point(91, 262);
            this.WriteJ.Multiline = true;
            this.WriteJ.Name = "WriteJ";
            this.WriteJ.Size = new System.Drawing.Size(100, 29);
            this.WriteJ.TabIndex = 3;
            // 
            // WriteI
            // 
            this.WriteI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteI.Location = new System.Drawing.Point(91, 202);
            this.WriteI.Multiline = true;
            this.WriteI.Name = "WriteI";
            this.WriteI.Size = new System.Drawing.Size(100, 29);
            this.WriteI.TabIndex = 4;
            // 
            // SwapLetters
            // 
            this.SwapLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SwapLetters.Location = new System.Drawing.Point(243, 202);
            this.SwapLetters.Name = "SwapLetters";
            this.SwapLetters.Size = new System.Drawing.Size(136, 89);
            this.SwapLetters.TabIndex = 5;
            this.SwapLetters.Text = "Swap Letters!";
            this.SwapLetters.UseVisualStyleBackColor = true;
            this.SwapLetters.Click += new System.EventHandler(this.SwapLetters_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(432, 202);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(136, 89);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear!";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "0123456789";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Format of letters write(with the spaces):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SwapLetters);
            this.Controls.Add(this.WriteI);
            this.Controls.Add(this.WriteJ);
            this.Controls.Add(this.engText);
            this.Controls.Add(this.j);
            this.Controls.Add(this.i);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label j;
        private System.Windows.Forms.TextBox engText;
        private System.Windows.Forms.TextBox WriteJ;
        private System.Windows.Forms.TextBox WriteI;
        private System.Windows.Forms.Button SwapLetters;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

