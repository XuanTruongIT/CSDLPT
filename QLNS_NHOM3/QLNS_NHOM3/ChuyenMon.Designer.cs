namespace QLNS_NHOM3
{
    partial class frmChuyenMon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_mess = new System.Windows.Forms.Label();
            this.txtMaCM = new System.Windows.Forms.TextBox();
            this.dgv_chuyenmon = new System.Windows.Forms.DataGridView();
            this.MaCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenmon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_mess);
            this.groupBox1.Controls.Add(this.txtMaCM);
            this.groupBox1.Controls.Add(this.dgv_chuyenmon);
            this.groupBox1.Controls.Add(this.txtTenCM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Chuyên Môn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(130, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 34;
            // 
            // label_mess
            // 
            this.label_mess.AutoSize = true;
            this.label_mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mess.ForeColor = System.Drawing.Color.Red;
            this.label_mess.Location = new System.Drawing.Point(130, 144);
            this.label_mess.Name = "label_mess";
            this.label_mess.Size = new System.Drawing.Size(0, 16);
            this.label_mess.TabIndex = 31;
            // 
            // txtMaCM
            // 
            this.txtMaCM.Location = new System.Drawing.Point(133, 108);
            this.txtMaCM.Name = "txtMaCM";
            this.txtMaCM.Size = new System.Drawing.Size(315, 20);
            this.txtMaCM.TabIndex = 0;
            // 
            // dgv_chuyenmon
            // 
            this.dgv_chuyenmon.AllowUserToAddRows = false;
            this.dgv_chuyenmon.AllowUserToDeleteRows = false;
            this.dgv_chuyenmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuyenmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCM,
            this.TenCM});
            this.dgv_chuyenmon.Location = new System.Drawing.Point(490, 108);
            this.dgv_chuyenmon.Name = "dgv_chuyenmon";
            this.dgv_chuyenmon.ReadOnly = true;
            this.dgv_chuyenmon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chuyenmon.Size = new System.Drawing.Size(480, 236);
            this.dgv_chuyenmon.TabIndex = 29;
            // 
            // MaCM
            // 
            this.MaCM.DataPropertyName = "MaCM";
            this.MaCM.FillWeight = 120F;
            this.MaCM.HeaderText = "Mã Chuyên Môn";
            this.MaCM.Name = "MaCM";
            this.MaCM.ReadOnly = true;
            this.MaCM.Width = 120;
            // 
            // TenCM
            // 
            this.TenCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCM.DataPropertyName = "TenCM";
            this.TenCM.HeaderText = "Tên Chuyên Môn";
            this.TenCM.Name = "TenCM";
            this.TenCM.ReadOnly = true;
            // 
            // txtTenCM
            // 
            this.txtTenCM.Location = new System.Drawing.Point(133, 177);
            this.txtTenCM.Name = "txtTenCM";
            this.txtTenCM.Size = new System.Drawing.Size(315, 20);
            this.txtTenCM.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "&Tên Chuyên Môn";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(352, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(253, 311);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(154, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "&Mã Chuyên Môn";
            // 
            // frmChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChuyenMon";
            this.Text = "Chuyên Môn";
            this.Load += new System.EventHandler(this.frmChuyenMon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenmon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_mess;
        private System.Windows.Forms.TextBox txtMaCM;
        private System.Windows.Forms.DataGridView dgv_chuyenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCM;
        private System.Windows.Forms.TextBox txtTenCM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
    }
}