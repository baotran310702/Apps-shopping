namespace _20521110_TranQuocBao_TH2
{
    partial class formSearchRecepts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSearchRecepts));
            this.header_Box = new System.Windows.Forms.Panel();
            this.tracuu_label = new System.Windows.Forms.Label();
            this.cart_Box = new System.Windows.Forms.PictureBox();
            this.logo_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.header_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header_Box
            // 
            this.header_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_Box.BackColor = System.Drawing.Color.OrangeRed;
            this.header_Box.Controls.Add(this.tracuu_label);
            this.header_Box.Controls.Add(this.cart_Box);
            this.header_Box.Controls.Add(this.logo_Label);
            this.header_Box.Location = new System.Drawing.Point(12, 12);
            this.header_Box.Name = "header_Box";
            this.header_Box.Size = new System.Drawing.Size(976, 66);
            this.header_Box.TabIndex = 4;
            // 
            // tracuu_label
            // 
            this.tracuu_label.AutoSize = true;
            this.tracuu_label.Location = new System.Drawing.Point(244, 36);
            this.tracuu_label.Name = "tracuu_label";
            this.tracuu_label.Size = new System.Drawing.Size(116, 13);
            this.tracuu_label.TabIndex = 4;
            this.tracuu_label.Text = "TRA CỨU ĐƠN HÀNG";
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
            // 
            // logo_Label
            // 
            this.logo_Label.AutoSize = true;
            this.logo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo_Label.Location = new System.Drawing.Point(25, 15);
            this.logo_Label.Name = "logo_Label";
            this.logo_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logo_Label.Size = new System.Drawing.Size(152, 31);
            this.logo_Label.TabIndex = 0;
            this.logo_Label.Text = "Bao\'s Mart";
            this.logo_Label.Click += new System.EventHandler(this.logo_Label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(565, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 139);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Scan QRCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐƯA QRCODE HÓA ĐƠN CỦA BẠN VÀO ĐÂY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "NHẬP MÃ ĐƠN HÀNG MUỐN TÌM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formSearchRecepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSearchRecepts";
            this.Text = "formSearchRecepts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSearchRecepts_FormClosing);
            this.Load += new System.EventHandler(this.formSearchRecepts_Load);
            this.header_Box.ResumeLayout(false);
            this.header_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_Box;
        private System.Windows.Forms.PictureBox cart_Box;
        private System.Windows.Forms.Label logo_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tracuu_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}