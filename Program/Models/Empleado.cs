using Program.Interfaces;

namespace Program.Models
{
    public abstract class Empleado : IEmpleado
    {
        public string PrimerNombre { get; protected set; }
        public string ApellidoPaterno { get; protected set; }
        public string NumeroSeguroSocial { get; protected set; }

        public Empleado(string nombre, string apellido, string nss)
        {
            PrimerNombre = nombre;
            ApellidoPaterno = apellido;
            NumeroSeguroSocial = nss;
        }

        public abstract decimal CalcularPagoSemanal();
    }
}
