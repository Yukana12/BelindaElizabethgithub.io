namespace LaundrySystem.Domain.Entities;

public sealed class Entrega
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid PedidoId { get; set; }
    public Guid RepartidorId { get; set; }
    public DateTime FechaProgramada { get; set; }
    public DateTime? FechaCompletada { get; set; }
    public string? Observacion { get; set; }
}

public sealed class TareaRepartidor
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid RepartidorId { get; set; }
    public Guid EntregaId { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public bool Completada { get; set; }
}
