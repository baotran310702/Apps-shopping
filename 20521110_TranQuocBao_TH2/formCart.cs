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
    public partial class formCart : Form
    {
        public formCart()
        {
            InitializeComponent();
        }

        Product dataReceived = new Product();

        public formCart(Product product,int i)
        {
            InitializeComponent();
            dataReceived = product;
            name_Product.Text = product.nameProduct;
            cost_Product.Text=product.costProduct;
            amount_Product.Text=product.amountProduct;
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\BTTH2\\images\\img" + i.ToString() + ".jpg");

        }


        private void addCart_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string SoLuong = box_soLuong.Value.ToString();

                int SoLuong_input = Int32.Parse(SoLuong);

                if (SoLuong_input <= Int32.Parse(dataReceived.amountProduct)) {
                    Ordered oreder = new Ordered(dataReceived.idProduct, dataReceived.nameProduct, SoLuong, dataReceived.costProduct, DateTime.Now.ToString()) ;
                    int flag = 1;
                    if (ListOrdered.ordereds != null)
                    {
                        foreach (Ordered o in ListOrdered.ordereds)
                        {
                            if (o.idProduct == oreder.idProduct)
                            {
                                o.amountProduct += Int32.Parse(SoLuong);
                                flag = 0;
                            }
                        }
                    }
                    if (flag == 1)
                    {
                        ListOrdered.ordereds.Add(oreder);
                    }
                    MessageBox.Show("Thêm thành công " + SoLuong.ToString() + " sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    handleDatabase.UpdateAmount(SoLuong_input, dataReceived.idProduct);
                }      
                else
                {
                    MessageBox.Show("Thêm thất bại, số lượng hàng trong kho không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cart_Box_Click(object sender, EventArgs e)
        {
            formOrdered FormOrdered = new formOrdered();
            FormOrdered.Show();
            this.Hide();
        }

        private void logo_Label_Click(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();

            Form1.Show();

            this.Hide();
        }

        private void formCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
    }
}
