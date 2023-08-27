using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaa
{
    public partial class Form1 : Form
    {
        string textodigit;
        string fim;
        int n1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(fim);
            form2.ShowDialog();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1++;
            textodigit = nomes.Text;
            fim += "\n" + n1 + "." + textodigit;
            nomes.Text = "";
            nomes.Focus();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fim = "";
            nomes.Text = "";
            nomes.Focus();
        }
    }
}
