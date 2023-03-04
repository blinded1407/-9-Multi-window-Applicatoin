namespace SearcherOfLocalMax
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
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.Searcher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Location = new System.Drawing.Point(12, 12);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.RowHeadersWidth = 51;
            this.MainDataGrid.RowTemplate.Height = 24;
            this.MainDataGrid.Size = new System.Drawing.Size(1878, 618);
            this.MainDataGrid.TabIndex = 0;
            // 
            // Searcher
            // 
            this.Searcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searcher.Location = new System.Drawing.Point(12, 636);
            this.Searcher.Name = "Searcher";
            this.Searcher.Size = new System.Drawing.Size(200, 100);
            this.Searcher.TabIndex = 1;
            this.Searcher.Text = "Search!";
            this.Searcher.UseVisualStyleBackColor = true;
            this.Searcher.Click += new System.EventHandler(this.Searcher_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Searcher);
            this.Controls.Add(this.MainDataGrid);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.Button Searcher;
    }
}

