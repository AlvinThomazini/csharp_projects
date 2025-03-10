using System;
using Pilares;

class Program
{
    static void Main()
    {
        // Encapsulamento
        Console.WriteLine("=== Encapsulamento ===");
        ContaBancaria conta = new ContaBancaria(1000);
        conta.Depositar(500);
        conta.Sacar(200);
        Console.WriteLine($"Saldo atual: {conta.GetSaldo()}");

        // Herança
        Console.WriteLine("\n=== Herança ===");
        Animal cachorro = new Cachorro();
        Animal Gato = new Gato();
        cachorro.EmitirSom();
        Gato.EmitirSom();

        // Polimorfismo
        Console.WriteLine("\n=== Polimorfismo ===");
        Veiculo carro = new Carro();
        Veiculo bicicleta = new Bicicleta();
        carro.Mover();
        bicicleta.Mover();

        // Abstração
        Console.WriteLine("\n=== Abstração ===");
        Forma retangulo = new Retangulo(10, 5);
        Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");
    }
}
