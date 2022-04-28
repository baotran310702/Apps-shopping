namespace _20521110_TranQuocBao_TH2
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.header_Box = new System.Windows.Forms.Panel();
            this.seach_label = new System.Windows.Forms.Label();
            this.cart_Box = new System.Windows.Forms.PictureBox();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.history_label = new System.Windows.Forms.Label();
            this.logo_Label = new System.Windows.Forms.Label();
            this.header_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BackColor = System.Drawing.SystemColors.Control;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(37, 94);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(946, 374);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ánh nhóm.png");
            // 
            // header_Box
            // 
            this.header_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_Box.BackColor = System.Drawing.Color.OrangeRed;
            this.header_Box.Controls.Add(this.seach_label);
            this.header_Box.Controls.Add(this.cart_Box);
            this.header_Box.Controls.Add(this.search_Box);
            this.header_Box.Controls.Add(this.history_label);
            this.header_Box.Controls.Add(this.logo_Label);
            this.header_Box.Location = new System.Drawing.Point(12, 12);
            this.header_Box.Name = "header_Box";
            this.header_Box.Size = new System.Drawing.Size(976, 66);
            this.header_Box.TabIndex = 2;
            // 
            // seach_label
            // 
            this.seach_label.AutoSize = true;
            this.seach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seach_label.Location = new System.Drawing.Point(287, 32);
            this.seach_label.Name = "seach_label";
            this.seach_label.Size = new System.Drawing.Size(111, 16);
            this.seach_label.TabIndex = 4;
            this.seach_label.Text = "Tra cứu đơn hàng";
            this.seach_label.Click += new System.EventHandler(this.seach_label_Click);
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
            // search_Box
            // 
            this.search_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Box.Location = new System.Drawing.Point(667, 27);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(197, 20);
            this.search_Box.TabIndex = 2;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
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
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 480);
            this.Controls.Add(this.header_Box);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bao\'s Mart";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.header_Box.ResumeLayout(false);
            this.header_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel header_Box;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Label logo_Label;
        private System.Windows.Forms.PictureBox cart_Box;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Label seach_label;
    }
}

