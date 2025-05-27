using Program.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Program.Data
{
    public class EmpleadoRepository
    {
        private readonly List<IEmpleado> _empleados;

        public EmpleadoRepository()
        {
            _empleados = new List<IEmpleado>();
        }

        public void AgregarEmpleado(IEmpleado empleado)
        {
            _empleados.Add(empleado);
        }

        public List<IEmpleado> ObtenerTodos()
        {
            return _empleados;
        }

        public IEmpleado? BuscarPorNSS(string nss)
        {
            return _empleados.FirstOrDefault(e => e.NumeroSeguroSocial == nss);
        }

        public bool ActualizarEmpleado(IEmpleado empleadoActualizado)
        {
            var index = _empleados.FindIndex(e => e.NumeroSeguroSocial == empleadoActualizado.NumeroSeguroSocial);
            if (index != -1)
            {
                _empleados[index] = empleadoActualizado;
                return true;
            }
            return false;
        }

        public void EliminarEmpleado(string nss)
        {
            var empleado = BuscarPorNSS(nss);
            if (empleado != null)
            {
                _empleados.Remove(empleado);
            }
        }
    }
}
