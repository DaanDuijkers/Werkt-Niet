using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSopdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string var1 = " Dit is een string";
            string var2 = " En dit is een kleine string";
            string var3 = " En dit is geen string";
            string var4 = " 6,67";
            double var5 = 10.330;
            double var6 = 20.000;
            string var7 = "5.12345";
            double var8 = Convert.ToDouble(var7) + var6;

            lbl1.Text = lbl1.Text + var1 + var2;
            lbl2.Text = lbl2.Text + var1 + var2 + var3;
            lbl3.Text = lbl3.Text + var4 + var5;
            lbl4.Text = lbl4.Text + var5 + var6;
            lbl5.Text = lbl5.Text + var5 + var6 + var7;
            lbl6.Text = lbl6.Text + var5 * var6;
            lbl7.Text = lbl7.Text + var6 * Convert.ToDouble(var7);
            lbl8.Text = lbl8.Text + var1 * var2;
        }
    }
}
