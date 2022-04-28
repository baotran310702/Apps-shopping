namespace _20521110_TranQuocBao_TH2
{
    partial class formOrdered
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrdered));
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.name_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_Box = new System.Windows.Forms.Panel();
            this.history_label = new System.Windows.Forms.Label();
            this.logo_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sum_Money = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.header_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_Product,
            this.amount_Product,
            this.total_Product});
            this.dgv_GioHang.Location = new System.Drawing.Point(12, 105);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_GioHang.Size = new System.Drawing.Size(864, 338);
            this.dgv_GioHang.TabIndex = 0;
            this.dgv_GioHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GioHang_CellEndEdit);
            // 
            // name_Product
            // 
            this.name_Product.HeaderText = "Tên sản phẩm";
            this.name_Product.Name = "name_Product";
            this.name_Product.ReadOnly = true;
            this.name_Product.Width = 300;
            // 
            // amount_Product
            // 
            this.amount_Product.HeaderText = "Số lượng sản phẩm";
            this.amount_Product.Name = "amount_Product";
            this.amount_Product.Width = 250;
            // 
            // total_Product
            // 
            this.total_Product.HeaderText = "Thành tiền";
            this.total_Product.Name = "total_Product";
            this.total_Product.ReadOnly = true;
            this.total_Product.Width = 326;
            // 
            // header_Box
            // 
            this.header_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_Box.BackColor = System.Drawing.Color.OrangeRed;
            this.header_Box.Controls.Add(this.history_label);
            this.header_Box.Controls.Add(this.logo_Label);
            this.header_Box.Location = new System.Drawing.Point(12, 12);
            this.header_Box.Name = "header_Box";
            this.header_Box.Size = new System.Drawing.Size(976, 66);
            this.header_Box.TabIndex = 4;
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.Location = new System.Drawing.Point(206, 34);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(77, 16);
            this.history_label.TabIndex = 1;
            this.history_label.Text = "Lịch sử mua";
            this.history_label.Click += new System.EventHandler(this.history_label_Click);
            // 
            // logo_Label
            // 
            this.logo_Label.AutoSize = true;
            this.logo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo_Label.Location = new System.Drawing.Point(25, 19);
            this.logo_Label.Name = "logo_Label";
            this.logo_Label.Size = new System.Drawing.Size(152, 31);
            this.logo_Label.TabIndex = 0;
            this.logo_Label.Text = "Bao\'s Mart";
            this.logo_Label.Click += new System.EventHandler(this.logo_Label_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(761, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sum_Money
            // 
            this.sum_Money.AutoSize = true;
            this.sum_Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_Money.Location = new System.Drawing.Point(648, 466);
            this.sum_Money.Name = "sum_Money";
            this.sum_Money.Size = new System.Drawing.Size(98, 20);
            this.sum_Money.TabIndex = 9;
            this.sum_Money.Text = "TỔNG TIỀN:";
            // 
            // totalPayment
            // 
            this.totalPayment.AutoSize = true;
            this.totalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayment.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalPayment.Location = new System.Drawing.Point(785, 461);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(102, 25);
            this.totalPayment.TabIndex = 10;
            this.totalPayment.Text = "SỐ TIỀN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(771, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "₫";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(895, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(895, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "THÊM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formOrdered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPayment);
            this.Controls.Add(this.sum_Money);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.header_Box);
            this.Controls.Add(this.dgv_GioHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formOrdered";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bao\'s Mart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formOrdered_FormClosing);
            this.Load += new System.EventHandler(this.formOrdered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.header_Box.ResumeLayout(false);
            this.header_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.Panel header_Box;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Label logo_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sum_Money;
        private System.Windows.Forms.Label totalPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_Product;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
    }
}