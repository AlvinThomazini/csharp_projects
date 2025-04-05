using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Apostolos> profetas = new List<Apostolos>
        {
            new("Russel M. Nelson", 100, 41 ),
            new Apostolos("Dalin H. Oaks", 92, 41),
            new Apostolos("Henry B. Eyring", 91, 29),
            new Apostolos("Jeffrey R. Holland", 84, 30),
            new Apostolos("Dieter F. Uchtdorf", 84, 20),
            new Apostolos("David A. Bednar",72, 20),
            new Apostolos("Quentin L. Cook", 84, 17),
            new Apostolos("D. Todd Christofferson", 79, 16),
            new Apostolos("Neil L. Andersen", 73, 15),
            new Apostolos("Ronald A. Rasband", 74 , 9 ),
            new Apostolos("Gary E. Stevenson", 69, 9),
            new Apostolos("Dale G. Renlund", 72 , 9),
            new Apostolos("Gerrit W. Gong", 70 , 7),
            new Apostolos("Ulisses Soares", 66, 7),
            new Apostolos("Patrick Kearon", 63 , 1)
        };

        // 1. Apóstolos com mais de 80 anos
        var idosos = profetas.Where(a => a.Idade > 80).ToList();
        Console.WriteLine("Apóstolos com mais de 80 anos:");

        // idosos.ForEach(apostolo => apostolo.ExibirInfo());

        foreach (var apostolo in idosos)
        {
            apostolo.ExibirInfo();
        }

        // 2. Apóstolo mais jovem
        var maisJovem = profetas.OrderBy(a => a.Idade).First(); //FirstOrDefault => Se não tiver nenhum item na coleção vai pegar default que é nulo

        Console.WriteLine($"\nApóstolo mais jovem: {maisJovem.Nome}, {maisJovem.Idade} anos.");

        // 3. Média de idade dos apóstolos
        double mediaIdade = profetas.Average(a => a.Idade);
        Console.WriteLine($"\nMédia de idade dos apóstolos: {mediaIdade:F2} anos.");

        // 4. Apóstolos com 10 anos ou menos de apostolado
        var novos = profetas.Where(a => a.TempoDeApostolado <= 10);
        Console.WriteLine("\nApóstolos com 10 anos ou menos de apostolado:");
        foreach (var apostolo in novos)
        {
            apostolo.ExibirInfo();
        }

        Console.WriteLine("Você quer ver a lista completa dos apóstolos antes? (S/N)");
        string? escolha = Console.ReadLine()?.Trim().ToUpper(); //Operador Condicional Nulo

        // if(escolha?.Equals("S", StringComparison.InvariantCultureIgnoreCase) is true)
        // {
        //     Console.WriteLine("\n📜 Lista completa dos apóstolos:\n");
        //     foreach (var apostolo in profetas)
        //     {
        //         apostolo.ExibirInfo();
        //     }
        // }

        var apostolosFiltrados = profetas.Where(a => a.TempoDeApostolado >= 20 && a.TempoDeApostolado <= 40).ToList();
        Console.WriteLine("\nApóstolos com 20 a 40 anos de apostolado:");
        foreach (var apostolo in apostolosFiltrados)
        {
            apostolo.ExibirInfo();
        }

        profetas.Any(a => a.Nome == "Russel M. Nelson"); //Verifica se existe algum item na coleção que atenda a condição
        profetas.All(a => a.Idade > 60); //Verifica se todos os itens da coleção atendem a condição
        profetas.Count(a => a.Idade > 60); //Conta quantos itens da coleção atendem a condição
        profetas.Max(a => a.Idade); //Pega o maior valor da coleção
        profetas.Min(a => a.Idade); //Pega o menor valor da coleção
        profetas.Sum(a => a.Idade); //Soma todos os valores da coleção
        profetas.Distinct(); //Remove os itens duplicados da coleção
        profetas.OrderBy(a => a.Idade); //Ordena a coleção de acordo com a condição
        profetas.OrderByDescending(a => a.Idade); //Ordena a coleção de acordo com a condição, do maior para o menor
        profetas.Reverse(); //Inverte a ordem da coleção
        profetas.Skip(2); //Pula os dois primeiros itens da coleção
        profetas.Take(2); //Pega os dois primeiros itens da coleção
        profetas.GroupBy(a => a.Idade); //Agrupa os itens da coleção de acordo com a condição
        profetas.Join(profetas, a => a.Idade, b => b.Idade, (a, b) => new { a, b }); //Faz um join entre duas coleções de acordo com a condição
        profetas.Select(a => new { a.Nome, a.Idade }); //Seleciona os itens da coleção de acordo com a condição
        
        if (escolha == "S")
        {
            Console.WriteLine("\n📜 Lista completa dos apóstolos:\n");
            foreach (var apostolo in profetas)
            {
                apostolo.ExibirInfo();
            }
        }
        else
        {
            Environment.Exit(0);
        }

        Console.ReadKey();
    }
}