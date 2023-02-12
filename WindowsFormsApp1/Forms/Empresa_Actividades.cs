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
    public partial class Empresa_Actividades : Form
    {
        public Empresa_Actividades()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fue fue = new Fue();
            fue.ShowDialog();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fue_dbDataSet2.fue_db' table. You can move, or remove it, as needed.
            this.fue_dbTableAdapter.Fill(this.fue_dbDataSet2.fue_db);
            // TODO: This line of code loads data into the 'fue_dbDataSet.actividade' table. You can move, or remove it, as needed.
            this.actividadeTableAdapter.Fill(this.fue_dbDataSet.actividade);

        }

        
    }
}
