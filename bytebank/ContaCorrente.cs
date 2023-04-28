using bytebank.Titular;
namespace bytebank
{
    public class ContaCorrente
    {
        
        public Cliente Titular {get ; set;}

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        public string Nome_agencia { get; set; }
        
        private int _numero_agencia;
        public int Numero_agencia
        {
            get{
                return _numero_agencia;
            }
            set
            {
                if(value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        private double saldo;
        public double Saldo /*propridade*/
        {
            get /*pegar valor*/
            {
                return saldo; /*classe*/
            }
            set /*colocar valor*/
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }
        
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo += valor;
                return true;
            }
        }
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Número Agência:" + Numero_agencia);
            Console.WriteLine("Nome Agência: " + Numero_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas++;
        }

        public static /*é uma propriedade da classe*/ int TotalDeContasCriadas { get; set; }
    }
}