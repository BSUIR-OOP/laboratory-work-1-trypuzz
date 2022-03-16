using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1lab
{
    internal class zTriangle
    {
        public static void Param(Form1 form)
        {
            //string s1 = Form1.textbox5.ToString();
            string[] param = Form1.textbox5.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[param.Length];
            for (int i = 0; i < param.Length; i++)
                arr[i] = int.Parse(param[i]);
            if ((arr[0] != null) && (arr[1] != null))
            {
                int f_side = arr[0];
                int s_side = arr[1];
            }

    }
}
