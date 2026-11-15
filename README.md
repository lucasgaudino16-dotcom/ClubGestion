# ClubGestion

Trabajo Práctico Integrador N° 2 de Lenguajes de Última Generación (UAI, comisión 2-B, 2° cuatrimestre 2026).

Aplicación de escritorio para un club de barrio. Maneja socios, categorías, actividades e inscripciones. Está hecha en C# con .NET 8, Windows Forms, SQL Server (LocalDB) y ADO.NET en capas.

## Cómo correrlo

1. Ejecutar `script_base_de_datos.sql` en SSMS conectado a `(localdb)\MSSQLLocalDB`. Crea la base `ClubGestion` con datos de ejemplo.
2. Abrir `ClubGestion.sln` en Visual Studio 2022 y ejecutar el proyecto `ClubGestion`.
3. Si el servidor no es LocalDB, cambiar el `Data Source` en `ClubGestion\App.config`.

## Qué tiene

- Socios: alta, modificación, baja, eliminación y búsqueda por apellido, nombre o DNI.
- Categorías: ABM con la cuota base.
- Actividades: ABM con arancel y cupo.
- Inscripciones: anotar a un socio en una o varias actividades en una sola transacción, ver los inscriptos y los cupos libres, y dar de baja una inscripción.

## Proyectos

- `Entity`: entidades y excepciones.
- `MAPPER`: pasa las filas de la base a objetos.
- `DAL`: acceso a datos.
- `BLL`: reglas de negocio y transacciones.
- `ClubGestion`: formulario de Windows Forms.

## Documentación

En `docs` está el PDF con la descripción del sistema, el diagrama de base de datos, el diagrama de clases y el manual de usuario. Los diagramas están en `docs\diagramas` y las imágenes en `docs\img`.
