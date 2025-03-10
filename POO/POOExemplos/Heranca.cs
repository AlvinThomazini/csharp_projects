namespace Pilares
{
    class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("O Animal Faz um som");   
        }

    
    }

    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine(" O Som do Cachorro é o Latido: AU AU Au!");
        }
    }

    class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O Som do Gato é o Miado: MIAU MIAU MIAU!");
        }
    }
}