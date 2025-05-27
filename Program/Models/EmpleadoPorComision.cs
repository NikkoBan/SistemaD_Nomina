
namespace Program.Models
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; private set; }
        public decimal TarifaComision { get; private set; }

        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
            : base(nombre, apellido, nss)
        {
            VentasBrutas = ventas;
            TarifaComision = tarifa;
        }

        public override decimal CalcularPagoSemanal() => VentasBrutas * TarifaComision;
    }
}
