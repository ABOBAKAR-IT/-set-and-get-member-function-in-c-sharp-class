using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            test obj = new test();
            obj.seta(Convert.ToInt32(textBox1.Text));
            obj.setb(Convert.ToInt32(textBox2.Text));
            obj.setc(Convert.ToInt32(textBox3.Text));
            obj.setd(Convert.ToInt32(textBox4.Text));
            obj.sete(Convert.ToInt32(textBox5.Text));
            obj.setf(Convert.ToInt32(textBox6.Text));

          label1.Text="value of a= "+  obj.geta()+ "\nvalue of b= " + obj.getb()+ "\nvalue of c= " + obj.getc()+ "\nvalue of d= " + obj.getd()+ "\nvalue of e= " + obj.gete()+ "\nvalue of f= " + obj.getf();
        }
    }
}
