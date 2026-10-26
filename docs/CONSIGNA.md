# Consigna del Trabajo Práctico Integrador

Copiada del foro "Trabajo práctico integrador" del campus (módulo Evaluación para la acreditación), tal como estaba publicada el 26/10/2026.

Se solicita el desarrollo de un negocio. El mismo contará con distintas entregas parciales y finalizará en la "entrega final", al final del cuatrimestre, donde cada equipo debe defender el sistema desarrollado.

## Entregas parciales

1. **Presentación y defensa del negocio.** Debe ser lo suficientemente complejo como para tener, al menos, tres tablas para persistir en una base de datos y algún tipo de relación entre todas.
2. **Presentación de la base de datos.** Tablas con todos sus campos completos, toda tabla con clave primaria, tipos de datos correctos y alguna relación entre tablas.
3. **Presentación inicial de la solución.** Arquitectura en capas. Todavía sin persistir en la base, pero con toda la estructura, la mayoría de los formularios y la mayoría de las reglas de negocio desarrolladas o propuestas.
4. **Presentación parcial de la solución.** Todo lo anterior, y la aplicación consultando y manipulando la base de datos.
5. **Presentación final y defensa.** La aplicación completa funcionando, con manejo de transacciones de negocio, y defensa oral del equipo.

## Documentación que acompaña la entrega

1. Carátula y descripción del sistema
2. Diagrama de base de datos
3. Diagrama de clases
4. Manual de usuario

## Puntos adicionales

- Git para la persistencia y seguimiento del código
- Jira, Trello o similar para la gestión de tareas y del equipo

## Cómo lo cubre ClubGestion

| Entrega | Estado al 26/10 |
|---|---|
| 1. Negocio | Club de barrio: CATEGORIA, SOCIO, ACTIVIDAD e INSCRIPCION (cuatro tablas, una 1:N y una N:M con atributos). Falta presentarlo. |
| 2. Base de datos | `script_base_de_datos.sql` con PK, FK, UNIQUE, CHECK y datos. Falta el diagrama. |
| 3. Solución inicial en capas | Entity, MAPPER, DAL, BLL y UI armados; reglas de negocio de socios e inscripciones en la BLL. Faltan formularios de actividades, categorías y pagos. |
| 4. Persistencia | ABM de socios e inscripciones ya leen y escriben en la base. |
| 5. Transacciones de negocio | `InscripcionBLL.Inscribir` con TransactionScope. Falta la de pagos. |
| Documentación | Pendiente completa. |
| Git y Trello | Repo público y tablero creados el 26/10. |
