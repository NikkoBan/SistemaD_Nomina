
namespace Program.Models
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal SueldoPorHora { get; private set; }
        public decimal HorasTrabajadas { get; private set; }

        public EmpleadoPorHoras(string nombre, string apellido, string nss, decimal sueldo, decimal horas)
            : base(nombre, apellido, nss)
        {
            SueldoPorHora = sueldo;
            HorasTrabajadas = horas;
        }

        public override decimal CalcularPagoSemanal()
        {
            return HorasTrabajadas <= 40
                ? SueldoPorHora * HorasTrabajadas
                : (SueldoPorHora * 40) + (SueldoPorHora * 1.5m * (HorasTrabajadas - 40));
        }
    }
}
