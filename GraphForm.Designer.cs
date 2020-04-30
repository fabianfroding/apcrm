namespace APCRM
{
    partial class GraphForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RadarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Histogram
            // 
            this.Histogram.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Histogram.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.Histogram.ChartAreas.Add(chartArea1);
            this.Histogram.Cursor = System.Windows.Forms.Cursors.AppStarting;
            legend1.Name = "Legend1";
            this.Histogram.Legends.Add(legend1);
            this.Histogram.Location = new System.Drawing.Point(12, 12);
            this.Histogram.Name = "Histogram";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BackSecondaryColor = System.Drawing.Color.PaleTurquoise;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Histogram.Series.Add(series1);
            this.Histogram.Size = new System.Drawing.Size(544, 633);
            this.Histogram.TabIndex = 0;
            this.Histogram.Text = "chart1";
            // 
            // RadarChart
            // 
            this.RadarChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.RadarChart.BackSecondaryColor = System.Drawing.Color.Gray;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea2.BackSecondaryColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.RadarChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RadarChart.Legends.Add(legend2);
            this.RadarChart.Location = new System.Drawing.Point(646, 12);
            this.RadarChart.Name = "RadarChart";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.Color.Coral;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series2.Color = System.Drawing.Color.SandyBrown;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.RadarChart.Series.Add(series2);
            this.RadarChart.Size = new System.Drawing.Size(507, 489);
            this.RadarChart.TabIndex = 1;
            this.RadarChart.Text = "chart2";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 701);
            this.Controls.Add(this.RadarChart);
            this.Controls.Add(this.Histogram);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadarChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart RadarChart;
    }
}