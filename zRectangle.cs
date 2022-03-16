using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1lab
{
    public class zRectangle
    {
        public static void Param(Form1 form)
        {
            string s1 = Form1.textbox1.ToString();
            string s2 = Form1.textbox2.ToString();
            int width = int.Parse(s1);
            int height = int.Parse(s2);
        }
      
    }
}
