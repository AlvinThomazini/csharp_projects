using System;

class Apostolos
{
    // Propriedades encapsuladas
    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public int TempoDeApostolado { get; private set; }

    // Construtor que recebe nome, idade e tempo de apostolado
    public Apostolos(string nome, int idade = 0, int tempoDeApostolado = 0)
    {
        Nome = nome;
        Idade = idade;
        TempoDeApostolado = tempoDeApostolado;
    }

    // Método para exibir informações formatadas do apóstolo
    public void ExibirInfo()
    {
        Console.WriteLine($"{Nome}, {Idade} anos, {TempoDeApostolado} anos de apostolado.");
    }
}
