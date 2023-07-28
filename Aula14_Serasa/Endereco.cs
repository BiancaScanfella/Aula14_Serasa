using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_Serasa
{
    internal class Endereco
    {
        private string rua;
        private string bairro;
        private string cidade;

        public Endereco (string rua, string bairro, string cidade)
        {
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public void mostra() 
        {
            Console.WriteLine($"Eu moro na {rua}, do bairro {bairro} e da cidade de {cidade}");
        }
    }
}
