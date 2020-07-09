namespace Aula34_MVC.Views
{
  using System.Collections.Generic;
using Aula34_MVC.Models;

    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista)
            {
                System.Console.WriteLine($" R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}

