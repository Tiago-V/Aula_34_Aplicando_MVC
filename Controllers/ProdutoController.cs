using System.Collections.Generic;
using Aula_34.Models;
using Aula_34.Views;

namespace Aula_34.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel1   = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel1.Ler();
            produtoView.MostrarNoConsole(lista);
        }
        public void Buscar(string termo)
        {
            List<Produto> lista = produtoModel1.Ler().FindAll( x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }
    }
}