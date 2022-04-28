using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganss.Excel;

namespace _20521110_TranQuocBao_TH2
{
    public partial class formOrdered : Form
    {
        public formOrdered()
        {
            InitializeComponent();
            int index = 0;

            if (ListOrdered.ordereds != null)
            {
                foreach (Ordered ordered in ListOrdered.ordereds)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgv_GioHang);
                    row.Cells[0].Value = ordered.nameProduct;
                    row.Cells[1].Value = ordered.amountProduct.ToString();
                    row.Cells[2].Value = (ordered.amountProduct * ordered.costProduct).ToString();
                    dgv_GioHang.Rows.Add(row);
                    index++;
                }
            }

            
            totalPayment.Text = ListOrdered.ThanhTien().ToString();
        }

        private void formOrdered_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cập nhật và sử lý dữ liệu vào Dữ liệu Hóa đơn
            int[,] arr = new int[ListOrdered.ordereds.Count, 2];
            for (int i = 0; i < ListOrdered.ordereds.Count; i++)
            {
                arr[i, 0] = Int32.Parse(ListOrdered.ordereds[i].idProduct);
                arr[i, 1] = ListOrdered.ordereds[i].amountProduct;
            }

            string inforProduct = ConvertAS.MatrixToString(arr);

            Recept recept = new Recept("", inforProduct,DateTime.Now.ToString());

            List<Recept> recepts = new List<Recept>();

            recepts.Add(recept);

            handleDatabase.insertRecepts(recept);

            //Cập nhật lại lịch sử mua hàng
            handleDatabase.UpdatetHistory();

            DialogResult dlr = MessageBox.Show("Thanh toán thành công, bạn có muốn xem hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dlr == DialogResult.Yes)
            {
                showRecept(recept.idRecept);
            }
            else
            {

            }           

            dgv_GioHang.Rows.Clear();
            ListOrdered.ordereds.Clear();

        }
        
        public void showRecept(string id)
        {
            formReport rc = new formReport(id);
            rc.Show();
            
        }
        string pathHistory = Application.StartupPath + "\\History.xlsx"; 

        private void formOrdered_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void logo_Label_Click(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();
            Form1.Show();
            this.Hide();
        }

        private void logo_Label_Click_1(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();
            Form1.Show();
            this.Hide();
        }

        private void dgv_GioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_GioHang != null)
                {
                    int index = 0;
                    foreach (Ordered ordered in ListOrdered.ordereds)
                    {
                        ordered.amountProduct = Int32.Parse((string)dgv_GioHang.Rows[index].Cells[1].Value);
                        dgv_GioHang.Rows[index].Cells[2].Value = ordered.amountProduct * ordered.costProduct;
                        index++;
                    }
                }
                totalPayment.Text = ListOrdered.ThanhTien().ToString();
            }
            catch
            {
                MessageBox.Show("Ô số lượng sản phẩm không được để trống, vui lòng nhập số lượng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgv_GioHang.SelectedRows.Count > 0)
            {
                int index = dgv_GioHang.SelectedRows[0].Index;
                dgv_GioHang.Rows.RemoveAt(this.dgv_GioHang.SelectedRows[0].Index);                
                ListOrdered.ordereds.Remove(ListOrdered.ordereds[index]);
            }
            totalPayment.Text = ListOrdered.ThanhTien().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();
            Form1.Show();
            this.Hide();

        }

        private void history_label_Click(object sender, EventArgs e)
        {
            formHistory history = new formHistory();

            history.Show();

            this.Hide();
        }
    }
}
