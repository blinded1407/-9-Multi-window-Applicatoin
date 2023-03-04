namespace _9_Multi_window_Applicatoin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.First = new System.Windows.Forms.ToolStripMenuItem();
            this.Second = new System.Windows.Forms.ToolStripMenuItem();
            this.Third = new System.Windows.Forms.ToolStripMenuItem();
            this.Forth = new System.Windows.Forms.ToolStripMenuItem();
            this.Fifth = new System.Windows.Forms.ToolStripMenuItem();
            this.Sixth = new System.Windows.Forms.ToolStripMenuItem();
            this.Seventh = new System.Windows.Forms.ToolStripMenuItem();
            this.Eighth = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAnyFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageMomentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.First,
            this.Second,
            this.Third,
            this.Forth,
            this.Fifth,
            this.Sixth,
            this.Seventh,
            this.Eighth,
            this.closeAnyFormsToolStripMenuItem,
            this.messageMomentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // First
            // 
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(31, 24);
            this.First.Text = "1";
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // Second
            // 
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(31, 24);
            this.Second.Text = "2";
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // Third
            // 
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(31, 24);
            this.Third.Text = "3";
            this.Third.Click += new System.EventHandler(this.Third_Click);
            // 
            // Forth
            // 
            this.Forth.Name = "Forth";
            this.Forth.Size = new System.Drawing.Size(31, 24);
            this.Forth.Text = "4";
            this.Forth.Click += new System.EventHandler(this.Forth_Click);
            // 
            // Fifth
            // 
            this.Fifth.Name = "Fifth";
            this.Fifth.Size = new System.Drawing.Size(31, 24);
            this.Fifth.Text = "5";
            this.Fifth.Click += new System.EventHandler(this.Fifth_Click);
            // 
            // Sixth
            // 
            this.Sixth.Name = "Sixth";
            this.Sixth.Size = new System.Drawing.Size(31, 24);
            this.Sixth.Text = "6";
            this.Sixth.Click += new System.EventHandler(this.Sixth_Click);
            // 
            // Seventh
            // 
            this.Seventh.Name = "Seventh";
            this.Seventh.Size = new System.Drawing.Size(31, 24);
            this.Seventh.Text = "7";
            this.Seventh.Click += new System.EventHandler(this.Seventh_Click);
            // 
            // Eighth
            // 
            this.Eighth.Name = "Eighth";
            this.Eighth.Size = new System.Drawing.Size(31, 24);
            this.Eighth.Text = "8";
            this.Eighth.Click += new System.EventHandler(this.Eighth_Click);
            // 
            // closeAnyFormsToolStripMenuItem
            // 
            this.closeAnyFormsToolStripMenuItem.Name = "closeAnyFormsToolStripMenuItem";
            this.closeAnyFormsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.closeAnyFormsToolStripMenuItem.Text = "Close Any Forms!";
            this.closeAnyFormsToolStripMenuItem.Click += new System.EventHandler(this.closeAnyFormsToolStripMenuItem_Click);
            // 
            // messageMomentToolStripMenuItem
            // 
            this.messageMomentToolStripMenuItem.Name = "messageMomentToolStripMenuItem";
            this.messageMomentToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.messageMomentToolStripMenuItem.Text = "MessageMoment";
            this.messageMomentToolStripMenuItem.Click += new System.EventHandler(this.messageMomentToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem First;
        private System.Windows.Forms.ToolStripMenuItem Second;
        private System.Windows.Forms.ToolStripMenuItem Third;
        private System.Windows.Forms.ToolStripMenuItem Forth;
        private System.Windows.Forms.ToolStripMenuItem Fifth;
        private System.Windows.Forms.ToolStripMenuItem Sixth;
        private System.Windows.Forms.ToolStripMenuItem Seventh;
        private System.Windows.Forms.ToolStripMenuItem Eighth;
        private System.Windows.Forms.ToolStripMenuItem closeAnyFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageMomentToolStripMenuItem;
    }
}

