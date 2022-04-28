using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521110_TranQuocBao_TH2
{
    public class ConvertAS
    {
        public static string MatrixToString(int[,] arr)
        {
            string s = "";

            int length1 = arr.GetLength(0);//Lấy ra chiều ngang của mảng

            int n = arr.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                s += "{" + arr[i, 0].ToString() + "," + arr[i, 1].ToString() + "}";
                s += ",";
            }

            s = "{" + s.Substring(0, s.Length - 1) + "}";

            return s;
        }

        public static int[,] StringToMatrix(string s)
        {
            s = s.Remove(0, 1);
            string s2 = s.Remove(s.Length - 2, 1);

            string[] result = s2.Split('}');

            int[,] arr = new int[result.Length - 1, 2];

            arr[0, 0] = result[0][1] - '0';
            arr[0, 1] = result[0][3] - '0';

            for (int i = 1; i < result.Length - 1; i++)
            {

                string s_now = result[i];

                string[] result_arr = result[i].Split(',');

                arr[i, 0] = Int32.Parse(result_arr[1].Remove(0, 1));

                arr[i, 1] = Int32.Parse(result_arr[2]);


            }

            return arr;
        }
    }
}
