# Descripción del sistema

**ClubGestion** · Trabajo Práctico Integrador N° 2 · Lenguajes de Última Generación · UAI · Comisión 2-B · 2° cuatrimestre 2026

Profesor: Gonzalo Arigós · Integrantes: _(completar con nombre, apellido y legajo de cada uno)_

Este documento es el punto 1 de la documentación que pide la consigna ("carátula y descripción del sistema"). Explica qué hace el sistema sin hablar de código, así sirve para la presentación del negocio y para que todo el equipo tenga la misma idea de lo que estamos construyendo. Los diagramas y el manual de usuario van en documentos aparte.

## 1. El negocio

Un club de barrio tiene socios y ofrece actividades deportivas y recreativas. El socio paga una cuota mensual que depende de su categoría, y además un arancel por cada actividad en la que se anota. Cada actividad tiene un cupo, porque la cancha, el profesor y el horario son limitados.

Hoy la secretaría del club lleva todo en papel y en planillas sueltas. De ahí salen los tres problemas que justifican el sistema:

- **No se sabe cuántos lugares quedan.** Hay que contar a mano la lista de anotados de cada actividad, y se anota gente de más.
- **Se pierde el rastro de lo que se cobró.** Si el club aumenta el arancel de natación en marzo, no queda registro de que el socio que se anotó en febrero entró con el precio viejo.
- **El mismo socio aparece dos veces.** Se duplican fichas porque nadie controla el DNI contra lo que ya está anotado.

## 2. Qué hace el sistema

ClubGestion es una aplicación de escritorio que usa el personal de la secretaría del club para administrar el padrón de socios, el catálogo de actividades y las inscripciones de socios a actividades.

Lo que sigue es el alcance completo del sistema, que es lo que vamos a defender al final del cuatrimestre. El punto 11 dice qué parte está construida hoy.

Con el sistema la secretaría puede:

1. Dar de alta un socio, modificar sus datos y darlo de baja sin perder su historia.
2. Asignarle a cada socio una categoría, que es la que define su cuota mensual.
3. Administrar las actividades del club con su arancel y su cupo.
4. Anotar a un socio en una o varias actividades en una sola operación.
5. Ver en el momento cuántos lugares libres quedan en cada actividad.
6. Consultar quiénes están anotados en una actividad y en qué está anotado un socio.
7. Dar de baja una inscripción cuando el socio deja la actividad.

El sistema impide las operaciones que el club no quiere que pasen: anotar a un socio dado de baja, pasarse del cupo, anotar dos veces al mismo socio en la misma actividad, repetir un DNI o borrar datos que tienen historia atrás.

## 3. Qué queda afuera

Decirlo explícitamente es parte de la defensa, porque evita que nos pregunten por algo que nunca prometimos.

| No hace | Por qué |
|---|---|
| No cobra plata ni se conecta con medios de pago. | Registra el importe que corresponde; el cobro lo hace la tesorería del club por fuera. |
| No tiene usuarios ni contraseñas. | La aplicación corre en la computadora de la secretaría. Un solo perfil de uso, sin login. |
| No manda mails ni avisos. | Fuera del alcance de la materia. |
| No es multisucursal ni funciona por internet. | Es una aplicación de escritorio contra una base local. |
| No maneja asistencia ni horarios de clase. | El sistema administra la inscripción, no el dictado de la actividad. |

## 4. Quién lo usa

Un solo tipo de usuario: **el administrativo de la secretaría del club**. No es una persona técnica. Trabaja con la aplicación abierta todo el día, atendiendo socios en el mostrador, así que necesita que cada operación sea de pocos clics y que los errores se expliquen en castellano, no con códigos. Eso explica dos decisiones del sistema: una sola ventana con pestañas en vez de muchas ventanas sueltas, y mensajes del tipo "No quedan cupos en Natación" en lugar de un número de error.

## 5. Las cosas del negocio

Cuatro conceptos. Todo el sistema se explica con estos cuatro.

