using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20521110_TranQuocBao_TH2
{
    public partial class formHistory : Form
    {
        public formHistory()
        {
            InitializeComponent();
            dataGridView1.DataSource = handleDatabase.getHistory();
            dataGridView1.Columns[0].HeaderText = "ID SẢN PHẨM";
            dataGridView1.Columns[1].HeaderText = "TÊN SẢN PHẨM";
            dataGridView1.Columns[2].HeaderText = "SỐ LƯỢNG";
            dataGridView1.Columns[3].HeaderText = "THÀNH TIỀN";
        }

        private void logo_Label_Click(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();

            Form1.Show();

            this.Hide();
        }

        private void formHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void formHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
    }
}
