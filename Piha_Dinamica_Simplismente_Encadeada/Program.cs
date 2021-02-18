using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piha_Dinamica_Simplismente_Encadeada
{
	class Program
	{
		static void Main(string[] args)
		{
			int escolha;
			Pilha_Dinamica_Livro minhaPilha = new Pilha_Dinamica_Livro { Topo = null };
			

			
			do
			{
				Console.WriteLine("=========Menu Pilha de Livros ==========");
				Console.WriteLine();
				Console.WriteLine(" 1 - Inserir Livro");
				Console.WriteLine(" 2 - Remover Livro");
				Console.WriteLine(" 3 - Imprimir Pilha");
				Console.WriteLine(" 4 - Quantidade de Elementos na Pilha");
				Console.WriteLine(" 5 - Buscar Livro na Pilha por Titulo");
				Console.WriteLine(" 0 - Sair");
				Console.Write("Escolha uma das opções acima: ");
				escolha = int.Parse(Console.ReadLine());


				switch (escolha)
				{
					case 1:

						Console.Write("Digite o Tiulo do livro: ");
						string titulo = Console.ReadLine();
						Console.Write("Digite o Nome do Autor: ");
						string autor = Console.ReadLine();
						Console.Write("Digite o Valor do Isbn: ");
						int isbn = int.Parse(Console.ReadLine());
						Livro l = new Livro 
						{
							Titulo = titulo,
							Autor = autor,
							Isbn = isbn	
						};
						minhaPilha.Push(l);
						Console.Clear();
						break;
					case 2:
						minhaPilha.Pop();
						break;
					case 3:
						Console.WriteLine();
						minhaPilha.Imprimir();
						
					break;
					case 4:
						int cont = 0;
						cont = minhaPilha.Quantidade();
						Console.Write("A quantidade de livros na pilha é igual há: " + cont);
						Console.WriteLine();
						break;
					case 5:
						
						Console.Write("Digite o Tiulo do livro: ");
						string buscaTitulo = Console.ReadLine();
						minhaPilha.Encontrar(buscaTitulo);
						break;
				}
			} while (escolha != 0);





			/*minhaPilha.Imprimir();
			minhaPilha.Imprimir();
			minhaPilha.Pop();
			minhaPilha.Imprimir();
			minhaPilha.Pop();
			minhaPilha.Imprimir();
			minhaPilha.Pop();*/
			Console.ReadKey();



		}
	}
}
//minhaPilha.init();
//Console.WriteLine(l.ToString());




//Fazer Menu 
//Opção retorne a quantidade de elementos na pilha
//Busca por titulo

