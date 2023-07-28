// See https://aka.ms/new-console-template for more information
using Aula14_Serasa;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");


Pessoa p1 = new Pessoa ("Conrado", 16, "rua x", "centro", "Sanca"); //parametro

//Endereco e1 = new Endereco ("rua x", "centro", "Sanca");
 //Console.WriteLine(p1.idade); -> mostra somente a idade
//p1.endereco = e1;   // -> esta ligado ao p1
p1.mostra();
p1.endereco.mostra(); // é para mostrar o endereço no p1
