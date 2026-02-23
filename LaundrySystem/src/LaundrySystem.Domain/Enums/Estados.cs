namespace LaundrySystem.Domain.Enums;

public enum EstadoPedido
{
    Creado,
    Recogido,
    EnProceso,
    EnRuta,
    Entregado,
    Cancelado
}

public enum EstadoPago
{
    Pendiente,
    Pagado,
    Rechazado,
    Reembolsado
}

public enum TipoPersona
{
    Admin,
    Cliente,
    Empleado,
    Repartidor
}
