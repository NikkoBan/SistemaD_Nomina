namespace Program.Models
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; private set; }

        public EmpleadoAsalariadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salarioBase)
            : base(nombre, apellido, nss, ventas, tarifa)
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularPagoSemanal()
        {
            return base.CalcularPagoSemanal() + SalarioBase + (SalarioBase * 0.10m);
        }
    }
}
