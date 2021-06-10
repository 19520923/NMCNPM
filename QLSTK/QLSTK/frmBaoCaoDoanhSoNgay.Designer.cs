

namespace QLSTK
{
    partial class frmBaoCaoDoanhSoNgay
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
            this.lblbaoCaoDoanhSoNgay = new System.Windows.Forms.Label();
            this.dtpNgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.lbChenhLech = new System.Windows.Forms.Label();
            this.lbTongChiNgay = new System.Windows.Forms.Label();
            this.lbTongThuNgay = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.txtChenhLech = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTongChiNgay = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTongThuNgay = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.btnTaoBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnTraCuu = new MaterialSkin.Controls.MaterialButton();
            this.btnXuatFile = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbaoCaoDoanhSoNgay
            // 
            this.lblbaoCaoDoanhSoNgay.AutoEllipsis = true;
            this.lblbaoCaoDoanhSoNgay.AutoSize = true;
            this.lblbaoCaoDoanhSoNgay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaoCaoDoanhSoNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblbaoCaoDoanhSoNgay.Location = new System.Drawing.Point(202, 7);
            this.lblbaoCaoDoanhSoNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaoCaoDoanhSoNgay.Name = "lblbaoCaoDoanhSoNgay";
            this.lblbaoCaoDoanhSoNgay.Size = new System.Drawing.Size(262, 29);
            this.lblbaoCaoDoanhSoNgay.TabIndex = 36;
            this.lblbaoCaoDoanhSoNgay.Text = "Báo cáo doanh số ngày";
            // 
            // dtpNgayBaoCao
            // 
            this.dtpNgayBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgayBaoCao.CustomFormat = "";
            this.dtpNgayBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBaoCao.Location = new System.Drawing.Point(20, 49);
            this.dtpNgayBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBaoCao.Name = "dtpNgayBaoCao";
            this.dtpNgayBaoCao.Size = new System.Drawing.Size(153, 20);
            this.dtpNgayBaoCao.TabIndex = 35;
            // 
            // lbChenhLech
            // 
            this.lbChenhLech.AutoSize = true;
            this.lbChenhLech.BackColor = System.Drawing.Color.White;
            this.lbChenhLech.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbChenhLech.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbChenhLech.Location = new System.Drawing.Point(31, 131);
            this.lbChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChenhLech.Name = "lbChenhLech";
            this.lbChenhLech.Size = new System.Drawing.Size(84, 19);
            this.lbChenhLech.TabIndex = 34;
            this.lbChenhLech.Text = "Chênh Lệch";
            // 
            // lbTongChiNgay
            // 
            this.lbTongChiNgay.AutoSize = true;
            this.lbTongChiNgay.BackColor = System.Drawing.Color.White;
            this.lbTongChiNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbTongChiNgay.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTongChiNgay.Location = new System.Drawing.Point(12, 78);
            this.lbTongChiNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongChiNgay.Name = "lbTongChiNgay";
            this.lbTongChiNgay.Size = new System.Drawing.Size(103, 19);
            this.lbTongChiNgay.TabIndex = 33;
            this.lbTongChiNgay.Text = "Tổng chi ngày";
            // 
            // lbTongThuNgay
            // 
            this.lbTongThuNgay.AutoSize = true;
            this.lbTongThuNgay.BackColor = System.Drawing.Color.White;
            this.lbTongThuNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbTongThuNgay.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTongThuNgay.Location = new System.Drawing.Point(9, 25);
            this.lbTongThuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongThuNgay.Name = "lbTongThuNgay";
            this.lbTongThuNgay.Size = new System.Drawing.Size(105, 19);
            this.lbTongThuNgay.TabIndex = 32;
            this.lbTongThuNgay.Text = "Tổng thu ngày";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoEllipsis = true;
            this.lbNgay.AutoSize = true;
            this.lbNgay.BackColor = System.Drawing.Color.White;
            this.lbNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lbNgay.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbNgay.Location = new System.Drawing.Point(16, 19);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(45, 19);
            this.lbNgay.TabIndex = 25;
            this.lbNgay.Text = "Ngày";
            // 
            // dgvBaoCao
            // 
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
            this.dgvBaoCao.Location = new System.Drawing.Point(5, 188);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBaoCao.Name = "dgvBaoCao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCao.Size = new System.Drawing.Size(638, 255);
            this.dgvBaoCao.TabIndex = 37;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.txtChenhLech);
            this.materialCard1.Controls.Add(this.txtTongChiNgay);
            this.materialCard1.Controls.Add(this.txtTongThuNgay);
            this.materialCard1.Controls.Add(this.lbTongChiNgay);
            this.materialCard1.Controls.Add(this.lbTongThuNgay);
            this.materialCard1.Controls.Add(this.lbChenhLech);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(286, 9);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(356, 172);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 41;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChenhLech.Depth = 0;
            this.txtChenhLech.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtChenhLech.Location = new System.Drawing.Point(148, 113);
            this.txtChenhLech.MaxLength = 50;
            this.txtChenhLech.MouseState = MaterialSkin.MouseState.OUT;
            this.txtChenhLech.Multiline = false;
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.Size = new System.Drawing.Size(182, 50);
            this.txtChenhLech.TabIndex = 37;
            this.txtChenhLech.Text = "";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongChiNgay.Depth = 0;
            this.txtTongChiNgay.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTongChiNgay.Location = new System.Drawing.Point(148, 61);
            this.txtTongChiNgay.MaxLength = 50;
            this.txtTongChiNgay.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTongChiNgay.Multiline = false;
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.Size = new System.Drawing.Size(182, 50);
            this.txtTongChiNgay.TabIndex = 36;
            this.txtTongChiNgay.Text = "";
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongThuNgay.Depth = 0;
            this.txtTongThuNgay.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTongThuNgay.Location = new System.Drawing.Point(148, 10);
            this.txtTongThuNgay.MaxLength = 50;
            this.txtTongThuNgay.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTongThuNgay.Multiline = false;
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.Size = new System.Drawing.Size(182, 50);
            this.txtTongThuNgay.TabIndex = 35;
            this.txtTongThuNgay.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvBaoCao);
            this.materialCard2.Controls.Add(this.dtpNgayBaoCao);
            this.materialCard2.Controls.Add(this.materialCard1);
            this.materialCard2.Controls.Add(this.lbNgay);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(6, 61);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(652, 459);
            this.materialCard2.TabIndex = 42;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(0, 0);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            // 
            // 
            // 
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.TabIndex = 0;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoBaoCao.Depth = 0;
            this.btnTaoBaoCao.DrawShadows = true;
            this.btnTaoBaoCao.HighEmphasis = true;
            this.btnTaoBaoCao.Icon = global::QLSTK.Properties.Resources.icons8_add_property_32;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(514, 540);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTaoBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(144, 36);
            this.btnTaoBaoCao.TabIndex = 46;
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
            this.btnTraCuu.Icon = global::QLSTK.Properties.Resources.icons8_view_32;
            this.btnTraCuu.Location = new System.Drawing.Point(396, 541);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTraCuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(110, 36);
            this.btnTraCuu.TabIndex = 45;
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
            this.btnXuatFile.Icon = global::QLSTK.Properties.Resources.icons8_send_to_printer_30;
            this.btnXuatFile.Location = new System.Drawing.Point(269, 542);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXuatFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(119, 36);
            this.btnXuatFile.TabIndex = 44;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXuatFile.UseAccentColor = false;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.BtnXuatFile_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhat.Depth = 0;
            this.btnCapNhat.DrawShadows = true;
            this.btnCapNhat.HighEmphasis = true;
            this.btnCapNhat.Icon = global::QLSTK.Properties.Resources.icons8_update_32;
            this.btnCapNhat.Location = new System.Drawing.Point(140, 542);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 36);
            this.btnCapNhat.TabIndex = 43;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // frmBaoCaoDoanhSoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 628);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.lblbaoCaoDoanhSoNgay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoDoanhSoNgay";
            this.Text = "frmBaoCaoDoanhSoNgay";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhSoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbaoCaoDoanhSoNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayBaoCao;
        private System.Windows.Forms.Label lbChenhLech;
        private System.Windows.Forms.Label lbTongChiNgay;
        private System.Windows.Forms.Label lbTongThuNgay;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtChenhLech;
        private MaterialSkin.Controls.MaterialTextBox txtTongChiNgay;
        private MaterialSkin.Controls.MaterialTextBox txtTongThuNgay;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialButton btnXuatFile;
        private MaterialSkin.Controls.MaterialButton btnTraCuu;
        private MaterialSkin.Controls.MaterialButton btnTaoBaoCao;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
    }
}