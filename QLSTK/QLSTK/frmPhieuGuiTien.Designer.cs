namespace QLSTK
{
    partial class frmPhieuGuiTien
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
            this.lblPhieuGuiTien = new System.Windows.Forms.Label();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.lbNgayGui = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.txtMaSoPGT = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbKhachHang = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbMaSoSTK = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNgayGui = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoTienGui = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.btnLuuVaXuatPhieu = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieuGuiTien
            // 
            this.lblPhieuGuiTien.AutoSize = true;
            this.lblPhieuGuiTien.BackColor = System.Drawing.Color.Transparent;
            this.lblPhieuGuiTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuGuiTien.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPhieuGuiTien.Location = new System.Drawing.Point(236, 16);
            this.lblPhieuGuiTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhieuGuiTien.Name = "lblPhieuGuiTien";
            this.lblPhieuGuiTien.Size = new System.Drawing.Size(249, 32);
            this.lblPhieuGuiTien.TabIndex = 19;
            this.lblPhieuGuiTien.Text = "LẬP PHIẾU GỬI TIỀN";
            this.lblPhieuGuiTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbSoTienGui.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbSoTienGui.Location = new System.Drawing.Point(103, 324);
            this.lbSoTienGui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(84, 20);
            this.lbSoTienGui.TabIndex = 13;
            this.lbSoTienGui.Text = "Số tiền gửi";
            // 
            // lbNgayGui
            // 
            this.lbNgayGui.AutoSize = true;
            this.lbNgayGui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbNgayGui.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbNgayGui.Location = new System.Drawing.Point(114, 241);
            this.lbNgayGui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayGui.Name = "lbNgayGui";
            this.lbNgayGui.Size = new System.Drawing.Size(73, 20);
            this.lbNgayGui.TabIndex = 12;
            this.lbNgayGui.Text = "Ngày gửi";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbKhachHang.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbKhachHang.Location = new System.Drawing.Point(96, 169);
            this.lbKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(91, 20);
            this.lbKhachHang.TabIndex = 11;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbMaSo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbMaSo.Location = new System.Drawing.Point(105, 104);
            this.lbMaSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(82, 20);
            this.lbMaSo.TabIndex = 10;
            this.lbMaSo.Text = "Mã sổ STK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(103, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã số PGT";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.White;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.txtSoTienGui);
            this.materialCard1.Controls.Add(this.txtNgayGui);
            this.materialCard1.Controls.Add(this.cmbMaSoSTK);
            this.materialCard1.Controls.Add(this.cmbKhachHang);
            this.materialCard1.Controls.Add(this.txtMaSoPGT);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.lbKhachHang);
            this.materialCard1.Controls.Add(this.lbMaSo);
            this.materialCard1.Controls.Add(this.lbNgayGui);
            this.materialCard1.Controls.Add(this.lbSoTienGui);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(72, 70);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(558, 394);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 23;
            // 
            // txtMaSoPGT
            // 
            this.txtMaSoPGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSoPGT.Depth = 0;
            this.txtMaSoPGT.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaSoPGT.Location = new System.Drawing.Point(251, 14);
            this.txtMaSoPGT.MaxLength = 50;
            this.txtMaSoPGT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaSoPGT.Multiline = false;
            this.txtMaSoPGT.Name = "txtMaSoPGT";
            this.txtMaSoPGT.Size = new System.Drawing.Size(266, 50);
            this.txtMaSoPGT.TabIndex = 22;
            this.txtMaSoPGT.Text = "";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.AutoResize = false;
            this.cmbKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbKhachHang.Depth = 0;
            this.cmbKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbKhachHang.DropDownHeight = 174;
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.DropDownWidth = 121;
            this.cmbKhachHang.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.IntegralHeight = false;
            this.cmbKhachHang.ItemHeight = 43;
            this.cmbKhachHang.Location = new System.Drawing.Point(251, 84);
            this.cmbKhachHang.MaxDropDownItems = 4;
            this.cmbKhachHang.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(266, 49);
            this.cmbKhachHang.TabIndex = 23;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.CmbKhachHang_SelectedIndexChanged);
            // 
            // cmbMaSoSTK
            // 
            this.cmbMaSoSTK.AutoResize = false;
            this.cmbMaSoSTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMaSoSTK.Depth = 0;
            this.cmbMaSoSTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMaSoSTK.DropDownHeight = 174;
            this.cmbMaSoSTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSoSTK.DropDownWidth = 121;
            this.cmbMaSoSTK.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMaSoSTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMaSoSTK.FormattingEnabled = true;
            this.cmbMaSoSTK.IntegralHeight = false;
            this.cmbMaSoSTK.ItemHeight = 43;
            this.cmbMaSoSTK.Location = new System.Drawing.Point(251, 154);
            this.cmbMaSoSTK.MaxDropDownItems = 4;
            this.cmbMaSoSTK.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMaSoSTK.Name = "cmbMaSoSTK";
            this.cmbMaSoSTK.Size = new System.Drawing.Size(266, 49);
            this.cmbMaSoSTK.TabIndex = 24;
            this.cmbMaSoSTK.SelectedIndexChanged += new System.EventHandler(this.CmbMaSoSTK_SelectedIndexChanged);
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayGui.Depth = 0;
            this.txtNgayGui.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNgayGui.Location = new System.Drawing.Point(251, 227);
            this.txtNgayGui.MaxLength = 50;
            this.txtNgayGui.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayGui.Multiline = false;
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(266, 50);
            this.txtNgayGui.TabIndex = 25;
            this.txtNgayGui.Text = "";
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienGui.Depth = 0;
            this.txtSoTienGui.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSoTienGui.Location = new System.Drawing.Point(251, 308);
            this.txtSoTienGui.MaxLength = 50;
            this.txtSoTienGui.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTienGui.Multiline = false;
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(266, 50);
            this.txtSoTienGui.TabIndex = 26;
            this.txtSoTienGui.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Depth = 0;
            this.btnLuu.DrawShadows = true;
            this.btnLuu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = global::QLSTK.Properties.Resources.icons8_save_close_32;
            this.btnLuu.Location = new System.Drawing.Point(272, 475);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 36);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnLuuVaXuatPhieu
            // 
            this.btnLuuVaXuatPhieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuuVaXuatPhieu.Depth = 0;
            this.btnLuuVaXuatPhieu.DrawShadows = true;
            this.btnLuuVaXuatPhieu.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLuuVaXuatPhieu.HighEmphasis = true;
            this.btnLuuVaXuatPhieu.Icon = global::QLSTK.Properties.Resources.icons8_print_32;
            this.btnLuuVaXuatPhieu.Location = new System.Drawing.Point(357, 475);
            this.btnLuuVaXuatPhieu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuuVaXuatPhieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuuVaXuatPhieu.Name = "btnLuuVaXuatPhieu";
            this.btnLuuVaXuatPhieu.Size = new System.Drawing.Size(187, 36);
            this.btnLuuVaXuatPhieu.TabIndex = 27;
            this.btnLuuVaXuatPhieu.Text = "Lưu và xuất phiếu";
            this.btnLuuVaXuatPhieu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuuVaXuatPhieu.UseAccentColor = false;
            this.btnLuuVaXuatPhieu.UseVisualStyleBackColor = true;
            this.btnLuuVaXuatPhieu.Click += new System.EventHandler(this.btnLuuVaXuatPhieu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.DrawShadows = true;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = global::QLSTK.Properties.Resources.icons8_exit_32;
            this.btnHuy.Location = new System.Drawing.Point(552, 475);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 36);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // frmPhieuGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 571);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuVaXuatPhieu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblPhieuGuiTien);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "frmPhieuGuiTien";
            this.Text = "frmPhieuGuiTien";
            this.Load += new System.EventHandler(this.frmPhieuGuiTien_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieuGuiTien;
        private System.Windows.Forms.Label lbSoTienGui;
        private System.Windows.Forms.Label lbNgayGui;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.Label label1;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cmbMaSoSTK;
        private MaterialSkin.Controls.MaterialComboBox cmbKhachHang;
        private MaterialSkin.Controls.MaterialTextBox txtMaSoPGT;
        private MaterialSkin.Controls.MaterialTextBox txtSoTienGui;
        private MaterialSkin.Controls.MaterialTextBox txtNgayGui;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialButton btnLuuVaXuatPhieu;
        private MaterialSkin.Controls.MaterialButton btnHuy;
    }
}