using System;
using System.Collections.Generic;
using System.IO;

namespace Aula_34.Models
{
    public class Produto
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "database/Produto.csv"; 
        
        public Produto()
        {
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH); 

            foreach(var linha in linhas)
            {
                string[] dados = linha.Split(";");

                Produto prod = new Produto();
                prod.Codigo = Int32.Parse( Separar(dados[0]) );
                prod.Nome   = Separar(dados[1]);
                prod.Preco  = float.Parse( Separar(dados[2]) );

                produtos.Add(prod);
            }

            return produtos;
        }

        private string Separar(string txt){
            return txt.Split('=')[1];
        }
    }
}