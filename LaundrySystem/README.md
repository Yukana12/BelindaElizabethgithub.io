# Sistema de lavandería (base Clean Architecture + C#)

Este es un **punto de partida** para tu aplicación web de lavandería usando C# y Clean Architecture.

## Stack recomendado para web

Como preguntaste qué usar para la parte web, estas son dos rutas seguras:

1. **ASP.NET Core Web API + React (Vite) o Angular**
   - Backend en C# (API REST).
   - Frontend moderno separado.
   - Recomendado si quieres UI muy dinámica.

2. **ASP.NET Core + Blazor Server/WebAssembly**
   - Todo en ecosistema .NET/C#.
   - Menos cambio de lenguaje.
   - Recomendado si quieres mantenerte full C#.

> En este starter dejé una **Web API mínima** (`LaundrySystem.Web`) para que empieces rápido.

## Estructura Clean Architecture

- `LaundrySystem.Domain`: Entidades y enums de negocio (sin dependencias externas).
- `LaundrySystem.Application`: Casos de uso, DTOs, interfaces.
- `LaundrySystem.Infrastructure`: Persistencia, servicios externos.
- `LaundrySystem.Web`: API HTTP, autenticación, endpoints.

## Entidades base incluidas

Se modelaron tus clases base:

- Persona, Admin, Cliente, Empleado, Repartidor
- Entrega, TareaRepartidor
- Pedido, DetallePedido, Pago, Factura
- Servicio, Producto, Cupon, Promocion
- ArticuloEquipo, UsoCupon, UsoEquipo

## Siguiente paso sugerido

1. Crear repositorios e interfaces en `Application`.
2. Implementar EF Core en `Infrastructure`.
3. Exponer endpoints CRUD en `Web`.
4. Agregar autenticación JWT (admin/cliente/empleado/repartidor).
5. Conectar frontend (React/Angular/Blazor).
