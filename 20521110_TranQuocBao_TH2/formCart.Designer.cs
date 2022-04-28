namespace _20521110_TranQuocBao_TH2
{
    partial class formCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCart));
            this.header_Box = new System.Windows.Forms.Panel();
            this.cart_Box = new System.Windows.Forms.PictureBox();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.history_label = new System.Windows.Forms.Label();
            this.logo_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_Product = new System.Windows.Forms.Label();
            this.cost_Product = new System.Windows.Forms.Label();
            this.box_soLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amoun_Product = new System.Windows.Forms.Label();
            this.amount_Product = new System.Windows.Forms.Label();
            this.addCart_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.header_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_soLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // header_Box
            // 
            this.header_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_Box.BackColor = System.Drawing.Color.OrangeRed;
            this.header_Box.Controls.Add(this.cart_Box);
            this.header_Box.Controls.Add(this.search_Box);
            this.header_Box.Controls.Add(this.history_label);
            this.header_Box.Controls.Add(this.logo_Label);
            this.header_Box.Location = new System.Drawing.Point(12, 12);
            this.header_Box.Name = "header_Box";
            this.header_Box.Size = new System.Drawing.Size(976, 66);
            this.header_Box.TabIndex = 3;
            // 
            // cart_Box
            // 
            this.cart_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cart_Box.Image = ((System.Drawing.Image)(resources.GetObject("cart_Box.Image")));
            this.cart_Box.Location = new System.Drawing.Point(896, 3);
            this.cart_Box.Name = "cart_Box";
            this.cart_Box.Size = new System.Drawing.Size(62, 47);
            this.cart_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cart_Box.TabIndex = 3;
            this.cart_Box.TabStop = false;
            this.cart_Box.Click += new System.EventHandler(this.cart_Box_Click);
            // 
            // search_Box
            // 
            this.search_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Box.Location = new System.Drawing.Point(667, 27);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(197, 20);
            this.search_Box.TabIndex = 2;
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.Location = new System.Drawing.Point(186, 32);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(77, 16);
            this.history_label.TabIndex = 1;
            this.history_label.Text = "Lịch sử mua";
            // 
            // logo_Label
            // 
            this.logo_Label.AutoSize = true;
            this.logo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo_Label.Location = new System.Drawing.Point(25, 19);
            this.logo_Label.Name = "logo_Label";
            this.logo_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logo_Label.Size = new System.Drawing.Size(152, 31);
            this.logo_Label.TabIndex = 0;
            this.logo_Label.Text = "Bao\'s Mart";
            this.logo_Label.Click += new System.EventHandler(this.logo_Label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // name_Product
            // 
            this.name_Product.AutoSize = true;
            this.name_Product.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Product.Location = new System.Drawing.Point(383, 100);
            this.name_Product.Name = "name_Product";
            this.name_Product.Size = new System.Drawing.Size(150, 28);
            this.name_Product.TabIndex = 5;
            this.name_Product.Text = "tên sản phẩm";
            // 
            // cost_Product
            // 
            this.cost_Product.AutoSize = true;
            this.cost_Product.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_Product.ForeColor = System.Drawing.Color.OrangeRed;
            this.cost_Product.Location = new System.Drawing.Point(452, 160);
            this.cost_Product.Name = "cost_Product";
            this.cost_Product.Size = new System.Drawing.Size(64, 41);
            this.cost_Product.TabIndex = 6;
            this.cost_Product.Text = "giá";
            // 
            // box_soLuong
            // 
            this.box_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_soLuong.Location = new System.Drawing.Point(473, 255);
            this.box_soLuong.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.box_soLuong.Name = "box_soLuong";
            this.box_soLuong.Size = new System.Drawing.Size(61, 26);
            this.box_soLuong.TabIndex = 7;
            this.box_soLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.box_soLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(437, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "₫";
            // 
            // amoun_Product
            // 
            this.amoun_Product.AutoSize = true;
            this.amoun_Product.Location = new System.Drawing.Point(588, 262);
            this.amoun_Product.Name = "amoun_Product";
            this.amoun_Product.Size = new System.Drawing.Size(91, 13);
            this.amoun_Product.TabIndex = 10;
            this.amoun_Product.Text = "sản phẩm có sẵn.";
            // 
            // amount_Product
            // 
            this.amount_Product.AutoSize = true;
            this.amount_Product.Location = new System.Drawing.Point(547, 262);
            this.amount_Product.Name = "amount_Product";
            this.amount_Product.Size = new System.Drawing.Size(35, 13);
            this.amount_Product.TabIndex = 11;
            this.amount_Product.Text = "label3";
            // 
            // addCart_btn
            // 
            this.addCart_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.addCart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCart_btn.ForeColor = System.Drawing.Color.White;
            this.addCart_btn.Location = new System.Drawing.Point(385, 390);
            this.addCart_btn.Name = "addCart_btn";
            this.addCart_btn.Size = new System.Drawing.Size(284, 45);
            this.addCart_btn.TabIndex = 12;
            this.addCart_btn.Text = "Thêm vào giỏ hàng";
            this.addCart_btn.UseVisualStyleBackColor = false;
            this.addCart_btn.Click += new System.EventHandler(this.addCart_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giá:";
            // 
            // formCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCart_btn);
            this.Controls.Add(this.amount_Product);
            this.Controls.Add(this.amoun_Product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_soLuong);
            this.Controls.Add(this.cost_Product);
            this.Controls.Add(this.name_Product);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bao\'s Mart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCart_FormClosing);
            this.header_Box.ResumeLayout(false);
            this.header_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_soLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_Box;
        private System.Windows.Forms.PictureBox cart_Box;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Label logo_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_Product;
        private System.Windows.Forms.Label cost_Product;
        private System.Windows.Forms.NumericUpDown box_soLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amoun_Product;
        private System.Windows.Forms.Label amount_Product;
        private System.Windows.Forms.Button addCart_btn;
        private System.Windows.Forms.Label label3;
    }
}