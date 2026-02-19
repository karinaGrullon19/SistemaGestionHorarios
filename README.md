# Sistema de Gestión de Horarios Académicos

## Descripción del Proyecto
Este sistema tiene como objetivo gestionar los horarios académicos de una institución educativa, permitiendo la asignación de aulas, docentes y materias sin que existan conflictos de horario.

## Funcionalidades
- Registro de docentes
- Registro de aulas
- Registro de asignaturas
- Asignación de horarios
- Validación de conflictos de horario

## Tecnologías Utilizadas
- Lenguaje de programación: C#
- Base de datos: SQL Server
- Control de versiones: GitHub

## Instalación
1. Clonar el repositorio
2. Abrir el proyecto en Visual Studio
3. Ejecutar el sistema

## Uso del Sistema
El usuario podrá crear, modificar y eliminar horarios académicos, asignando aulas y docentes disponibles en los horarios seleccionados.

## Validación de Conflictos
El sistema valida que:
- Un docente no tenga dos clases al mismo tiempo
- Un aula no esté asignada a más de una clase en el mismo horario
