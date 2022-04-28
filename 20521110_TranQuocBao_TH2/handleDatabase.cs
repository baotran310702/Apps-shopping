using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ganss.Excel;
using System.Data;

namespace _20521110_TranQuocBao_TH2
{
    public class handleDatabase
    {
        private static string pathRecepts = Directory.GetCurrentDirectory() + "\\Recepts.xlsx";

        private static string pathData = Directory.GetCurrentDirectory() + "\\Data.xlsx";

        private static string pathHistory = Directory.GetCurrentDirectory() + "\\History.xlsx";

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            products = new ExcelMapper(pathData).Fetch<Product>().ToList();

            return products;
        }

        public static List<Recept> GetRecepts()
        {
            List<Recept> histories = new List<Recept>();

            histories = new ExcelMapper(pathRecepts).Fetch<Recept>().ToList();

            return histories;
        }

        public static void insertData(Product p)
        {
            var excel1 = new ExcelMapper();

            List<Product> pro = new List<Product>();

            pro.Add(p);

            excel1.Save(pathData, pro);
        }

        public static void insertRecepts(Recept r)
        {
            var excel = new ExcelMapper();

            List<Recept> recepts = GetRecepts();

            if(recepts!=null)
            {
                if(recepts.Count==0)
                {
                    r.idRecept = "1";
                }
                else
                {
                    r.idRecept = (Int32.Parse(recepts[recepts.Count - 1].idRecept) + 1).ToString();
                }
            }

            recepts.Add(r);

            excel.Save(pathRecepts, recepts);
        }

        public static void UpdatetHistory()
        {
            var excel = new ExcelMapper();

            List<Ordered> oldData = getHistory();

            foreach(Ordered ordered in ListOrdered.ordereds)
            {
                oldData.Add(ordered);
            }

            excel.Save(pathHistory, oldData);
        }

        public static List<Ordered> getHistory()
        {
            List<Ordered> history = new List<Ordered>();

            history = new ExcelMapper(pathHistory).Fetch<Ordered>().ToList();

            return history;
        }

        public static void UpdateAmount(int amount,string idProduct)
        {
            List<Product> products = new List<Product>();

            products = GetProducts();

            var excel = new ExcelMapper();

            foreach(Product product in products)
            {
                if(product.idProduct == idProduct)
                {
                    int num = Int32.Parse(product.amountProduct);

                    num -= amount;

                    product.amountProduct = num.ToString();
                }
            }

            excel.Save(pathData,products);


        }


        public static Product getProduct(string idP)
        {
            Product result = new Product();
            List<Product> products = GetProducts();

            foreach(var product in products)
            {
                if(product.idProduct == idP)
                {
                    result = product;
                }
            }

            return result;
        }

        public static Product productFromID(string id)
        {
            Product result = new Product();

            foreach(Product product in GetProducts())
            {
                if(product.idProduct==id)
                {
                    result = product;
                    return result;
                }
            }

            return result;
        }

        public static DataTable getReceptsFromId(string id)
        {
            DataTable dt = new DataTable();

            //dt.Columns.Add("MaHD", typeof(string));
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SoLuong", typeof(string));
            dt.Columns.Add("ThanhTien", typeof(string));
            dt.Columns.Add("ThoiGian", typeof(string));

            string[] result = new string[5];

            List<Product> products = new List<Product>();

            List<Recept> recepts = GetRecepts();

            Recept data = new Recept();

            foreach(Recept recept in recepts)
            {
                if(recept.idRecept==id)
                {
                    data = recept;
                }
            }

            if(data!=null)
            {
                int[,] arr = ConvertAS.StringToMatrix(data.infoProduct);
                
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    string index = arr[i, 0].ToString();
                    Product p = handleDatabase.productFromID(index);
                    products.Add(p);
                }

                for(int i=0;i<products.Count;i++)
                {
                    dt.Rows.Add(products[i].idProduct, products[i].nameProduct, arr[i, 1].ToString(), (arr[i, 1] * Int32.Parse(products[i].costProduct)).ToString(),data.thoigian) ;
                }
            }
            else
            {
                return null;
            }
            
            return dt;
        }

        public static int sumRecepts(string id)
        {
            int sum = 0;

            string[] result = new string[4];

            List<Product> products = new List<Product>();

            List<Recept> recepts = GetRecepts();

            Recept data = new Recept();

            foreach (Recept recept in recepts)
            {
                if (recept.idRecept == id)
                {
                    data = recept;
                }
            }

            if (data != null)
            {
                int[,] arr = ConvertAS.StringToMatrix(data.infoProduct);

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    string index = arr[i, 0].ToString();
                    Product p = handleDatabase.productFromID(index);
                    products.Add(p);
                }

                for (int i = 0; i < products.Count; i++)
                {
                    int price = Int32.Parse(products[i].costProduct);

                    sum += arr[i, 1] * price;
                }
            }

            return sum;
        }
    }
}