using System;
using System.Collections.Generic;
using System.Linq;// Importando LINQ

class Program
{
    static void Main(string[] args)
    {
        List<Apostolos> profetas = new List<Apostolos>
        {
            new Apostolos("Russel M. Nelson", 100, 41 ),
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
        var idosos = profetas.Where(a => a.Idade > 80);
        Console.WriteLine("Apóstolos com mais de 80 anos:");
        foreach (var apostolo in idosos)
        {
            apostolo.ExibirInfo();
        }

        // 2. Apóstolo mais jovem
        var maisJovem = profetas.OrderBy(a => a.Idade).First();
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
        string escolha = Console.ReadLine().Trim().ToUpper();

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