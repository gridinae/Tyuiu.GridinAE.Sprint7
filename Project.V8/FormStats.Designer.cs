namespace Project.V8
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabPageColor_GAE = new TabPage();
            chartColor_GAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageBrand_GAE = new TabPage();
            chartBrand_GAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageRegion_GAE = new TabPage();
            chartRegion_GAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControlStats_GAE = new TabControl();
            tabPageColor_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartColor_GAE).BeginInit();
            tabPageBrand_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBrand_GAE).BeginInit();
            tabPageRegion_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRegion_GAE).BeginInit();
            tabControlStats_GAE.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageColor_GAE
            // 
            tabPageColor_GAE.Controls.Add(chartColor_GAE);
            tabPageColor_GAE.Location = new Point(4, 29);
            tabPageColor_GAE.Name = "tabPageColor_GAE";
            tabPageColor_GAE.Padding = new Padding(3);
            tabPageColor_GAE.Size = new Size(674, 420);
            tabPageColor_GAE.TabIndex = 2;
            tabPageColor_GAE.Text = "Цвет";
            tabPageColor_GAE.UseVisualStyleBackColor = true;
            // 
            // chartColor_GAE
            // 
            chartArea1.Name = "ChartArea1";
            chartColor_GAE.ChartAreas.Add(chartArea1);
            chartColor_GAE.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartColor_GAE.Legends.Add(legend1);
            chartColor_GAE.Location = new Point(3, 3);
            chartColor_GAE.Name = "chartColor_GAE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieDrawingStyle=Concave, PieLabelStyle=Outside, PieLineColor=Black";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.Transparent;
            series1.Name = "Series1";
            series1.SmartLabelStyle.CalloutLineColor = Color.BlanchedAlmond;
            chartColor_GAE.Series.Add(series1);
            chartColor_GAE.Size = new Size(668, 414);
            chartColor_GAE.TabIndex = 2;
            // 
            // tabPageBrand_GAE
            // 
            tabPageBrand_GAE.Controls.Add(chartBrand_GAE);
            tabPageBrand_GAE.Location = new Point(4, 29);
            tabPageBrand_GAE.Name = "tabPageBrand_GAE";
            tabPageBrand_GAE.Padding = new Padding(3);
            tabPageBrand_GAE.Size = new Size(674, 420);
            tabPageBrand_GAE.TabIndex = 1;
            tabPageBrand_GAE.Text = "Марка";
            tabPageBrand_GAE.UseVisualStyleBackColor = true;
            // 
            // chartBrand_GAE
            // 
            chartArea2.Name = "ChartArea1";
            chartBrand_GAE.ChartAreas.Add(chartArea2);
            chartBrand_GAE.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartBrand_GAE.Legends.Add(legend2);
            chartBrand_GAE.Location = new Point(3, 3);
            chartBrand_GAE.Name = "chartBrand_GAE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieDrawingStyle=Concave, PieLineColor=White";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = Color.Transparent;
            series2.Name = "Series1";
            series2.SmartLabelStyle.CalloutLineColor = Color.BlanchedAlmond;
            chartBrand_GAE.Series.Add(series2);
            chartBrand_GAE.Size = new Size(668, 414);
            chartBrand_GAE.TabIndex = 1;
            // 
            // tabPageRegion_GAE
            // 
            tabPageRegion_GAE.Controls.Add(chartRegion_GAE);
            tabPageRegion_GAE.Location = new Point(4, 29);
            tabPageRegion_GAE.Name = "tabPageRegion_GAE";
            tabPageRegion_GAE.Padding = new Padding(3);
            tabPageRegion_GAE.Size = new Size(674, 420);
            tabPageRegion_GAE.TabIndex = 0;
            tabPageRegion_GAE.Text = "Регион";
            tabPageRegion_GAE.UseVisualStyleBackColor = true;
            // 
            // chartRegion_GAE
            // 
            chartArea3.Name = "ChartArea1";
            chartRegion_GAE.ChartAreas.Add(chartArea3);
            chartRegion_GAE.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartRegion_GAE.Legends.Add(legend3);
            chartRegion_GAE.Location = new Point(3, 3);
            chartRegion_GAE.Name = "chartRegion_GAE";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.CustomProperties = "PieDrawingStyle=Concave, PieLineColor=White";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = Color.Transparent;
            series3.Name = "Series1";
            series3.SmartLabelStyle.CalloutLineColor = Color.BlanchedAlmond;
            chartRegion_GAE.Series.Add(series3);
            chartRegion_GAE.Size = new Size(668, 414);
            chartRegion_GAE.TabIndex = 0;
            // 
            // tabControlStats_GAE
            // 
            tabControlStats_GAE.Controls.Add(tabPageRegion_GAE);
            tabControlStats_GAE.Controls.Add(tabPageBrand_GAE);
            tabControlStats_GAE.Controls.Add(tabPageColor_GAE);
            tabControlStats_GAE.Dock = DockStyle.Fill;
            tabControlStats_GAE.Location = new Point(0, 0);
            tabControlStats_GAE.Name = "tabControlStats_GAE";
            tabControlStats_GAE.SelectedIndex = 0;
            tabControlStats_GAE.Size = new Size(682, 453);
            tabControlStats_GAE.TabIndex = 0;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(tabControlStats_GAE);
            Name = "FormStats";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            tabPageColor_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartColor_GAE).EndInit();
            tabPageBrand_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartBrand_GAE).EndInit();
            tabPageRegion_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRegion_GAE).EndInit();
            tabControlStats_GAE.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageColor_GAE;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartColor_GAE;
        private TabPage tabPageBrand_GAE;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartBrand_GAE;
        private TabPage tabPageRegion_GAE;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRegion_GAE;
        private TabControl tabControlStats_GAE;
    }
}