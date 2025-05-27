using Program.Interfaces;
using System;
using System.Collections.Generic;

namespace Program.Reports
{
    public class ReporteNomina
    {
        public static void GenerarReporte(List<IEmpleado> empleados)
        {
            Console.WriteLine("===== REPORTE SEMANAL DE NÓMINA =====\n");

            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.PrimerNombre} {empleado.ApellidoPaterno}");
                Console.WriteLine($"NSS: {empleado.NumeroSeguroSocial}");
                Console.WriteLine($"Pago Semanal: {empleado.CalcularPagoSemanal():C}");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine($"Total Empleados: {empleados.Count}");
            Console.WriteLine("========================================\n");
        }
    }
}
