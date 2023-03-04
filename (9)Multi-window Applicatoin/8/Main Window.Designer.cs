namespace MadeGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Creater = new System.Windows.Forms.Button();
            this.lbXmin = new System.Windows.Forms.Label();
            this.lbXmax = new System.Windows.Forms.Label();
            this.lbStep = new System.Windows.Forms.Label();
            this.tbXmin = new System.Windows.Forms.TextBox();
            this.tbXmax = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.picOfGraphExpression = new System.Windows.Forms.PictureBox();
            this.PS = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOfGraphExpression)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.Location = new System.Drawing.Point(460, 91);
            this.MainChart.Name = "MainChart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Yellow;
            series1.Name = "Series1";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(1000, 500);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "Main Chart";
            title1.Font = new System.Drawing.Font("Arial", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "titleGraph";
            title1.Text = "Graph";
            this.MainChart.Titles.Add(title1);
            // 
            // Creater
            // 
            this.Creater.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Creater.Location = new System.Drawing.Point(780, 731);
            this.Creater.Name = "Creater";
            this.Creater.Size = new System.Drawing.Size(360, 100);
            this.Creater.TabIndex = 1;
            this.Creater.Text = "Made Graph!";
            this.Creater.UseVisualStyleBackColor = true;
            this.Creater.Click += new System.EventHandler(this.Creater_Click);
            // 
            // lbXmin
            // 
            this.lbXmin.AutoSize = true;
            this.lbXmin.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbXmin.Location = new System.Drawing.Point(453, 616);
            this.lbXmin.Name = "lbXmin";
            this.lbXmin.Size = new System.Drawing.Size(134, 38);
            this.lbXmin.TabIndex = 2;
            this.lbXmin.Text = "Xmin = ";
            // 
            // lbXmax
            // 
            this.lbXmax.AutoSize = true;
            this.lbXmax.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbXmax.Location = new System.Drawing.Point(836, 616);
            this.lbXmax.Name = "lbXmax";
            this.lbXmax.Size = new System.Drawing.Size(141, 38);
            this.lbXmax.TabIndex = 3;
            this.lbXmax.Text = "Xmax = ";
            // 
            // lbStep
            // 
            this.lbStep.AutoSize = true;
            this.lbStep.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStep.Location = new System.Drawing.Point(1225, 616);
            this.lbStep.Name = "lbStep";
            this.lbStep.Size = new System.Drawing.Size(125, 38);
            this.lbStep.TabIndex = 4;
            this.lbStep.Text = "Step = ";
            // 
            // tbXmin
            // 
            this.tbXmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbXmin.Location = new System.Drawing.Point(597, 616);
            this.tbXmin.Multiline = true;
            this.tbXmin.Name = "tbXmin";
            this.tbXmin.Size = new System.Drawing.Size(150, 40);
            this.tbXmin.TabIndex = 5;
            // 
            // tbXmax
            // 
            this.tbXmax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbXmax.Location = new System.Drawing.Point(989, 616);
            this.tbXmax.Multiline = true;
            this.tbXmax.Name = "tbXmax";
            this.tbXmax.Size = new System.Drawing.Size(150, 40);
            this.tbXmax.TabIndex = 6;
            // 
            // tbStep
            // 
            this.tbStep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStep.Location = new System.Drawing.Point(1360, 616);
            this.tbStep.Multiline = true;
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(150, 40);
            this.tbStep.TabIndex = 7;
            // 
            // picOfGraphExpression
            // 
            //this.picOfGraphExpression.Image = ((System.Drawing.Image)(resources.GetObject("picOfGraphExpression.Image")));
            this.picOfGraphExpression.Location = new System.Drawing.Point(460, 12);
            this.picOfGraphExpression.Name = "picOfGraphExpression";
            this.picOfGraphExpression.Size = new System.Drawing.Size(360, 73);
            this.picOfGraphExpression.TabIndex = 8;
            this.picOfGraphExpression.TabStop = false;
            // 
            // PS
            // 
            this.PS.AutoSize = true;
            this.PS.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS.Location = new System.Drawing.Point(827, 13);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(215, 38);
            this.PS.TabIndex = 9;
            this.PS.Text = "b const = 3,2";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(779, 837);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(360, 100);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear!";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.picOfGraphExpression);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.tbXmax);
            this.Controls.Add(this.tbXmin);
            this.Controls.Add(this.lbStep);
            this.Controls.Add(this.lbXmax);
            this.Controls.Add(this.lbXmin);
            this.Controls.Add(this.Creater);
            this.Controls.Add(this.MainChart);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOfGraphExpression)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button Creater;
        private System.Windows.Forms.Label lbXmin;
        private System.Windows.Forms.Label lbXmax;
        private System.Windows.Forms.Label lbStep;
        private System.Windows.Forms.TextBox tbXmin;
        private System.Windows.Forms.TextBox tbXmax;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.PictureBox picOfGraphExpression;
        private System.Windows.Forms.Label PS;
        private System.Windows.Forms.Button Clear;
    }
}

