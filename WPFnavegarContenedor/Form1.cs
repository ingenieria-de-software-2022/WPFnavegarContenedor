using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFnavegarContenedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGraphic_Click(object sender, EventArgs e)
        {
            double y;

            for (int x = 0; x <= 100; x++)
            {
                y = Math.Cos(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
        }
    }
}
