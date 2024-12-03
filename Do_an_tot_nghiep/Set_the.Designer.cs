namespace Do_an_tot_nghiep
{
    partial class Set_the
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ketnoi_rfid1 = new System.Windows.Forms.Button();
            this.ketnoi_rfid2 = new System.Windows.Forms.Button();
            this.comboBoxRF2 = new System.Windows.Forms.ComboBox();
            this.comboBoxRF1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ketnoi_cam = new System.Windows.Forms.Button();
            this.comboBoxCAM2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCAM1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.thongtin = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 309);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kết nối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lựa chọn thiết bị kết nối";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ketnoi_rfid1);
            this.groupBox1.Controls.Add(this.ketnoi_rfid2);
            this.groupBox1.Controls.Add(this.comboBoxRF2);
            this.groupBox1.Controls.Add(this.comboBoxRF1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(405, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 151);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cổng COM";
            // 
            // ketnoi_rfid1
            // 
            this.ketnoi_rfid1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketnoi_rfid1.Location = new System.Drawing.Point(121, 28);
            this.ketnoi_rfid1.Name = "ketnoi_rfid1";
            this.ketnoi_rfid1.Size = new System.Drawing.Size(100, 46);
            this.ketnoi_rfid1.TabIndex = 9;
            this.ketnoi_rfid1.Text = "Kết nối RFID 1";
            this.ketnoi_rfid1.UseVisualStyleBackColor = true;
            this.ketnoi_rfid1.Click += new System.EventHandler(this.rfid1);
            // 
            // ketnoi_rfid2
            // 
            this.ketnoi_rfid2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketnoi_rfid2.Location = new System.Drawing.Point(121, 85);
            this.ketnoi_rfid2.Name = "ketnoi_rfid2";
            this.ketnoi_rfid2.Size = new System.Drawing.Size(100, 46);
            this.ketnoi_rfid2.TabIndex = 10;
            this.ketnoi_rfid2.Text = "Kết nối RFID 2";
            this.ketnoi_rfid2.UseVisualStyleBackColor = true;
            this.ketnoi_rfid2.Click += new System.EventHandler(this.rfid2);
            // 
            // comboBoxRF2
            // 
            this.comboBoxRF2.FormattingEnabled = true;
            this.comboBoxRF2.Location = new System.Drawing.Point(9, 95);
            this.comboBoxRF2.Name = "comboBoxRF2";
            this.comboBoxRF2.Size = new System.Drawing.Size(97, 29);
            this.comboBoxRF2.TabIndex = 0;
            // 
            // comboBoxRF1
            // 
            this.comboBoxRF1.FormattingEnabled = true;
            this.comboBoxRF1.Location = new System.Drawing.Point(9, 38);
            this.comboBoxRF1.Name = "comboBoxRF1";
            this.comboBoxRF1.Size = new System.Drawing.Size(97, 29);
            this.comboBoxRF1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ketnoi_cam);
            this.groupBox2.Controls.Add(this.comboBoxCAM2);
            this.groupBox2.Controls.Add(this.comboBoxCAM1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 151);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn camera";
            // 
            // ketnoi_cam
            // 
            this.ketnoi_cam.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ketnoi_cam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketnoi_cam.Location = new System.Drawing.Point(224, 41);
            this.ketnoi_cam.Name = "ketnoi_cam";
            this.ketnoi_cam.Size = new System.Drawing.Size(119, 77);
            this.ketnoi_cam.TabIndex = 19;
            this.ketnoi_cam.Text = "Kết nối camera";
            this.ketnoi_cam.UseVisualStyleBackColor = true;
            this.ketnoi_cam.Click += new System.EventHandler(this.OnConnectClick);
            // 
            // comboBoxCAM2
            // 
            this.comboBoxCAM2.FormattingEnabled = true;
            this.comboBoxCAM2.Location = new System.Drawing.Point(11, 89);
            this.comboBoxCAM2.Name = "comboBoxCAM2";
            this.comboBoxCAM2.Size = new System.Drawing.Size(198, 29);
            this.comboBoxCAM2.TabIndex = 18;
            // 
            // comboBoxCAM1
            // 
            this.comboBoxCAM1.FormattingEnabled = true;
            this.comboBoxCAM1.Location = new System.Drawing.Point(11, 41);
            this.comboBoxCAM1.Name = "comboBoxCAM1";
            this.comboBoxCAM1.Size = new System.Drawing.Size(198, 29);
            this.comboBoxCAM1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage2.Controls.Add(this.thoat);
            this.tabPage2.Controls.Add(this.xoa);
            this.tabPage2.Controls.Add(this.them);
            this.tabPage2.Controls.Add(this.thongtin);
            this.tabPage2.Controls.Add(this.txtMaThe);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý thẻ";
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(513, 207);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(104, 61);
            this.thoat.TabIndex = 23;
            this.thoat.Text = "Xong";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(513, 130);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(104, 61);
            this.xoa.TabIndex = 22;
            this.xoa.Text = "Xóa thẻ";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click_1);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(513, 53);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(104, 61);
            this.them.TabIndex = 21;
            this.them.Text = "Thêm thẻ";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // thongtin
            // 
            this.thongtin.AllowUserToAddRows = false;
            this.thongtin.AllowUserToDeleteRows = false;
            this.thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Mathe,
            this.NgaySet});
            this.thongtin.Location = new System.Drawing.Point(30, 53);
            this.thongtin.MultiSelect = false;
            this.thongtin.Name = "thongtin";
            this.thongtin.ReadOnly = true;
            this.thongtin.RowHeadersVisible = false;
            this.thongtin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.thongtin.Size = new System.Drawing.Size(455, 215);
            this.thongtin.TabIndex = 20;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // Mathe
            // 
            this.Mathe.DataPropertyName = "MaThe";
            this.Mathe.HeaderText = "Mã thẻ";
            this.Mathe.Name = "Mathe";
            this.Mathe.ReadOnly = true;
            this.Mathe.Width = 200;
            // 
            // NgaySet
            // 
            this.NgaySet.DataPropertyName = "NgaySet";
            this.NgaySet.HeaderText = "Ngày nhập";
            this.NgaySet.Name = "NgaySet";
            this.NgaySet.ReadOnly = true;
            this.NgaySet.Width = 210;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(231, 16);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(195, 21);
            this.txtMaThe.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã thẻ đọc từ Reader :";
            // 
            // Set_the
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 304);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Set_the";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập";
            this.Load += new System.EventHandler(this.Set_the_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongtin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRF2;
        private System.Windows.Forms.ComboBox comboBoxRF1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button ketnoi_cam;
        public System.Windows.Forms.ComboBox comboBoxCAM2;
        public System.Windows.Forms.ComboBox comboBoxCAM1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView thongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySet;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ketnoi_rfid1;
        private System.Windows.Forms.Button ketnoi_rfid2;
        private System.Windows.Forms.Label label2;
    }
}