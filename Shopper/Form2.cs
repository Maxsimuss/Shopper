using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopper
{
    public partial class Form2 : Form
    {
        public Form1 Parent = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void PievienotBtn_Click(object sender, EventArgs e)
        {
            Parent.AddProduct(NosaukumsFld.Text, (double)CenaNum.Value);
        }
    }
}
