using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.TesteGetSet.Models
{
    public class Pessoa
    {
        private string Nome;
        private int Idade;
        
        public Pessoa (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetIdade()
        {
            return Idade;
        }
    }
}