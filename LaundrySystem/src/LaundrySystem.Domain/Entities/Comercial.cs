using LaundrySystem.Domain.Enums;

namespace LaundrySystem.Domain.Entities;

public sealed class Pedido
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid ClienteId { get; set; }
    public DateTime FechaCreacion { get; init; } = DateTime.UtcNow;
    public EstadoPedido Estado { get; set; } = EstadoPedido.Creado;
    public List<DetallePedido> Detalles { get; } = [];
}

public sealed class DetallePedido
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid PedidoId { get; set; }
    public Guid? ServicioId { get; set; }
    public Guid? ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
}

public sealed class Pago
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid PedidoId { get; set; }
    public decimal Monto { get; set; }
    public EstadoPago Estado { get; set; } = EstadoPago.Pendiente;
    public DateTime Fecha { get; init; } = DateTime.UtcNow;
}

public sealed class Factura
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid PedidoId { get; set; }
    public string Numero { get; set; } = string.Empty;
    public decimal Subtotal { get; set; }
    public decimal Impuestos { get; set; }
    public decimal Total { get; set; }
}
