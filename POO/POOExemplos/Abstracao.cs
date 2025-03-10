namespace Pilares
{
    abstract class Forma
    {
        public abstract double CalcularArea();
    }

    class Retangulo : Forma
    {
        private double largura, altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return largura * altura;
        }
    }
}
