using Microsoft.Reporting.WinForms;
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
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }
        

        public formReport(string idRecept)
        {
            InitializeComponent();

            DataTable dt = handleDatabase.getReceptsFromId(idRecept);

            string ThanhTien = handleDatabase.sumRecepts(idRecept).ToString();

            //Chỉnh sửa dữ liệu của mã hóa đơn
            ReportParameter[] parames = new ReportParameter[3];

            parames[0] = new ReportParameter("MaDH", idRecept);

            parames[1] = new ReportParameter("TongTien", ThanhTien);

            parames[2] = new ReportParameter("DiaChi","0");

            reportViewer1.LocalReport.SetParameters(parames);


            //Thêm cơ sở dữ liệu
            if(dt!=null)
            {
                var reportDataSource1 = new ReportDataSource("DataSet1", dt);

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "_20521110_TranQuocBao_TH2.Report.rdlc";

                this.reportViewer1.RefreshReport();
            }
            else
            {

            }
        }

        private void formReport_Load(object sender, EventArgs e)
        {             
        }

        private void formReport_FormClosing(object sender, FormClosingEventArgs e)
        { 
        }
    }
}
