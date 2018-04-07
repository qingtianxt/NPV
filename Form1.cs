using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算净现值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double touzi = Convert.ToDouble(textBox1.Text);
            double tiexianlv = Convert.ToDouble(textBox2.Text);

            double[] years = new double[5];

            years[0] = Convert.ToDouble(textBox3.Text);
            years[1] = Convert.ToDouble(textBox4.Text);
            years[2] = Convert.ToDouble(textBox5.Text);
            years[3] = Convert.ToDouble(textBox6.Text);
            years[4] = Convert.ToDouble(textBox7.Text);

            double jingxianzhi = 0;
            double  jingxianyinzi = 1;

            for(int i = 0; i < 5; i++)
            {
                jingxianyinzi /= 1+tiexianlv;
                jingxianzhi += jingxianyinzi * years[i];
                Console.WriteLine("净现因子："+jingxianyinzi+"净现值：" +jingxianzhi);
            }
            jingxianzhi -= touzi;
            textBox8.Text = jingxianzhi+"";

        }
    }
}
