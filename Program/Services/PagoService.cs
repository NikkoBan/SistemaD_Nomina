using Program.Interfaces;
using Program.Data;

namespace Program.Services
{
    public class PagoService
    {
        private readonly EmpleadoRepository _repositorio;

        public PagoService(EmpleadoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void AgregarEmpleado(IEmpleado empleado)
        {
            _repositorio.AgregarEmpleado(empleado);
        }

        public bool ActualizarEmpleado(IEmpleado empleadoActualizado)
        {
            return _repositorio.ActualizarEmpleado(empleadoActualizado);
        }

        public void EliminarEmpleado(string nss)
        {
            _repositorio.EliminarEmpleado(nss);
        }

        public List<IEmpleado> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        public void MostrarPagos()
        {
            var empleados = _repositorio.ObtenerTodos();

            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            Console.WriteLine("========= PAGOS SEMANALES =========");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.PrimerNombre} {empleado.ApellidoPaterno}");
                Console.WriteLine($"NSS: {empleado.NumeroSeguroSocial}");
                Console.WriteLine($"Pago: {empleado.CalcularPagoSemanal():C}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
