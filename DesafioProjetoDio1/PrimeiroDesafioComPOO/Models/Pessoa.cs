using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroDesafioComPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public void getNome(String nome) 
        { 
            Nome = nome;
        }
        public int _Idade { get; set; }
        public void getIdade(int idade) 
        {
            _Idade = idade;
        }
        public void Apresentar() 
        { 
            Console.WriteLine($"Nome: {Nome}, Idade: {_Idade}");
        }
    }
}