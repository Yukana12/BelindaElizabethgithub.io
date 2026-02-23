namespace LaundrySystem.Domain.Entities;

public sealed class Servicio
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public decimal PrecioBase { get; set; }
}

public sealed class Producto
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int Stock { get; set; }
}

public sealed class Cupon
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Codigo { get; set; } = string.Empty;
    public decimal DescuentoPorcentaje { get; set; }
    public DateTime VigenteHasta { get; set; }
}

public sealed class Promocion
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string? Regla { get; set; }
    public decimal DescuentoFijo { get; set; }
}
