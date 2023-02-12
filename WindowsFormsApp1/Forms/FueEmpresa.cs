using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FueEmpresa : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DISI04_JC; Initial Catalog = fue_db; Integrated Security = True");
        SqlDataReader sdr;
        public FueEmpresa()
        {
            InitializeComponent();
        }

        private void btnActividadeEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresa_Actividades aa = new Empresa_Actividades();
            aa.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fue fue = new Fue();
            fue.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNine.Text!="") {
               // 
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int nine = int.Parse(txtNine.Text);
            string nuit = txtNuit.Text;
            string nome = txtNome.Text;
            string abreviatura = txtAbreviatura.Text;
            string morada = txtMorada.Text;
            string cPostal = txtCPostal.Text;
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
            Models.Empresa emp = new Models.Empresa(nine, nuit, nome, abreviatura, morada, cPostal, fax, eMail, telefone, caminho, localidade, homens, mulheres, lat, longtude, alt, volumeVendas, dataConstituicao, capitalSocial, situação, pub, priv, estr, formaJuridica, contaEmpresa, gci, cartComercial, dataDocumentoRecente, sectorInstituicional,nrEstabelecimentos);
            //MessageBox.Show(""+emp.nine);
            Models.Metodos mt = new Models.Metodos();
            mt.AlterarEmpresa(emp);
            
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
                Forms.FueEmpresa ae = new Forms.FueEmpresa();
                conn.Open();
            if (ae.txtNine.Text!=" ")
            {
                SqlCommand cmd = new SqlCommand("select * From fue_db where nine=@nine", conn);
                cmd.Parameters.AddWithValue("@nine", int.Parse(txtNine.Text));
                //cmd.Connection = conn;
                sdr = cmd.ExecuteReader();
                bool temp = false;
                while (sdr.Read())
                {
                    txtNuit.Text = sdr.GetValue(1).ToString();
                    txtNome.Text = sdr.GetValue(2).ToString();
                    txtAbreviatura.Text = sdr.GetValue(3).ToString();
                    txtMorada.Text = sdr.GetValue(4).ToString();
                    txtCPostal.Text = sdr.GetValue(5).ToString();
                    txtFax.Text = sdr.GetValue(6).ToString();
                    txtEmail.Text = sdr.GetValue(7).ToString();
                    txtTelefone.Text = sdr.GetValue(8).ToString();
                    txtUrl.Text = sdr.GetValue(9).ToString();
                    txtLocalidade.Text = sdr.GetValue(10).ToString();
                    txtHomens.Text = sdr.GetValue(11).ToString();
                    txtMulheres.Text = sdr.GetValue(12).ToString();
                    txtLat.Text = sdr.GetValue(13).ToString();
                    txtLong.Text = sdr.GetValue(14).ToString();
                    txtAlt.Text = sdr.GetValue(15).ToString();

                    txtVVendas.Text = sdr.GetValue(16).ToString();
                    txtCapital.Text = sdr.GetValue(18).ToString();
                    txtSituacao.Text = sdr.GetValue(19).ToString();
                    txtPriv.Text = sdr.GetValue(20).ToString();
                    txtPub.Text = sdr.GetValue(21).ToString();
                    txtEst.Text = sdr.GetValue(22).ToString();
                    txtFormaJuridica.Text = sdr.GetValue(23).ToString();
                    txtContaEmpresa.Text = sdr.GetValue(24).ToString();
                    txtGci.Text = sdr.GetValue(25).ToString();
                    txtComercial.Text = sdr.GetValue(26).ToString();
                    txtSector.Text = sdr.GetValue(28).ToString();
                    //txtNrEstabelecimentos.Text = sdr.GetValue(21).ToString();


                    temp = true;

                }
                if (temp == false)
                {
                    MessageBox.Show("Not Found");
                }


                conn.Close();
            }

        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            
            try{
                int nine = int.Parse(txtNine.Text);
                string nuit = txtNuit.Text;
                string nome = txtNome.Text;
                string abreviatura = txtAbreviatura.Text;
                string morada = txtMorada.Text;
                string cPostal = txtCPostal.Text;
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
                MessageBox.Show("Operação feita com sucesso!");
            }
            catch
            {
                MessageBox.Show("Ocorreu ERRO durante a digitação, verifique os dados a serem gravados");
            }
        }

        private void FueEmpresa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //try
            //{
                int nine = int.Parse(txtNine.Text);
                Models.Metodos mt = new Models.Metodos();
                mt.EliminarEmpresa(nine);
                MessageBox.Show("Eliminado com sucesso");
            //}
            //catch
            //{
              //  MessageBox.Show("Ocorreu Algum erro");
           // }
        }
    }
}
