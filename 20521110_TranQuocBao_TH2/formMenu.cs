using Ganss.Excel;
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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            loadListView();
        }

        public List<Product> products = handleDatabase.GetProducts();

        private void loadImage()
        {
            imageList = new ImageList()
            {
                ImageSize = new Size(137, 163)
            };
            int i = 0;
            foreach(var product in products)
            {
                string path = Application.StartupPath + "\\BTTH2\\images\\img" + i.ToString()+".jpg";
                Bitmap bitmap = new Bitmap(path);
                imageList.Images.Add(bitmap);
                i++;
            }
        }

        private void loadListView()
        {
            listView.Clear();
            listView.BorderStyle = BorderStyle.None;
            loadImage();
            int index = 0;
            foreach (Product product in products)
            {
                listView.Items.Add(product.nameProduct+"\n"+"Giá:"+product.costProduct.ToString(), index);
                index++;
            }
            listView.LargeImageList = imageList;
            listView.View = View.LargeIcon;
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem list = listView.GetItemAt(e.X, e.Y);
            int index = list.ImageIndex;
            formCart formCart = new formCart(products[index],index);
            formCart.Show();
            this.Hide();
        }

        private void history_label_Click(object sender, EventArgs e)
        {
            formHistory history = new formHistory();

            history.Show();

            this.Hide();
        }

        private void seach_label_Click(object sender, EventArgs e)
        {
            formSearchRecepts rsp = new formSearchRecepts();
            rsp.Show();
            this.Hide();
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            listView.Clear();
            listView.BorderStyle = BorderStyle.None;
            loadImage();
            //int index = 0;
            foreach (Product product in products)
            {
                if(product.nameProduct.Contains(search_Box.Text))
                {
                    listView.Items.Add(product.nameProduct + "\n" + "Giá:" + product.costProduct.ToString(), Int32.Parse(product.idProduct));
                }    
            }
            listView.LargeImageList = imageList;
            listView.View = View.LargeIcon;
        }
    }   
}
