using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Fue : Form
    {
        public Fue()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            InserirEmpresa ie = new InserirEmpresa();
            ie.ShowDialog();
        }

        private void btnAlterarEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FueEmpresa ae = new FueEmpresa();
            ae.ShowDialog();
        }

        private void consultarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaEmpresa ce = new ConsultaEmpresa();
            ce.ShowDialog();
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarEmpresa ee = new EliminarEmpresa();
            ee.ShowDialog();
        }

        private void Fue_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsmiGestaoEmpresas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FueEmpresa ae = new FueEmpresa();
            ae.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
