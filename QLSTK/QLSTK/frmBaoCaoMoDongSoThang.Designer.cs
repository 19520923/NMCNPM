using DevExpress.XtraEditors;
using System;

namespace QLSTK
{
    partial class frmBaoCaoMoDongSoThang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaoMoDongSoThang = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblTongSoMo = new System.Windows.Forms.Label();
            this.lblTongSoDong = new System.Windows.Forms.Label();
            this.lblChenhLech = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.lblLTK = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.cmbLoaiTietKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbNam = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbThang = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard2 = new MaterialSurface.MaterialCard();
            this.txtChenhLech = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTongChiNgay = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTongThuNgay = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnTaoBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnTraCuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXuatFile = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaoMoDongSoThang
            // 
            this.lblBaoMoDongSoThang.AutoEllipsis = true;
            this.lblBaoMoDongSoThang.AutoSize = true;
            this.lblBaoMoDongSoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoMoDongSoThang.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblBaoMoDongSoThang.Location = new System.Drawing.Point(167, 16);
            this.lblBaoMoDongSoThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaoMoDongSoThang.Name = "lblBaoMoDongSoThang";
            this.lblBaoMoDongSoThang.Size = new System.Drawing.Size(343, 31);
            this.lblBaoMoDongSoThang.TabIndex = 48;
            this.lblBaoMoDongSoThang.Text = "Báo cáo mở/ đóng sổ tháng";
            // 
            // lblThang
            // 
            this.lblThang.AutoEllipsis = true;
            this.lblThang.AutoSize = true;
            this.lblThang.BackColor = System.Drawing.Color.White;
            this.lblThang.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThang.Location = new System.Drawing.Point(9, 31);
            this.lblThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(50, 19);
            this.lblThang.TabIndex = 31;
            this.lblThang.Text = "Tháng";
            // 
            // lblTongSoMo
            // 
            this.lblTongSoMo.AutoSize = true;
            this.lblTongSoMo.BackColor = System.Drawing.Color.White;
            this.lblTongSoMo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTongSoMo.Location = new System.Drawing.Point(27, 86);
            this.lblTongSoMo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoMo.Name = "lblTongSoMo";
            this.lblTongSoMo.Size = new System.Drawing.Size(88, 19);
            this.lblTongSoMo.TabIndex = 40;
            this.lblTongSoMo.Text = "Tổng sổ mở";
            // 
            // lblTongSoDong
            // 
            this.lblTongSoDong.AutoSize = true;
            this.lblTongSoDong.BackColor = System.Drawing.Color.White;
            this.lblTongSoDong.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTongSoDong.Location = new System.Drawing.Point(14, 32);
            this.lblTongSoDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoDong.Name = "lblTongSoDong";
            this.lblTongSoDong.Size = new System.Drawing.Size(101, 19);
            this.lblTongSoDong.TabIndex = 39;
            this.lblTongSoDong.Text = "Tổng sổ đóng";
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.BackColor = System.Drawing.Color.White;
            this.lblChenhLech.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblChenhLech.Location = new System.Drawing.Point(31, 133);
            this.lblChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(84, 19);
            this.lblChenhLech.TabIndex = 41;
            this.lblChenhLech.Text = "Chênh Lệch";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvBaoCao.Location = new System.Drawing.Point(7, 216);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCao.Size = new System.Drawing.Size(638, 253);
            this.dgvBaoCao.TabIndex = 49;
            // 
            // lblLTK
            // 
            this.lblLTK.AutoEllipsis = true;
            this.lblLTK.AutoSize = true;
            this.lblLTK.BackColor = System.Drawing.Color.White;
            this.lblLTK.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblLTK.Location = new System.Drawing.Point(9, 91);
            this.lblLTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLTK.Name = "lblLTK";
            this.lblLTK.Size = new System.Drawing.Size(100, 19);
            this.lblLTK.TabIndex = 52;
            this.lblLTK.Text = "Loại tiết kiệm";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.cmbLoaiTietKiem);
            this.materialCard1.Controls.Add(this.cmbNam);
            this.materialCard1.Controls.Add(this.cmbThang);
            this.materialCard1.Controls.Add(this.lblLTK);
            this.materialCard1.Controls.Add(this.lblThang);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(7, 29);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(310, 180);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 58;
            // 
            // cmbLoaiTietKiem
            // 
            this.cmbLoaiTietKiem.AutoResize = false;
            this.cmbLoaiTietKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLoaiTietKiem.Depth = 0;
            this.cmbLoaiTietKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLoaiTietKiem.DropDownHeight = 174;
            this.cmbLoaiTietKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiTietKiem.DropDownWidth = 121;
            this.cmbLoaiTietKiem.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLoaiTietKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLoaiTietKiem.FormattingEnabled = true;
            this.cmbLoaiTietKiem.IntegralHeight = false;
            this.cmbLoaiTietKiem.ItemHeight = 43;
            this.cmbLoaiTietKiem.Location = new System.Drawing.Point(143, 74);
            this.cmbLoaiTietKiem.MaxDropDownItems = 4;
            this.cmbLoaiTietKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLoaiTietKiem.Name = "cmbLoaiTietKiem";
            this.cmbLoaiTietKiem.Size = new System.Drawing.Size(121, 49);
            this.cmbLoaiTietKiem.TabIndex = 55;
            // 
            // cmbNam
            // 
            this.cmbNam.AutoResize = false;
            this.cmbNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNam.Depth = 0;
            this.cmbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNam.DropDownHeight = 174;
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.DropDownWidth = 121;
            this.cmbNam.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.IntegralHeight = false;
            this.cmbNam.ItemHeight = 43;
            this.cmbNam.Location = new System.Drawing.Point(143, 18);
            this.cmbNam.MaxDropDownItems = 4;
            this.cmbNam.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(121, 49);
            this.cmbNam.TabIndex = 54;
            // 
            // cmbThang
            // 
            this.cmbThang.AutoResize = false;
            this.cmbThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbThang.Depth = 0;
            this.cmbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbThang.DropDownHeight = 174;
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.DropDownWidth = 121;
            this.cmbThang.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.IntegralHeight = false;
            this.cmbThang.ItemHeight = 43;
            this.cmbThang.Location = new System.Drawing.Point(80, 17);
            this.cmbThang.MaxDropDownItems = 4;
            this.cmbThang.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(52, 49);
            this.cmbThang.TabIndex = 53;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.CardColor = System.Drawing.Color.White;
            this.materialCard2.Controls.Add(this.txtChenhLech);
            this.materialCard2.Controls.Add(this.txtTongChiNgay);
            this.materialCard2.Controls.Add(this.txtTongThuNgay);
            this.materialCard2.Controls.Add(this.lblTongSoDong);
            this.materialCard2.Controls.Add(this.lblTongSoMo);
            this.materialCard2.Controls.Add(this.lblChenhLech);
            this.materialCard2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard2.Location = new System.Drawing.Point(327, 28);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseInteract = false;
            this.materialCard2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Radius = 8;
            this.materialCard2.ShawdowDepth = 2;
            this.materialCard2.ShawdowOpacity = 50;
            this.materialCard2.Size = new System.Drawing.Size(318, 181);
            this.materialCard2.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard2.TabIndex = 59;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChenhLech.Depth = 0;
            this.txtChenhLech.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtChenhLech.Location = new System.Drawing.Point(120, 122);
            this.txtChenhLech.MaxLength = 50;
            this.txtChenhLech.MouseState = MaterialSkin.MouseState.OUT;
            this.txtChenhLech.Multiline = false;
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.Size = new System.Drawing.Size(179, 50);
            this.txtChenhLech.TabIndex = 44;
            this.txtChenhLech.Text = "";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongChiNgay.Depth = 0;
            this.txtTongChiNgay.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTongChiNgay.Location = new System.Drawing.Point(120, 70);
            this.txtTongChiNgay.MaxLength = 50;
            this.txtTongChiNgay.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTongChiNgay.Multiline = false;
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.Size = new System.Drawing.Size(179, 50);
            this.txtTongChiNgay.TabIndex = 43;
            this.txtTongChiNgay.Text = "";
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongThuNgay.Depth = 0;
            this.txtTongThuNgay.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTongThuNgay.Location = new System.Drawing.Point(120, 18);
            this.txtTongThuNgay.MaxLength = 50;
            this.txtTongThuNgay.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTongThuNgay.Multiline = false;
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.Size = new System.Drawing.Size(179, 50);
            this.txtTongThuNgay.TabIndex = 42;
            this.txtTongThuNgay.Text = "";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialCard1);
            this.materialCard3.Controls.Add(this.materialCard2);
            this.materialCard3.Controls.Add(this.dgvBaoCao);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(4, 61);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(652, 476);
            this.materialCard3.TabIndex = 60;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoBaoCao.Depth = 0;
            this.btnTaoBaoCao.DrawShadows = true;
            this.btnTaoBaoCao.HighEmphasis = true;
            this.btnTaoBaoCao.Icon = global::QLSTK.Properties.Resources.icons8_create_32;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(512, 557);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTaoBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(144, 36);
            this.btnTaoBaoCao.TabIndex = 64;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoBaoCao.UseAccentColor = false;
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.BtnTaoBaoCao_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTraCuu.Depth = 0;
            this.btnTraCuu.DrawShadows = true;
            this.btnTraCuu.HighEmphasis = true;
            this.btnTraCuu.Icon = global::QLSTK.Properties.Resources.icons8_search_26;
            this.btnTraCuu.Location = new System.Drawing.Point(394, 557);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTraCuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(110, 36);
            this.btnTraCuu.TabIndex = 63;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTraCuu.UseAccentColor = false;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXuatFile.Depth = 0;
            this.btnXuatFile.DrawShadows = true;
            this.btnXuatFile.HighEmphasis = true;
            this.btnXuatFile.Icon = global::QLSTK.Properties.Resources.icons8_print_32;
            this.btnXuatFile.Location = new System.Drawing.Point(267, 560);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXuatFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(119, 36);
            this.btnXuatFile.TabIndex = 62;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXuatFile.UseAccentColor = false;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhat.Depth = 0;
            this.btnCapNhat.DrawShadows = true;
            this.btnCapNhat.HighEmphasis = true;
            this.btnCapNhat.Icon = global::QLSTK.Properties.Resources.icons8_update_32;
            this.btnCapNhat.Location = new System.Drawing.Point(138, 561);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 36);
            this.btnCapNhat.TabIndex = 61;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // frmBaoCaoMoDongSoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 644);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.lblBaoMoDongSoThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoMoDongSoThang";
            this.Text = "frmBaoCaoDoanhSoThang";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhSoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaoMoDongSoThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblTongSoMo;
        private System.Windows.Forms.Label lblTongSoDong;
        private System.Windows.Forms.Label lblChenhLech;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label lblLTK;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cmbNam;
        private MaterialSkin.Controls.MaterialComboBox cmbThang;
        private MaterialSkin.Controls.MaterialComboBox cmbLoaiTietKiem;
        private MaterialSkin.Controls.MaterialTextBox txtChenhLech;
        private MaterialSurface.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox txtTongChiNgay;
        private MaterialSkin.Controls.MaterialTextBox txtTongThuNgay;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialButton btnXuatFile;
        private MaterialSkin.Controls.MaterialButton btnTraCuu;
        private MaterialSkin.Controls.MaterialButton btnTaoBaoCao;

        public EventHandler txtChenhLech_TextChanged { get; private set; }
    }
}