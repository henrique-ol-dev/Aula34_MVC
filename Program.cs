using System;
using Aula34_MVC.Controllers;
using static Aula34_MVC.Controllers.ProdutoControler;

namespace Aula34_MVC
{
    class Program
    { 
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Listar();
            produto.Filtrar("7500");
        }
    }
}
