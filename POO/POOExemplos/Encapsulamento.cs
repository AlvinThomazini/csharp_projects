namespace Pilares
{
    class ContaBancaria
    {
        private double saldo;
        
        public ContaBancaria(double saldoInicial)
        {
            saldo = saldoInicial;
        }

        public void Depositar(double valor) => saldo += valor;
        public void Sacar(double valor) => saldo -= valor;
        public double GetSaldo() => saldo;
    }
}
