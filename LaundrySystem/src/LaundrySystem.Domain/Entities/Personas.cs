using LaundrySystem.Domain.Enums;

namespace LaundrySystem.Domain.Entities;

public abstract class Persona
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Nombre { get; set; }
    public required string Email { get; set; }
    public required string Telefono { get; set; }
    public TipoPersona Tipo { get; init; }
}

public sealed class Admin : Persona
{
    public string? RolInterno { get; set; }
}

public sealed class Cliente : Persona
{
    public string? Direccion { get; set; }
    public int PuntosFidelidad { get; set; }
}

public class Empleado : Persona
{
    public required string Area { get; set; }
}

public sealed class Repartidor : Empleado
{
    public required string Vehiculo { get; set; }
    public string? PlacaVehiculo { get; set; }
}
