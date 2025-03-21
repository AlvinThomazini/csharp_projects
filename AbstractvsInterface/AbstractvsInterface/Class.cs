abstract class ReceitaDeBolo
{
    public abstract void Assar();
}

// ERRO: Não podemos criar objetos de uma classe abstrata!
// ReceitaDeBolo bolo = new ReceitaDeBolo();

class BoloDeChocolate : ReceitaDeBolo
{
    public override void Assar()
    {
        Console.WriteLine("O bolo de chocolate está assando...");
    }

}

//--------------------------------------------------------------------------

interface IFuncionario
{
    void Trabalhar();
    void ReceberPagamento();
}


class Programador : IFuncionario
{
  
    public void Trabalhar()
    {
        Console.WriteLine("Estou Ocupado codificando e criando....");
    }

    public void ReceberPagamento()
    {
        Console.WriteLine("Mas no fim quero meu pagamento...");
    }
}

//-----------------------------------------------------------------------------------
