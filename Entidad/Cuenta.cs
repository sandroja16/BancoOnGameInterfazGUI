namespace Entidad
{
    public class Cuenta
    {
        public Cuenta(double numeroCuenta, Cliente cliente, double saldo)
        {
            NumeroCuenta = numeroCuenta;
            Cliente = cliente;
            Saldo = saldo;
        }

        public Cuenta(string linea)
        {
            this.linea = linea;
        }

        public double NumeroCuenta { get; set; }
        public Cliente Cliente { get; set; }
        private double Saldo;
        private string linea;

        public double getSaldo()
        {
            return Saldo;
        }
        public string Consignar(double valor)
        {
            Saldo += valor;
            return "Consignacion exitosa";
        }
        public string Retirar(double valor)
        {
            if (Saldo < valor)
            {
                return "Fondos insuficiente";
            }
            Saldo -= valor;
            return "Retiro exitoso";
        }
        public override string ToString()
        {
            return NumeroCuenta.ToString() + ";" + Cliente.IdCliente + ";" + Saldo.ToString();
        }
    }
}
