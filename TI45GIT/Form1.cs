using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI45GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            //text é onde eu coloco o nome para ficar na tela
            var1 = int.Parse(tbValor1.Text);
            var2 = int.Parse(tbValor2.Text);

            total = var1 + var2;

            //resultado na tela
            lbResultado.Text = total.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(tbValor1.Text);
            var2 = int.Parse(tbValor2.Text);

            total = var1 - var2;

            lbResultado.Text = total.ToString();
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(tbValor1.Text);
            var2 = int.Parse(tbValor2.Text);

            total = var1 * var2;

            lbResultado.Text = total.ToString();
        }
    }
}