| Concepto | Qué es en el club | Qué se guarda de él |
|---|---|---|
| **Categoría** | El tipo de socio, que determina cuánto paga de cuota mensual. Hoy son Activo, Cadete y Vitalicio. | Descripción y cuota base. |
| **Socio** | La persona asociada al club. | Nombre, apellido, DNI, email, teléfono, fecha de alta, si está activo y a qué categoría pertenece. |
| **Actividad** | Lo que el club ofrece: Fútbol 5, Natación, Yoga, Tenis, Ajedrez. | Nombre, arancel y cupo de personas. |
| **Inscripción** | El hecho de que un socio se anotó en una actividad. | Qué socio, qué actividad, en qué fecha y con qué arancel entró. |

## 6. Cómo se relacionan

**Una categoría tiene muchos socios, y cada socio pertenece a una sola categoría.** Es la relación simple: cuando cambiamos la cuota de la categoría Cadete, cambia para todos los cadetes de una vez, sin tocar socio por socio.

**Un socio puede estar en muchas actividades y una actividad tiene muchos socios.** Esa relación no se puede guardar en ninguna de las dos fichas, así que existe la inscripción como cosa propia. Y existe por dos motivos, no por uno: además de unir al socio con la actividad, guarda dos datos que no son ni del socio ni de la actividad, sino del hecho de anotarse.

- **La fecha de inscripción.** Cuándo se anotó.
- **El arancel aplicado.** Cuánto se le cobró *en ese momento*.

Ese segundo dato es el que resuelve el problema del precio viejo. El arancel de la actividad es la lista de precios de hoy; el arancel aplicado es la foto del precio que pagó ese socio cuando se anotó. Si el club aumenta Natación de 8500 a 10000, los que ya estaban anotados siguen con 8500 y el sistema lo puede demostrar. Si guardáramos solo el precio en la actividad, el aumento reescribiría la historia de todos.

## 7. Qué se ve en pantalla

Una sola ventana con tres pestañas, para que el administrativo no ande abriendo y cerrando ventanas mientras atiende.

| Pestaña | Qué permite hacer |
|---|---|
| **Socios** | Alta, modificación y baja de socios, con la categoría elegida de una lista. La grilla de abajo muestra el padrón; al tocar una fila se cargan sus datos arriba para editarlos. |
| **Actividades** | Alta, modificación y baja de actividades, con su arancel y su cupo. Misma mecánica de grilla y formulario. |
| **Inscripciones** | Elegir un socio, tildar una o varias actividades y anotarlo. Abajo, elegir una actividad para ver quiénes están anotados y cuántos cupos libres quedan. |

A esas tres se les va a sumar una pantalla de categorías y una de pagos, y a Inscripciones le falta el botón para dar de baja una inscripción.

## 8. Las reglas que el sistema hace cumplir

Esto es el corazón del trabajo: lo que separa un sistema de una planilla de Excel. Están todas verificadas antes de tocar la base, y cuando una no se cumple el usuario ve un aviso que le dice qué pasó.

**Socios**

- El nombre y el apellido tienen al menos dos letras.
- El DNI tiene 7 u 8 dígitos, sin puntos, y no puede repetirse en dos socios.
- El email tiene formato de email; el teléfono admite solo dígitos, espacios, guiones y paréntesis, y puede quedar vacío.
- Todo socio tiene una categoría.
- Un socio con inscripciones no se elimina: se da de baja. Así el club no pierde el registro de que esa persona participó.

**Actividades**

- El nombre tiene entre 3 y 80 caracteres y no puede repetirse.
- El arancel no puede ser negativo y el cupo tiene que ser mayor que cero.
- El cupo no se puede bajar por debajo de la cantidad de socios ya anotados.
- Una actividad con inscriptos no se puede eliminar.
- Cambiar el arancel no modifica lo que se cobró en las inscripciones anteriores.

**Inscripciones**

- Hay que elegir un socio y al menos una actividad.
- Un socio dado de baja no se puede anotar.
- El mismo socio no se puede anotar dos veces en la misma actividad.
- No se puede anotar a nadie si no quedan cupos libres.
- Al anotarse se guarda la fecha del momento y el arancel vigente de la actividad.

## 9. Las operaciones que son todo o nada

La consigna pide manejo de transacciones de negocio, y el negocio del club tiene un caso natural.

**Inscribir a un socio en varias actividades a la vez.** El administrativo tilda Fútbol 5, Natación y Yoga y aprieta Inscribir. Son tres inscripciones separadas, pero para el club es un solo trámite. Si al llegar a la tercera resulta que Yoga ya se llenó, el sistema no puede dejar al socio anotado en las dos primeras: el mostrador le dijo "te anoto en las tres" y le cobró por las tres. Entonces la operación se deshace completa y el socio queda como estaba, con un aviso que dice en qué actividad falló y que no se registró ninguna inscripción.

