using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Empresa
    {
        public int nine { get; set; }
        public string nuit { get; set; }
        public string nome { get; set; }
        public string abreviatura { get; set; } 
        public string morada { get; set; }
        public string cPostal { get; set; }
        public string fax { get; set; }
        public string eMail { get; set; }
        public string telefone { get; set; }
        public string caminho { get; set; }
        public string localidade { get; set; }
        public int homens { get; set; } 
        public int mulheres { get; set; }
        public float lat { get; set; } 
        public float longtude { get; set; } 
        public float alt { get; set; }
        public float volumeVendas { get; set; }
        public DateTime dataConstituicao { get; set; }
        public float capitalSocial { get; set; }
        public float situação { get; set; }
        public float pub { get; set; }
        public float priv { get; set; } 
        public float estr { get; set; }
        public float formaJuridica { get; set; }
        public float contaEmpresa { get; set; }
        public float gci { get; set; }
        public float cartComercial { get; set; }
        public DateTime dataDocumentoRecente { get; set; }
        public float sectorInstituicional { get; set; }
        public float nrEstabelecimentos;

        public Empresa() 
        { 
        }
        public Empresa(int nine, string nuit, string nome, string abreviatura, string morada, string cPostal, string fax, string eMail, string telefone, string caminho, string localidade, int homens, int mulheres, float lat, float longtude, float alt, float volumeVendas, DateTime dataConstituicao, float capitalSocial, float situação, float pub, float priv, float estr, float formaJuridica, float contaEmpresa, float gci, float cartComercial, DateTime dataDocumentoRecente, float sectorInstituicional, float nrEstabelecimentos)
        {
            this.nine = nine;
            this.nuit = nuit;
            this.nome = nome;
            this.abreviatura = abreviatura;
            this.morada = morada;
            this.cPostal = cPostal;
            this.fax = fax;
            this.eMail = eMail;
            this.telefone = telefone;
            this.caminho = caminho;
            this.localidade = localidade;
            this.homens = homens;
            this.mulheres = mulheres;
            this.lat = lat;
            this.longtude = longtude;
            this.alt = alt;
            this.volumeVendas = volumeVendas;
            this.dataConstituicao = dataConstituicao;
            this.capitalSocial = capitalSocial;
            this.situação = situação;
            this.pub = pub;
            this.priv = priv;
            this.estr = estr;
            this.formaJuridica = formaJuridica;
            this.contaEmpresa = contaEmpresa;
            this.gci = gci;
            this.cartComercial = cartComercial;
            this.dataDocumentoRecente = dataDocumentoRecente;
            this.sectorInstituicional = sectorInstituicional;
            this.nrEstabelecimentos = nrEstabelecimentos;
        }
    }
}
