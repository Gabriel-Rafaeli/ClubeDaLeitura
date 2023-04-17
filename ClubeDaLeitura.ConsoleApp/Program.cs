using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioEmprestimo cadastroEmprestimo = new RepositorioEmprestimo();
            RepositorioRevista cadastroRevista = new RepositorioRevista();
            RepositorioCaixa cadastroCaixa = new RepositorioCaixa();
            RepositorioAmigo cadastroAmigo = new RepositorioAmigo();
            
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();
            TelaAmigo telaAmigo = new TelaAmigo();
            TelaCaixa telaCaixa = new TelaCaixa();
            TelaRevista telaRevista = new TelaRevista();

            Menu menu = new Menu();

            telaEmprestimo.cadastroRevista = cadastroRevista;
            telaCaixa.cadastroCaixa = cadastroCaixa;
            telaRevista.cadastroCaixa = cadastroCaixa;
            telaEmprestimo.cadastroEmprestimo = cadastroEmprestimo;
            telaEmprestimo.cadastroAmigo = cadastroAmigo;
            telaAmigo.cadastroAmigo = cadastroAmigo;
            telaRevista.cadastroRevista = cadastroRevista;


            menu.telaEmprestimo = telaEmprestimo;
            menu.telaCaixa = telaCaixa;
            menu.telaRevista = telaRevista;
            menu.cadastroCaixa = cadastroCaixa;
            menu.cadastroAmigo = cadastroAmigo;
            menu.telaAmigo = telaAmigo;
            
            //ADICIONANDO CAIXAS
            Caixa caixa0 = new Caixa(0, "Azul", "Terror", 0);
            cadastroCaixa.ListaDeCaixas.Add(caixa0);
            cadastroCaixa.ListaDeCaixas.Add(new Caixa(1, "cinza", "Comédia", 1));
            cadastroCaixa.ListaDeCaixas.Add(new Caixa(2, "Branco", "Filosofia", 2));
            cadastroCaixa.ListaDeCaixas.Add(new Caixa(3, "Preto", "Quadrinhos", 3));

            //ADICIONANDO AMGOS
            Amigo amigo0 = new Amigo(0, "Gandalf", "Arnaldo", "99112266", "88505050");
            cadastroAmigo.ListaAmigos.Add(amigo0);
            cadastroAmigo.ListaAmigos.Add(new Amigo(1, "Aragorn", "Katarina", "32253244", "88505059"));
            cadastroAmigo.ListaAmigos.Add(new Amigo(2, "Legolas", "Alex", "99624321", "88505038"));
            cadastroAmigo.ListaAmigos.Add(new Amigo(3, "Ultred", "Ragnar", "00992456", "88505042"));

            //ADICIONANDO REVISTAS
            Revista revista0 = new Revista(0, "Marvel", "444", "1999", caixa0);
            cadastroRevista.Revistas.Add(revista0);
            cadastroRevista.Revistas.Add(new Revista(1, "DC", "555", "2012", caixa0));
            cadastroRevista.Revistas.Add(new Revista(2, "AVENTURES", "222", "2001", caixa0));
            cadastroRevista.Revistas.Add(new Revista(3, "Fighters", "982", "2010", caixa0));

            //ADICIONANDO EMPRESTIMOS
            cadastroEmprestimo.ListaDeEmprestimos.Add(new Emprestimo(0, amigo0, revista0, "21/09", "28/10", "EM ABERTO"));

            menu.ExecutarMenuPrincipal();
        }
    }
}