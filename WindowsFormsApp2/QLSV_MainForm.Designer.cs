namespace WindowsFormsApp2
{
    partial class QLSV_MainForm
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 45;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(220, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(488, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Mèo Con Ngok Ngek";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // pnData
            // 
            this.pnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnData.Location = new System.Drawing.Point(179, 41);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(791, 664);
            this.pnData.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(147)))), ((int)(((byte)(212)))));
            this.panel1.Location = new System.Drawing.Point(26, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 360);
            this.panel1.TabIndex = 3;
            // 
            // QLSV_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.gunaLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLSV_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSV_MainForm";
            this.Load += new System.EventHandler(this.QLSV_MainForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Panel panel1;
    }
}