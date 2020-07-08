using System;
using Aula_34.Controllers;

namespace Aula_34
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Listar();
            prod.Buscar("4,5");        }
    }
}
