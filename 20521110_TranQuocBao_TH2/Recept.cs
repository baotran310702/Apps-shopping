using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521110_TranQuocBao_TH2
{
    public class Recept
    {
        public string idRecept { get; set; }
        public string infoProduct { get; set; }
        public string thoigian { get; set; }

        public Recept()
        {
        }

        public Recept(string idRecept,string infoProduct,string thoigian)
        {
            this.idRecept = idRecept;
            this.infoProduct=infoProduct;
            this.thoigian=thoigian;
        }
    }
}
