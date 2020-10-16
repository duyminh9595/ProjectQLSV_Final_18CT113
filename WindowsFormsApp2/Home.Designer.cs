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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSLSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.chartSVTheoGioiTinh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.charSVTheoNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.chartSVTinhThanh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblSVConHoc = new Guna.UI.WinForms.GunaLabel();
            this.lblChuaXepLop = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartSLSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTheoGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charSVTheoNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTinhThanh)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSLSV
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.chartSLSV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSLSV.Legends.Add(legend1);
            this.chartSLSV.Location = new System.Drawing.Point(4, 43);
            this.chartSLSV.Name = "chartSLSV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartSLSV.Series.Add(series1);
            this.chartSLSV.Size = new System.Drawing.Size(311, 124);
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
            this.gunaLabel1.Size = new System.Drawing.Size(303, 29);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Sinh Vien Còn Học Theo Khoa";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(321, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(266, 29);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Sinh Vien Theo Giới Tính";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartSVTheoGioiTinh
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSVTheoGioiTinh.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSVTheoGioiTinh.Legends.Add(legend2);
            this.chartSVTheoGioiTinh.Location = new System.Drawing.Point(321, 45);
            this.chartSVTheoGioiTinh.Name = "chartSVTheoGioiTinh";
            this.chartSVTheoGioiTinh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chartSVTheoGioiTinh.Series.Add(series2);
            this.chartSVTheoGioiTinh.Size = new System.Drawing.Size(266, 122);
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
            chartArea3.Name = "ChartArea1";
            this.charSVTheoNam.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.charSVTheoNam.Legends.Add(legend3);
            this.charSVTheoNam.Location = new System.Drawing.Point(4, 202);
            this.charSVTheoNam.Name = "charSVTheoNam";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "SLSV";
            series3.XValueMember = "Năm";
            series3.YValueMembers = "Số Người";
            this.charSVTheoNam.Series.Add(series3);
            this.charSVTheoNam.Size = new System.Drawing.Size(583, 196);
            this.charSVTheoNam.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(7, 170);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(575, 29);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Sinh Vien Học Theo Năm";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 25;
            this.gunaElipse3.TargetControl = this.chartSLSV;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 25;
            this.gunaElipse4.TargetControl = this.charSVTheoNam;
            // 
            // chartSVTinhThanh
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSVTinhThanh.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSVTinhThanh.Legends.Add(legend4);
            this.chartSVTinhThanh.Location = new System.Drawing.Point(4, 433);
            this.chartSVTinhThanh.Name = "chartSVTinhThanh";
            this.chartSVTinhThanh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartSVTinhThanh.Series.Add(series4);
            this.chartSVTinhThanh.Size = new System.Drawing.Size(303, 92);
            this.chartSVTinhThanh.TabIndex = 6;
            this.chartSVTinhThanh.Text = "chart1";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(4, 401);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(303, 29);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Sinh Vien Còn Học Theo Tỉnh ";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(313, 430);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(204, 26);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "SL Sinh Vien Còn Học: ";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(316, 474);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(204, 26);
            this.gunaLabel6.TabIndex = 9;
            this.gunaLabel6.Text = "Sinh Viên Chưa Xếp:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSVConHoc
            // 
            this.lblSVConHoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSVConHoc.Location = new System.Drawing.Point(506, 430);
            this.lblSVConHoc.Name = "lblSVConHoc";
            this.lblSVConHoc.Size = new System.Drawing.Size(70, 26);
            this.lblSVConHoc.TabIndex = 10;
            this.lblSVConHoc.Text = "0";
            this.lblSVConHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChuaXepLop
            // 
            this.lblChuaXepLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuaXepLop.Location = new System.Drawing.Point(506, 474);
            this.lblChuaXepLop.Name = "lblChuaXepLop";
            this.lblChuaXepLop.Size = new System.Drawing.Size(70, 26);
            this.lblChuaXepLop.TabIndex = 11;
            this.lblChuaXepLop.Text = "0";
            this.lblChuaXepLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 25;
            this.gunaElipse5.TargetControl = this.chartSVTinhThanh;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 625);
            this.Controls.Add(this.lblChuaXepLop);
            this.Controls.Add(this.lblSVConHoc);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.chartSVTinhThanh);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartSVTinhThanh)).EndInit();
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
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSVTinhThanh;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel lblSVConHoc;
        private Guna.UI.WinForms.GunaLabel lblChuaXepLop;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
    }
}