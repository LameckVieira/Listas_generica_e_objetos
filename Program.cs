using System;
using System.Collections.Generic;
using Classes;

namespace Listas_generica_e_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numeros = new List<int>();
            // numeros.Add(500);// esse add serve pra adicionar qualquer coisa tanto nome quanto numeros
            // numeros.Add(200);
            // numeros.Add(30);
            // numeros.Add(400);

            // List<string> nomes = new List<string>();
            // nomes.Add("Tsuka");// esse add serve pra adicionar qualquer coisa tanto nome quanto numeros
            // nomes.Add("Lameck");
            // nomes.Add("Paulo");
            // nomes.Add("Clara");
            
            // bool resposta = numeros.Contains(1000); // Retorna um valor booleano caso o item pesquisado
            // if(resposta == true){
            //     Console.WriteLine("numero encontrado");
            // }else{
            //     Console.WriteLine("numero não encontrado");
            // }

            // Console.WriteLine(numeros.Count); // conta quantos itens tem na lista.

            // for (var i = 0; i < numeros.Count; i++)
            // {
            //     if(numeros.Contains(500)){
            //         numeros.Insert(i,600);
            //     }else{
            //         Console.WriteLine("Não encontrado");
            //     }
            // }
            // foreach (var item in numeros)
            // {
            //    Console.WriteLine(item); 
            // }

            // numeros.Insert(4, 40);

            // foreach (var item in numeros)
            // {
            //     Console.WriteLine(item);
            // }

            // nomes.Sort();
            // foreach (var item in nomes)
            // {
            //     Console.WriteLine(item);
            // }
            List<Produto> produtos = new List<Produto>();
            Produto cafe = new Produto(2,"Café pequeno", 3.5f);
            
            produtos.Add(new Produto(1,"Pão na chap",2.5f));
            produtos.Add(cafe);
            produtos.Add(new Produto(3, "Coxinha", 5.5f));
            produtos.Add(new Produto(4, "Risole", 7.5f));

            produtos.RemoveAll(produtos => produtos.Nome == "Coxinha");

            Console.WriteLine(produtos[0].Nome);

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Item codigo {item.Codigo} Nome {item.Nome} Preço {item.Preco}");
            }

        
        }
    }
}
