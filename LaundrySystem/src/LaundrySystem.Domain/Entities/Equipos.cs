namespace LaundrySystem.Domain.Entities;

public sealed class ArticuloEquipo
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string? Marca { get; set; }
    public bool Disponible { get; set; } = true;
}

public sealed class UsoCupon
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid CuponId { get; set; }
    public Guid PedidoId { get; set; }
    public DateTime FechaUso { get; init; } = DateTime.UtcNow;
}

public sealed class UsoEquipo
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid ArticuloEquipoId { get; set; }
    public Guid PedidoId { get; set; }
    public TimeSpan TiempoUso { get; set; }
}
