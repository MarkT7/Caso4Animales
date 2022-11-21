using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalesLibreria;

namespace Caso_4_Animales
{
    public partial class Form1 : Form
    {
        Conejo conejo1 = null;
        Leon leon1 = null;
        Loro loro1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            conejo1 = new Conejo(12,15,12,11);
            leon1 = new Leon(20,3,23,43);
            loro1 = new Loro("Mañanitas",1,4,5);
        }

        private void btnLoroImp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(loro1.ImprimirComida());
        }

        private void btnConejoImp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conejo1.ImprimirComida());
        }

        private void btnLeonImp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(leon1.ImprimirComida());
        }
    }
}
