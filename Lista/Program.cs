using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("Matheus");
            nomes.Add("Pedro");
            nomes.Add("Joao");
            nomes.Add("Rafael");
            nomes.Add("Ronaldo");

            
            Console.WriteLine(nomes.Count); // Conta os intens da lista

            nomes.Insert(2,"Pedrino"); // Inseri mais um nome na minha lista

            nomes.Sort(); // Ordena em ordem alfabetica ou numerica

            nomes.Remove("Joao"); // Exclui um nome da lista

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            
            // bool resposta = nomes.Contains("Joao"); // Retorna um valor boleano caso o item pesqueisado seja encontrado

            // if (resposta == true)
            // {
            //     Console.WriteLine("Nome encontrado");
            // }else{
            //     Console.WriteLine("Nome nao encontradao");
            // }




            // foreach (var item in nomes)
            // {
            //     if(item == "Joao"){
            //         Console.WriteLine("Nome encontrado");
                
            // }
        }
    }
}
