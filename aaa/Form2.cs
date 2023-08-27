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
    public partial class Form2 : Form
    {
        public Form2(string t)
        {
            InitializeComponent();
            label1.Text = t;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
