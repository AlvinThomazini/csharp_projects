namespace Pilares
{
    class Veiculo
    {
        public virtual void Mover()
        {
            Console.WriteLine("O veículo está se movendo.");
        }
    }

    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("O carro está dirigindo.");
        }
    }

    class Bicicleta : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("A bicicleta está pedalando.");
        }
    }
}
