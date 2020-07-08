using System;
using System.Collections.Generic;
using Aula_34.Models;

namespace Aula_34.Views
{
    public class ProdutoView
    {
        
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista)
            {
                Console.WriteLine($"{item.Preco} - {item.Nome}");
            }
        }

    }
}