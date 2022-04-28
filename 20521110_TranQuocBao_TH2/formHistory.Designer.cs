namespace _20521110_TranQuocBao_TH2
{
    partial class formHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHistory));
            this.header_Box = new System.Windows.Forms.Panel();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.history_label = new System.Windows.Forms.Label();
            this.logo_Label = new System.Windows.Forms.Label();
            this.label_history = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.header_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // header_Box
            // 
            this.header_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_Box.BackColor = System.Drawing.Color.OrangeRed;
            this.header_Box.Controls.Add(this.search_Box);
            this.header_Box.Controls.Add(this.history_label);
            this.header_Box.Controls.Add(this.logo_Label);
            this.header_Box.Location = new System.Drawing.Point(12, 12);
            this.header_Box.Name = "header_Box";
            this.header_Box.Size = new System.Drawing.Size(976, 66);
            this.header_Box.TabIndex = 4;
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
            // label_history
            // 
            this.label_history.AutoSize = true;
            this.label_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_history.Location = new System.Drawing.Point(12, 98);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(224, 25);
            this.label_history.TabIndex = 5;
            this.label_history.Text = "LỊCH SỬ ĐẶT HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(630, 309);
            this.dataGridView1.TabIndex = 6;
            // 
            // formHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_history);
            this.Controls.Add(this.header_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bao\'s Mart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formHistory_FormClosing);
            this.Load += new System.EventHandler(this.formHistory_Load);
            this.header_Box.ResumeLayout(false);
            this.header_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel header_Box;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Label logo_Label;
        private System.Windows.Forms.Label label_history;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}