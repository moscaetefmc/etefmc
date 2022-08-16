using System;
using BlbliotecaDeJogos.Classes;
using System.Collections.Generic;

namespace BlbliotecaDeJogos
{
    class Program
    {
        static List<Jogo> listaJogos = new List<Jogo>();

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("##### - BIBLIOTECA DE JOGOS - #####");
                Console.WriteLine("\n");
                Console.WriteLine("1- Adicionar um Jogo");
                Console.WriteLine("2- Listar os Jogos");
                Console.WriteLine("3- Atualizar um Jogo");
                Console.WriteLine("4- Deletar um Jogo");

                int opcao = Console.Read() - 48;
                switch (opcao)
                {
                    case 1:
                        listaJogos.Add(AdicionarJogo());
                        break;

                    case 2:
                        Listar();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }            
        }

        static private Jogo AdicionarJogo()
        {
            Console.Clear();
            Console.WriteLine("ADICIONAR JOGO");
            Console.ReadLine();

            string nome="";
            while (nome.Length == 0)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }            

            Console.Write("Lançamento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();
            Console.Write("Max. de Jogadores: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());

            Jogo jogo = new Jogo(nome, ano, genero, max, metacritic);
            Console.Beep();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();

            return jogo;
        }

        static private void Listar()
        {
            Console.Clear();
            Console.WriteLine("JOGOS ADICIONADOS: ");

            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Jogo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("-------------");
                Console.WriteLine("");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