Dicho de otra manera: las tres inscripciones entran juntas o no entra ninguna. Nunca queda el club con un trámite a medio hacer.

**Registrar el pago de un período _(planificado)_.** El segundo caso de transacción, todavía no construido: registrar que un socio pagó el mes implica guardar el pago y marcar como saldadas la cuota de su categoría más los aranceles de sus actividades. Si algo de eso falla, no puede quedar un pago registrado contra deudas que siguen abiertas. Requiere una quinta tabla de pagos.

## 10. Cómo está construido, en una página

El sistema está separado en cinco capas, cada una con un solo trabajo. La forma más fácil de entenderlo es pensar en cómo circula un papel en la secretaría del club.

| Capa | Su papel en el club | Qué hace |
|---|---|---|
| **UI** (Windows Forms) | La ventanilla donde atiende al socio. | Muestra las pantallas, toma lo que el usuario escribe y es el único lugar donde aparece un cartel. No decide nada. |
| **BLL** | El encargado de la secretaría. | Decide. Acá viven todas las reglas del punto 8 y las transacciones del punto 9. Es la única capa que puede decir "no". |
| **DAL** | El archivo donde están las carpetas. | Habla con la base de datos: busca, guarda, modifica y borra filas. No opina sobre las reglas. |
| **MAPPER** | El que traduce la ficha de cartón a los datos del sistema. | Convierte una fila de la base en un objeto del programa. |
| **Entity** | El formato de la ficha en blanco. | Define qué datos tiene un socio, una actividad, una categoría y una inscripción. No hace nada, solo guarda. |

Las capas se apoyan siempre hacia abajo y nunca hacia arriba: la ventanilla le pide al encargado, el encargado le pide al archivo. La ventanilla no entra al archivo por su cuenta. Eso es lo que hace que una regla de negocio esté escrita en un solo lugar y valga para toda la aplicación.

Cuando algo falla, el problema viaja hacia arriba cambiando de idioma en cada capa. El archivo encuentra un error técnico de la base y lo traduce a "no pude leer los socios". El encargado lo deja pasar o lo reemplaza por una explicación de negocio como "no quedan cupos". La ventanilla lo muestra como un cartel. El usuario nunca ve un error técnico, y nosotros nunca perdemos el detalle original, porque cada traducción se lleva el error anterior adentro.

## 11. Estado al 1/11/2026

| Parte | Estado |
|---|---|
| Base de datos con las cuatro tablas, claves y datos de ejemplo | Listo |
| Arquitectura en capas completa | Listo |
| ABM de socios, con sus reglas | Listo |
| Inscripción de un socio a varias actividades, con transacción | Listo |
| Consulta de inscriptos y cupos libres | Listo |
| ABM de actividades | Hecho, esperando revisión del equipo |
| Baja de inscripción desde la pantalla | Falta la pantalla; la regla ya está |
| ABM de categorías | Pendiente |
| Pagos con su transacción | Pendiente, incluye la quinta tabla |
| Reportes de inscriptos y recaudación | Pendiente |
| Diagrama de base de datos, diagrama de clases y manual de usuario | Pendiente |

El detalle y el reparto de tareas están en el tablero de Trello del grupo.

## 12. Lo que cada uno tiene que poder contar en la defensa

Cinco respuestas. Si las sabemos los cinco, la defensa está ganada.

1. **De qué es el negocio y qué problema resuelve.** Punto 1 de este documento, en treinta segundos.
2. **Por qué la inscripción es una tabla y no un dato del socio.** Porque es una relación de muchos a muchos y porque guarda la fecha y el arancel aplicado, que no pertenecen ni al socio ni a la actividad.
3. **Cuál es la transacción de negocio y por qué hace falta.** Inscribir en varias actividades: si falla una, no puede quedar ninguna registrada.
4. **Dónde está escrita una regla y por qué ahí.** En la capa de negocio, para que valga igual desde cualquier pantalla.
5. **Qué pasa con un error desde la base hasta el usuario.** Se traduce en cada capa, se muestra una sola vez en la pantalla y nunca se pierde el detalle técnico.
