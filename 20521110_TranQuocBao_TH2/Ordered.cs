using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521110_TranQuocBao_TH2
{
    public class Ordered
    {
        public string idProduct { get; set; }
        public string nameProduct { get; set; }
        public int amountProduct { get; set; }
        public int costProduct { get; set; }
        public string thoigian { get; set; }

        public Ordered() { }

        public Ordered(string idProduct,string nameProduct,string amountProduct,string costProduct,string thoigian)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.amountProduct = Int32.Parse(amountProduct);
            this.costProduct = Int32.Parse(costProduct);
            this.thoigian = thoigian;
        }


    }
}
