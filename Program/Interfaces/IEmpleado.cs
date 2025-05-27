
namespace Program.Interfaces
{
    public interface IEmpleado
    {
        string PrimerNombre { get; }
        string ApellidoPaterno { get; }
        string NumeroSeguroSocial { get; }
        decimal CalcularPagoSemanal();
    }
}
