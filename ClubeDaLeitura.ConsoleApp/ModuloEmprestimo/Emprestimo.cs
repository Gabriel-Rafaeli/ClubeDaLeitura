using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    public class Emprestimo : Entidade
    {
        public Amigo AmigoQuePegouARevista;
        public Revista RevistaEmprestada;
        public string DataEmprestimo;
        public string DataDevolucao;
        public string Status;

        public Emprestimo(int id, Amigo amigoQuePegouARevista, Revista revistaEmprestada, string dataDoEmprestimo, string dataDeDevolucao, string status)
        {
            Id = id;
            AmigoQuePegouARevista = amigoQuePegouARevista;
            RevistaEmprestada = revistaEmprestada;
            DataEmprestimo = dataDoEmprestimo;
            DataDevolucao = dataDeDevolucao;
            Status = status;
        }
    }
}
