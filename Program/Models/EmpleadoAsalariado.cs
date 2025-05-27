
namespace Program.Models
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; private set; }

        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salario)
            : base(nombre, apellido, nss)
        {
            SalarioSemanal = salario;
        }

        public override decimal CalcularPagoSemanal() => SalarioSemanal;
    }-
}
