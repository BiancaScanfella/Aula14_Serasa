using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_Serasa
{
    internal class Pessoa
    {
        // ATRIBUTOS
        private string nome;
        private int idade;
        public bool inadimplente = false; // definir padrão para todo mundo
        public Endereco endereco; 
        // private = privado // public = publica
        // CONSTRUTOR -> é um método especial que tem o mesmo nome da classe e garante
        // a alocação de memória necessária para cada objeto da classe
        public Pessoa( string nome, int idade, string rua, string bairro, string cidade  ) 
        { 
            this.nome = nome; 
            this.idade = idade;
            this.endereco = new Endereco( rua, bairro, cidade);
        }

        // MÉTODOS
        public void mostra()
        {
            Console.WriteLine($"Eu sou o {nome} e tenho {idade} anos");
        }

    }
}
