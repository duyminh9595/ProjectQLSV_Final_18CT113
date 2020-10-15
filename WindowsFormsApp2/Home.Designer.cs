namespace WindowsFormsApp2
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSLSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.chartSVTheoGioiTinh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.charSVTheoNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartSLSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTheoGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charSVTheoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSLSV
            // 
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.Name = "ChartArea1";
            this.chartSLSV.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSLSV.Legends.Add(legend4);
            this.chartSLSV.Location = new System.Drawing.Point(4, 43);
            this.chartSLSV.Name = "chartSLSV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            this.chartSLSV.Series.Add(series4);
            this.chartSLSV.Size = new System.Drawing.Size(280, 151);
            this.chartSLSV.TabIndex = 0;
            this.chartSLSV.Text = "chart1";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 25;
            this.gunaElipse1.TargetControl = this.chartSLSV;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(272, 29);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Sinh Vien Còn Học Theo Khoa";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(290, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(235, 29);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Sinh Vien Theo Giới Tính";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartSVTheoGioiTinh
            // 
            chartArea5.Name = "ChartArea1";
            this.chartSVTheoGioiTinh.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSVTheoGioiTinh.Legends.Add(legend5);
            this.chartSVTheoGioiTinh.Location = new System.Drawing.Point(290, 45);
            this.chartSVTheoGioiTinh.Name = "chartSVTheoGioiTinh";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 4;
            this.chartSVTheoGioiTinh.Series.Add(series5);
            this.chartSVTheoGioiTinh.Size = new System.Drawing.Size(235, 149);
            this.chartSVTheoGioiTinh.TabIndex = 2;
            this.chartSVTheoGioiTinh.Text = "chart1";
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 25;
            this.gunaElipse2.TargetControl = this.chartSVTheoGioiTinh;
            // 
            // charSVTheoNam
            // 
            chartArea6.Name = "ChartArea1";
            this.charSVTheoNam.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.charSVTheoNam.Legends.Add(legend6);
            this.charSVTheoNam.Location = new System.Drawing.Point(4, 229);
            this.charSVTheoNam.Name = "charSVTheoNam";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "SLSV";
            series6.XValueMember = "Năm";
            series6.YValueMembers = "Số Người";
            this.charSVTheoNam.Series.Add(series6);
            this.charSVTheoNam.Size = new System.Drawing.Size(521, 183);
            this.charSVTheoNam.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 197);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(513, 29);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Sinh Vien Học Theo Năm";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 25;
            this.gunaElipse3.TargetControl = this.chartSLSV;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 625);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.charSVTheoNam);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.chartSVTheoGioiTinh);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.chartSLSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSLSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTheoGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charSVTheoNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSLSV;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSVTheoGioiTinh;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.DataVisualization.Charting.Chart charSVTheoNam;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}