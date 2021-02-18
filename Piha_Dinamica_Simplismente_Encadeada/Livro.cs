using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piha_Dinamica_Simplismente_Encadeada
{
	class Livro
	{
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public int Isbn { get; set; }
		public Livro Anterior { get; set; }

		public override string ToString()
		{
			return ">>>>>>> Dados do Livro <<<<<<\nTitulo: " +Titulo+ "\nAutor:" + Autor +"\nISBN:" + Isbn; 
		}


	}
}
