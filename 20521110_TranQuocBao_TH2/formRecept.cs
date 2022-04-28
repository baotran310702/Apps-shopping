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
    public partial class formRecept : Form
    {
        public formRecept()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Mã Hóa đơn không được để trống");
            }
            else
            {
                List<Recept> recepts = handleDatabase.GetRecepts();

                int flag = 0;
                foreach(Recept recept in recepts)
                {
                    if(recept.idRecept ==textBox1.Text)
                    {
                        flag = 1;
                    }
                }
                if(flag==0)
                {
                    MessageBox.Show("Mã đơn hàng không tồn tại");
                }
            }
        }

        private void logo_Label_Click(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();
            Form1.Show();
            this.Hide();
        }
    }
}
