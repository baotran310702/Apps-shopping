using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521110_TranQuocBao_TH2
{
    public static class ListOrdered
    {
        public static List<Ordered> ordereds = new List<Ordered>();
        
        public static int ThanhTien()
        {
            int result = 0;
            foreach (Ordered ordered in ordereds)
            {
                result += ordered.costProduct * ordered.amountProduct;
            }
            return result;
        }

        public static void Clear()
        {
            ordereds.Clear();
        }

    }
}
