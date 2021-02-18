using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piha_Dinamica_Simplismente_Encadeada
{
	class Pilha_Dinamica_Livro
	{
		public Livro Topo { get; set; }
		public void Push(Livro aux)
		{
			if (Vazia()) //Verifica se a pilha está vazia
				Topo = aux;
			else
			{
				aux.Anterior = Topo;
				Topo = aux;
			}
			return;
		}
		public int Quantidade()
		{
			int cont = 0;
			if (Vazia())
			{
				Console.WriteLine("Pilha Vazia!");
				return 0;
			}
			else
			{
				Livro aux = Topo;
				Console.WriteLine();
				do
				{
					cont++;
					aux = aux.Anterior;
					Console.WriteLine();
				} while (aux != null);

				return cont;
			}

		}



		private bool Vazia()
		{
			if (Topo == null)
				return true;
			return false;
		}
		public void Imprimir()
		{
			if (Vazia())
			{
				Console.WriteLine("Impossivel Imprimir. Pilha Vazia!");
				Console.ReadKey();
			}
			else
			{

				Livro aux = Topo;
				Console.WriteLine("Os Elementos da Pilha sao: ");
				Console.WriteLine();
				do
				{

					Console.WriteLine(aux.ToString());
					aux = aux.Anterior;
					Console.WriteLine();
				} while (aux != null);
				Console.WriteLine(">>>FIM<<<");
			}
		}

		public void Pop()
		{
			if (Vazia())
			{
				Console.WriteLine("Impossivel Remover. Pilha Vazia!");
				Console.ReadKey();
			}
			else
			{
				Topo = Topo.Anterior;
				Console.WriteLine("Elmento Removido!");
			}
		}

		public void Encontrar(string buscaTitulo)
		{

			if (Vazia())
			{
				Console.WriteLine("Pilha Vazia!");
				Console.ReadKey();
			}
			else
			{

				Livro aux = Topo;
				do
				{
					if (aux.Titulo.ToLower() == buscaTitulo.ToLower())
					{
						Console.WriteLine("Livro Encontrado: \n" + aux.ToString());
					}
					aux = aux.Anterior;
					Console.WriteLine();
				} while (aux != null);
				Console.WriteLine(">>>FIM<<<");
			}

		}
	}
}
