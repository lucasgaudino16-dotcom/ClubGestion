# ClubGestion

Trabajo Práctico Integrador N° 2 · Lenguajes de Última Generación · UAI · 2° cuatrimestre 2026 · Comisión 2-B

Aplicación de escritorio para un club de barrio: socios con su categoría, actividades con cupo y arancel, e inscripciones de socios a actividades. C# .NET 8, Windows Forms, SQL Server (LocalDB) y ADO.NET en capas.

## Cómo correrlo

1. Abrí `script_base_de_datos.sql` en SSMS (o `sqlcmd`) conectado a `(localdb)\MSSQLLocalDB` y ejecutalo. Crea la base `ClubGestion` con datos de ejemplo. Se puede correr más de una vez sin error.
2. Abrí `ClubGestion.sln` en Visual Studio 2022 y ejecutá el proyecto `ClubGestion` (F5).
3. Si tu SQL Server no es LocalDB, cambiá `Data Source` en `ClubGestion\App.config`. No hace falta recompilar.

Requisitos: Visual Studio 2022 con la carga de trabajo "Desarrollo de escritorio de .NET" (incluye .NET 8 y LocalDB).

## Estructura

```
ClubGestion.sln
├─ Entity/        Entidades y excepciones propias. No referencia a nadie.
├─ MAPPER/        Convierte filas (IDataRecord) en objetos. Referencia a Entity.
├─ DAL/           Acceso a datos con Microsoft.Data.SqlClient. Referencia a Entity y MAPPER.
├─ BLL/           Reglas de negocio y transacciones de negocio. Referencia a Entity y DAL.
├─ ClubGestion/   Windows Forms. Usa solo BLL y Entity (DAL y MAPPER se referencian para que copien sus dll).
└─ script_base_de_datos.sql
```

Modelo:

| Tabla | Relación |
|---|---|
| CATEGORIA → SOCIO | 1:N. En la entidad `Socio` la FK es el objeto `Categoria`, nunca un `int`. |
| SOCIO ↔ ACTIVIDAD | N:M con atributos (`FECHA_INSCRIPCION`, `ARANCEL_APLICADO`), por eso existe la clase `Inscripcion` con los objetos `Socio` y `Actividad`. |

## Convenciones (lo que corrige la cátedra)

**Excepciones entre capas**

- `DAL`: cada método con `try/catch`. `catch (SqlException ex)` → `throw new AccesoDatosException("Error al <qué>.", ex)`.
- `BLL`: **todo** método público con `try/catch`, aunque solo delegue. Regla rota → `throw new ReglaNegocioException("...")`. Los `catch` relanzan con `throw;` (nunca `throw ex;`) y el último envuelve lo inesperado en `new Exception("Error inesperado al ...", ex)`.
- `UI`: `Form1_Load`, cada botón y `CellClick` con `try/catch`. `ReglaNegocioException` se muestra como aviso; el resto con `MostrarError`, que agrega el detalle del `InnerException`. La UI no referencia a la DAL en el código ni atrapa `SqlException`.

**Transacciones**: `TransactionScope` en la BLL (`InscripcionBLL.Inscribir`). Las conexiones se abren adentro del `using`, una por vez; `scope.Complete()` es la última línea. Cada método de la DAL abre y cierra su propia conexión y no recibe conexión ni transacción por parámetro.

**Mapper**: clases estáticas en el proyecto `MAPPER`. Reciben `IDataRecord`, así sirven para `SqlDataReader` y para un `DataTable` (`MapLista`). El mapper de la entidad principal reutiliza el de la relacionada con las columnas del JOIN (`SocioMapper` llama a `CategoriaMapper`). Las columnas homónimas llevan alias en el SELECT (`DESCRIPCION AS CATEGORIA`, `NOMBRE AS ACTIVIDAD`). El mapper de entidad a DTO va en la BLL (`InscripcionDTOMapper`).

**Acceso a datos**: `SqlParameter` para todo dato del usuario, `using` en conexiones, comandos y readers, `OUTPUT INSERTED.ID` para recuperar el identity, cadena `MiConexion` en `App.config` leída por `DAL\Conexion.cs`.

**Código**: sin comentarios, nombres en castellano, controles `txt`, `cbo`, `dgv`, `btn`, `lbl`, `grp`, `chk`, `clb`. El formulario se edita desde el diseñador de Visual Studio.

**Base**: el script crea todo con `IF ... IS NULL`, tiene datos en todas las tablas y se puede correr dos veces. Plata en `DECIMAL(10,2)`. Antes de entregar, probarlo en una base vacía.

## Cómo trabajamos

- Una rama por pantalla o tarea (`feature/abm-actividades`), Pull Request a `main`, otro integrante revisa con el checklist de abajo antes de mergear.
- Antes de cada PR: `Recompilar solución` con 0 errores y 0 advertencias, la app abre con datos y la pantalla nueva funciona contra el script actual.
- Si tocás el script, tiene que seguir corriendo dos veces en una base vacía.
- Las tareas están en el tablero de Trello del grupo.

Checklist de revisión de un PR:

- [ ] Cada método público de la BLL tiene su `try` y toda llamada a `_dal.` está adentro de uno.
- [ ] Cada método de la DAL atrapa `SqlException` y la traduce.
- [ ] Ninguna FK quedó como `int` en una entidad.
- [ ] Todo dato que escribe en la base va por `SqlParameter`.
- [ ] Si la operación escribe más de una fila o tabla, está dentro de un `TransactionScope` en la BLL.
- [ ] El evento de la UI tiene `try/catch` y la grilla se refresca después de la operación.

## Documentación

- [docs/DESCRIPCION-DEL-SISTEMA.md](docs/DESCRIPCION-DEL-SISTEMA.md) — **empezá por acá.** Qué hace el sistema, qué queda afuera, los cuatro conceptos del negocio, las reglas, las transacciones y para qué sirve cada capa. Sin código. Es el punto 1 de la documentación de la entrega y la base de la presentación del negocio.
- [docs/CONSIGNA.md](docs/CONSIGNA.md) — la consigna del campus copiada, con una tabla de qué entrega cubre cada parte del proyecto.

Son cinco entregas parciales (negocio, base de datos, solución en capas sin persistir, solución con persistencia, final con transacciones de negocio y defensa oral) más un documento con carátula, diagrama de base de datos, diagrama de clases y manual de usuario. Git y Trello suman puntos.

Falta: diagrama de base de datos, diagrama de clases y manual de usuario.

## Pendiente

Ver el tablero de Trello. A grandes rasgos: ABM de actividades, ABM de categorías, baja de inscripciones desde la UI, pagos de cuotas e inscripciones en una sola transacción, reportes (inscriptos por actividad y recaudación), validaciones con expresiones regulares, controles de usuario reutilizables y lo que pida la consigna del campus.
