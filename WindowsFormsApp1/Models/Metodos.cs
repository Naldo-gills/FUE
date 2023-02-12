using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Models
{
    public class Metodos : Estatistica
    {
        // Conexão com a base de dados...
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-VGHQMQ3; Initial Catalog = fue_db; Integrated Security = True");
        SqlDataReader sdr;
        public void AlterarEmpresa(Empresa empresa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE fue_db SET nome=@nome,abreviatura=@abreviatura,morada=@morada,cPostal=@cPostal,fax=@fax,eMail=@eMail,telefone=@telefone,caminho=@caminho,localidade=@localidade,homens=@homens,mulheres=@mulheres,lat=@lat,longtude=@longtude,alt=@alt,volumeVendas=@volumeVendas,capitalSocial=@capitalSocial,situação=@situação,pub=@pub,priv=@priv,estr=@estr,formaJuridica=@formaJuridica,contaEmpresa=@contaEmpresa,gci=@gci,cartComercial=@cartComercial,sectorInstituicional=@sectorInstituicional  WHERE nine=@nine", conn);
                cmd.Parameters.AddWithValue("@nine", empresa.nine);
                cmd.Parameters.AddWithValue("@nome", empresa.nome);
                cmd.Parameters.AddWithValue("@abreviatura", empresa.abreviatura);
                cmd.Parameters.AddWithValue("@morada", empresa.morada);
                cmd.Parameters.AddWithValue("@cPostal", empresa.cPostal);
                cmd.Parameters.AddWithValue("@fax", empresa.fax);
                cmd.Parameters.AddWithValue("@eMail", empresa.eMail);
                cmd.Parameters.AddWithValue("@telefone", empresa.telefone);
                cmd.Parameters.AddWithValue("@caminho", empresa.caminho);
                cmd.Parameters.AddWithValue("@localidade", empresa.localidade);
                cmd.Parameters.AddWithValue("@homens", empresa.homens);
                cmd.Parameters.AddWithValue("@mulheres", empresa.mulheres);
                cmd.Parameters.AddWithValue("@lat", empresa.lat);
                cmd.Parameters.AddWithValue("@longtude", empresa.longtude);
                cmd.Parameters.AddWithValue("@alt", empresa.alt);
                cmd.Parameters.AddWithValue("@volumeVendas", empresa.volumeVendas);
                cmd.Parameters.AddWithValue("@capitalSocial", empresa.capitalSocial);
                cmd.Parameters.AddWithValue("@situação", empresa.situação);
                cmd.Parameters.AddWithValue("@pub", empresa.pub);
                cmd.Parameters.AddWithValue("@priv", empresa.priv);
                cmd.Parameters.AddWithValue("@estr", empresa.estr);
                cmd.Parameters.AddWithValue("@formaJuridica", empresa.formaJuridica);
                cmd.Parameters.AddWithValue("@contaEmpresa", empresa.contaEmpresa);
                cmd.Parameters.AddWithValue("@gci", empresa.gci);
                cmd.Parameters.AddWithValue("@cartComercial", empresa.cartComercial);
                cmd.Parameters.AddWithValue("@sectorInstituicional", empresa.sectorInstituicional);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Saved");
            }
            catch
            {
                MessageBox.Show("Ocorreu ERRO durante a digitação, verifique os dados a serem gravados");
            }

        }
        public Metodos() {
            conn.Open();
  
        }
        public void CadastrarEmpresa(Empresa empresa)
        {
            //db
            try
            {

                SqlCommand cmd = new SqlCommand("insert into fue_db values('" + empresa.nine + "','" + empresa.nuit + "','" + empresa.nome + "','" + empresa.abreviatura + "','"
                    + empresa.morada + "','" +
                    empresa.cPostal + "','" + empresa.fax + "','" + empresa.eMail + "','" + empresa.telefone + "','" + empresa.caminho + "','" + empresa.localidade + "','" + empresa.homens + "','" +
                    empresa.mulheres + "','" + empresa.lat + "','" + empresa.longtude + "','" + empresa.alt + "','" + empresa.volumeVendas + "','" + null + "','" + empresa.capitalSocial + "','" +
                    empresa.situação + "','" + empresa.pub + "','" + empresa.priv + "','" + empresa.estr + "','" + empresa.formaJuridica + "','" +
                    empresa.contaEmpresa + "','" + empresa.gci + "','" + empresa.cartComercial + "','" + null + "','" + empresa.sectorInstituicional+"','" + empresa.nrEstabelecimentos + "' )", conn);
                  cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Ocorreu ERRO durante a digitação, verifique os dados a serem gravados");
            }


        }

        public void ConsultarEmpresa(Empresa empresa)
        {
            
        }

        public void EliminarEmpresa(int nine)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM fue_db WHERE nine=@nine",conn);
            cmd.Parameters.AddWithValue("@nine", nine);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void ListarEmpresa(Empresa empresa)
        {
         
           }

        public void ListarEstabelecimentos(Empresa empresa)
        {
          
        }

        public void ListarPorNivelNacional(Empresa empresa)
        {
            
        }

        public void VerificarMaiorEmpresa(Empresa empresa)
        {
            
        }
        /*public void PesquisarPorNine(Empresa empresa) {
            Forms.AlterarEmpresa ae = new Forms.AlterarEmpresa();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select nine From fue_db where nine=@empresa.nine",conn);
            cmd.Parameters.AddWithValue("@empresa.nine",empresa.nine);
            cmd.Connection = conn;
            sdr = cmd.ExecuteReader();
            bool temp = false;
            while (sdr.Read())
            {
                temp = true;
                empresa.nome = sdr.GetValue(2).ToString();
            }
            if (temp == false) 
            {
                MessageBox.Show("Not Found");
            }
                      
            
            conn.Close();
        }*/
    }
}
