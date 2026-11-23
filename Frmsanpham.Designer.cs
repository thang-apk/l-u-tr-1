namespace WindowsFormsApp
{
    partial class Frmsanpham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txthang = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbloaisp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại sp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hãng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gía:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tồn kho:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày nhập:";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(145, 82);
            this.txtmasp.Multiline = true;
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(224, 32);
            this.txtmasp.TabIndex = 9;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(145, 132);
            this.txttensp.Multiline = true;
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(224, 32);
            this.txttensp.TabIndex = 10;
            // 
            // txthang
            // 
            this.txthang.Location = new System.Drawing.Point(145, 221);
            this.txthang.Multiline = true;
            this.txthang.Name = "txthang";
            this.txthang.Size = new System.Drawing.Size(224, 32);
            this.txthang.TabIndex = 11;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(145, 271);
            this.txtgia.Multiline = true;
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(224, 32);
            this.txtgia.TabIndex = 12;
            // 
            // txttonkho
            // 
            this.txttonkho.Location = new System.Drawing.Point(145, 320);
            this.txttonkho.Multiline = true;
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.Size = new System.Drawing.Size(224, 32);
            this.txttonkho.TabIndex = 13;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(26, 416);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(84, 39);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(145, 416);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(84, 39);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(261, 416);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(84, 39);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(145, 482);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(84, 62);
            this.btnlammoi.TabIndex = 18;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Location = new System.Drawing.Point(375, 132);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowHeadersWidth = 51;
            this.dgvsanpham.RowTemplate.Height = 24;
            this.dgvsanpham.Size = new System.Drawing.Size(996, 412);
            this.dgvsanpham.TabIndex = 19;
            this.dgvsanpham.UseWaitCursor = true;
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick);
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.Location = new System.Drawing.Point(145, 372);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(224, 22);
            this.dtpngaynhap.TabIndex = 22;
            // 
            // cbloaisp
            // 
            this.cbloaisp.FormattingEnabled = true;
            this.cbloaisp.Items.AddRange(new object[] {
            "Máy tính",
            "",
            "Điện thoại",
            "",
            "Máy tính bảng",
            "",
            "Phụ kiện"});
            this.cbloaisp.Location = new System.Drawing.Point(145, 183);
            this.cbloaisp.Name = "cbloaisp";
            this.cbloaisp.Size = new System.Drawing.Size(224, 24);
            this.cbloaisp.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(460, 82);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(770, 32);
            this.txttimkiem.TabIndex = 25;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(1236, 82);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(135, 32);
            this.btntimkiem.TabIndex = 26;
            this.btntimkiem.Text = "Tìm kiếm ";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // Frmsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 548);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbloaisp);
            this.Controls.Add(this.dtpngaynhap);
            this.Controls.Add(this.dgvsanpham);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttonkho);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txthang);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmsanpham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.Frmsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txthang;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.ComboBox cbloaisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
    }
}