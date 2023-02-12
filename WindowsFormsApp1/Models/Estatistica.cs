using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    interface Estatistica
    {
        void CadastrarEmpresa(Empresa empresa);
        void AlterarEmpresa(Empresa empresa);
        void ConsultarEmpresa(Empresa empresa);
        void ListarEmpresa(Empresa empresa);
        void ListarEstabelecimentos(Empresa empresa);
        void ListarPorNivelNacional(Empresa empresa);
        void VerificarMaiorEmpresa(Empresa empresa);
        void EliminarEmpresa(int nine);
    }
}
