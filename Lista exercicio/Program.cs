using System;
using System.Collections.Generic;
using Lista_exercicio.classes;

namespace Lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            //new produto = produto cafe = new produto... no caso abaixo eu crio o obj e ja passo o valor

            Produto cafe = new Produto(2, "Cafe pequeno", 3.5f);

            produtos.Add(new Produto(1, "Pao na chapa", 2.5f));
            produtos.Add(cafe);
            produtos.Add(new Produto(3, "Coxinha", 5.5f));
            

            

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Item codigo {item.Codigo} Nome {item.Nome} preco {item.Preco}");
                
            }
        }
    }
}
