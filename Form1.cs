using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1lab
{
    public partial class Form1 : Form
    {
        internal static object textbox1;
        internal static object textbox2;
        internal static object textbox5;

        public Form1()
        {
            InitializeComponent();
            zEllipse ellipse = new zEllipse();
            zRectangle rectangle = new zRectangle();
            zTriangle triangle = new zTriangle();
        }
        public void draw_elements()
        {
            picture.Image = null;
        }

           
        
       
    }
}
