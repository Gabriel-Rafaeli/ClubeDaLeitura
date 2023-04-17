using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class Amigo : Entidade
    {
        public string Nome;
        public string NomeResponsavel;
        public string Telefone;
        public string Endereco;

        public Amigo(int id, string nome, string nomeDoResponsável, string telefone, string endereco)
        {
            Id = id;
            Nome = nome;
            NomeResponsavel = nomeDoResponsável;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
