using ClubeDaLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class RepositorioAmigo : Cadastro
    {
        public List<Amigo> ListaAmigos = new List<Amigo>();
        

        public void CadastrarAmigo(Amigo amigo)
        {
            ListaAmigos.Add(amigo);
        }
        
        public void Criar(Amigo amigo)
        {
            CadastrarAmigo(amigo);
            ContadorId++;
        }
        public void Editar(int idEditar, Amigo amigoAtualizado)
        {
            Amigo amigo = SelecionarAmigoPorId(idEditar);

            amigo.Nome = amigoAtualizado.Nome;
            amigo.NomeResponsavel = amigoAtualizado.NomeResponsavel;
            amigo.Telefone = amigoAtualizado.Telefone;
            amigo.Endereco = amigoAtualizado.Endereco;
        }
        public void Deletar(int id)
        {
            Amigo amigo = SelecionarAmigoPorId(id);
            ListaAmigos.Remove(amigo);
        }
        public List<Amigo> SelecionarTodos()
        {
            return ListaAmigos;
        }
        public Amigo SelecionarAmigoPorId(int id)
        {
            Amigo amigo = null;

            foreach (Amigo a in ListaAmigos)
            {
                if (a.Id == id)
                {
                    amigo = a;
                    break;
                }
            }

            return amigo;
        }
    }
}
