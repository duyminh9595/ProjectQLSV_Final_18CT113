namespace WindowsFormsApp2.AdminUI
{
    partial class PhanLopFormSVUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThem = new Guna.UI.WinForms.GunaGradientButton();
            this.cmbLop = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNganh = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 42);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chức Năng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BaseColor1 = System.Drawing.Color.Red;
            this.btnThoat.BaseColor2 = System.Drawing.Color.Red;
            this.btnThoat.BorderColor = System.Drawing.Color.Red;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = null;
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(266, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.btnThoat.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(86, 42);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnThem.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = null;
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(170, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnThem.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(85, 42);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "OK";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbLop
            // 
            this.cmbLop.BackColor = System.Drawing.Color.Transparent;
            this.cmbLop.BaseColor = System.Drawing.Color.White;
            this.cmbLop.BorderColor = System.Drawing.Color.Silver;
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLop.ForeColor = System.Drawing.Color.Black;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(170, 142);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbLop.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbLop.Size = new System.Drawing.Size(182, 30);
            this.cmbLop.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chọn Lớp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNganh
            // 
            this.cmbNganh.BackColor = System.Drawing.Color.Transparent;
            this.cmbNganh.BaseColor = System.Drawing.Color.White;
            this.cmbNganh.BorderColor = System.Drawing.Color.Silver;
            this.cmbNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNganh.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNganh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNganh.ForeColor = System.Drawing.Color.Black;
            this.cmbNganh.FormattingEnabled = true;
            this.cmbNganh.Location = new System.Drawing.Point(170, 94);
            this.cmbNganh.Name = "cmbNganh";
            this.cmbNganh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNganh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbNganh.Size = new System.Drawing.Size(182, 30);
            this.cmbNganh.TabIndex = 20;
            this.cmbNganh.SelectedIndexChanged += new System.EventHandler(this.cmbNganh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn Ngành";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSSV
            // 
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(23, 9);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(329, 68);
            this.lblMSSV.TabIndex = 26;
            this.lblMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhanLopFormSVUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNganh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanLopFormSVUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanLopFormSVUI";
            this.Load += new System.EventHandler(this.PhanLopFormSVUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaGradientButton btnThoat;
        private Guna.UI.WinForms.GunaGradientButton btnThem;
        private Guna.UI.WinForms.GunaComboBox cmbLop;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cmbNganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMSSV;
    }
}