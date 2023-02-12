using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{

    public partial class InserirEmpresa : Form
    {
        // Conexão com a base de dados...
        SqlConnection con = new SqlConnection("Data Source = DISI04_JC; Initial Catalog = fue_db; Integrated Security = True");
        Models.Metodos Conect;

        public InserirEmpresa()
        {
            con.Open();
            InitializeComponent();
            Conect = new Models.Metodos();
        }


        private void btnInserirEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresa_Actividades aa1 = new Empresa_Actividades();
            aa1.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fue fue = new Fue();
            fue.ShowDialog();
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            int nine = int.Parse(txtIne.Text);
            string nuit = txtNuit.Text;
            string nome = txtNome.Text;
            string abreviatura = txtAbreviatura.Text;
            string morada = txtMorada.Text;
            string cPostal = txtPostal.Text;
            string fax = txtFax.Text;
            string eMail = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string caminho = txtUrl.Text;
            string localidade = txtLocalidade.Text;
            int homens = int.Parse(txtHomens.Text);
            int mulheres = int.Parse(txtMulheres.Text);
            float lat = float.Parse(txtLat.Text);
            float longtude = float.Parse(txtLong.Text);
            float alt = float.Parse(txtAlt.Text);
            float volumeVendas = float.Parse(txtVVendas.Text);
            DateTime dataConstituicao = dtpConstituicao.Value;
            float capitalSocial = float.Parse(txtCapital.Text);
            float situação = float.Parse(txtSituacao.Text);
            float pub = float.Parse(txtPub.Text);
            float priv = float.Parse(txtPriv.Text);
            float estr = float.Parse(txtEst.Text);
            float formaJuridica = float.Parse(txtFormaJuridica.Text);
            float contaEmpresa = float.Parse(txtContaEmpresa.Text);
            float gci = float.Parse(txtGci.Text);
            float cartComercial = float.Parse(txtComercial.Text);
            DateTime dataDocumentoRecente = dtpDocumentoRecente.Value;
            float sectorInstituicional = float.Parse(txtSector.Text);
            float nrEstabelecimentos = float.Parse(txtNrEstabelecimentos.Text);
            Models.Empresa emp = new Models.Empresa(nine, nuit, nome, abreviatura, morada, cPostal, fax, eMail, telefone, caminho, localidade, homens, mulheres, lat, longtude, alt, volumeVendas, dataConstituicao, capitalSocial, situação, pub, priv, estr, formaJuridica, contaEmpresa, gci, cartComercial, dataDocumentoRecente, sectorInstituicional, nrEstabelecimentos);
            Models.Metodos mt = new Models.Metodos();
            mt.CadastrarEmpresa(emp);
            txtNome.Text = "";
            txtAbreviatura.Text = "";
            txtMorada.Text = "";
            txtPostal.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtUrl.Text = "";
            txtLocalidade.Text = "";
            txtHomens.Text = "";
            txtMulheres.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";
            txtAlt.Text = "";
            txtVVendas.Text = "";
            txtCapital.Text = "";
            txtSituacao.Text = "";
            txtContaEmpresa.Text = "";
            txtPub.Text = "";
            txtPriv.Text = "";
            txtEst.Text = "";
            dtpConstituicao.Value = dtpConstituicao.MinDate;
            dtpDocumentoRecente.Value = dtpDocumentoRecente.MinDate;
            txtFormaJuridica.Text = "";
            txtContaEmpresa.Text = "";
            txtGci.Text = "";
            txtComercial.Text = "";
            txtSector.Text = "";
        }

        private void InserirEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int nine = int.Parse(txtIne.Text);
            string nuit = txtNuit.Text;
            string nome = txtNome.Text;
            string abreviatura = txtAbreviatura.Text;
            string morada = txtMorada.Text;
            string cPostal = txtPostal.Text;
            string fax = txtFax.Text;
            string eMail = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string caminho = txtUrl.Text;
            string localidade = txtLocalidade.Text;
            int homens = int.Parse(txtHomens.Text);
            int mulheres = int.Parse(txtMulheres.Text);
            float lat = float.Parse(txtLat.Text);
            float longtude = float.Parse(txtLong.Text);
            float alt = float.Parse(txtAlt.Text);
            float volumeVendas = float.Parse(txtVVendas.Text);
            DateTime dataConstituicao = dtpConstituicao.Value;
            float capitalSocial = float.Parse(txtCapital.Text);
            float situação = float.Parse(txtSituacao.Text);
            float pub = float.Parse(txtPub.Text);
            float priv = float.Parse(txtPriv.Text);
            float estr = float.Parse(txtEst.Text);
            float formaJuridica = float.Parse(txtFormaJuridica.Text);
            float contaEmpresa = float.Parse(txtContaEmpresa.Text);
            float gci = float.Parse(txtGci.Text);
            float cartComercial = float.Parse(txtComercial.Text);
            DateTime dataDocumentoRecente = dtpDocumentoRecente.Value;
            float sectorInstituicional = float.Parse(txtSector.Text);
            float nrEstabelecimentos = float.Parse(txtNrEstabelecimentos.Text);
            Models.Empresa emp = new Models.Empresa(nine, nuit, nome, abreviatura, morada, cPostal, fax, eMail, telefone, caminho, localidade, homens, mulheres, lat, longtude, alt, volumeVendas, dataConstituicao, capitalSocial, situação, pub, priv, estr, formaJuridica, contaEmpresa, gci, cartComercial, dataDocumentoRecente, sectorInstituicional, nrEstabelecimentos);
            Models.Metodos mt = new Models.Metodos();
            mt.CadastrarEmpresa(emp);
            txtNome.Text = "";
            txtAbreviatura.Text = "";
            txtMorada.Text = "";
            txtPostal.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtUrl.Text = "";
            txtLocalidade.Text = "";
            txtHomens.Text = "";
            txtMulheres.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";
            txtAlt.Text = "";
            txtVVendas.Text = "";
            txtCapital.Text = "";
            txtSituacao.Text = "";
            txtContaEmpresa.Text = "";
            txtPub.Text = "";
            txtPriv.Text = "";
            txtEst.Text = "";
            dtpConstituicao.Value = dtpConstituicao.MinDate;
            dtpDocumentoRecente.Value = dtpDocumentoRecente.MinDate;
            txtFormaJuridica.Text = "";
            txtContaEmpresa.Text = "";
            txtGci.Text = "";
            txtComercial.Text = "";
            txtSector.Text = "";
        }

    }
}
