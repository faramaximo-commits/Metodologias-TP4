# 🧠 Metodologías - Proyecto C#

Este repositorio contiene la implementación de distintos patrones de diseño y conceptos de programación orientada a objetos desarrollados en C#, correspondientes a las prácticas de la materia **Metodología de la Programación**.

---

## 📁 Estructura del Proyecto

### 🔹 **Adapter**
Contiene las clases relacionadas con el **patrón Adapter**, utilizadas para adaptar objetos `Alumno` al contexto del sistema MDPI.
- `AlumnoAdapter.cs`: adapta la interfaz de `Alumno` a la de `StudentMDPI`.

---

### 🔹 **Colecciones**
Implementaciones de estructuras de datos utilizadas en las prácticas.
- `Cola.cs`: implementación de una cola (FIFO).
- `ColeccionMultiple.cs`: permite iterar sobre varias colecciones a la vez.
- `Conjunto.cs`: colección sin elementos repetidos.
- `IColeccionable.cs`: interfaz que define las operaciones básicas de una colección.
- `Pila.cs`: implementación de una pila (LIFO).

---

### 🔹 **Decorator**
Contiene todas las clases del **patrón Decorator**, utilizadas para agregar responsabilidades dinámicamente a los objetos `Alumno`.
- `DecoradorAlumno.cs`: clase base abstracta para todos los decoradores.
- `DecoradorConLegajo.cs`: agrega el legajo del alumno en la visualización.
- `DecoradorConOrden.cs`: muestra el orden del alumno.
- `DecoradorConRecuadro.cs`: enmarca la información del alumno con asteriscos.
- `DecoradorNotaEnLetras.cs`: muestra la nota en palabras además de en número.
- `DecoradorPromocion.cs`: indica si el alumno está **Aprobado**, **Promocionado** o **Desaprobado**.

---

### 🔹 **Estrategias**
Implementa el **patrón Strategy**, permitiendo comparar alumnos según distintos criterios.
- `CompararAlumnoCalificacion.cs`: compara por calificación numérica.
- `CompararAlumnoDni.cs`: compara por DNI.
- `CompararAlumnoLegajo.cs`: compara por legajo.
- `CompararAlumnoNombre.cs`: compara por nombre.
- `CompararAlumnoPromedio.cs`: compara por promedio.
- `IEstrategiaComparacion.cs`: interfaz común para todas las estrategias.

---

### 🔹 **Fabricas**
Implementa el **patrón Factory Method** para crear distintos tipos de objetos.
- `FabricaDeAlumnosMuyEstudiosos.cs`: genera instancias de `AlumnoMuyEstudioso`.
- `FabricaDeAlumnosNormales.cs`: genera instancias de `AlumnoNormal`.
- `FabricaDeComparables.cs`: clase abstracta base para las fábricas.
- `FabricaDeNumeros.cs`: genera instancias de `Numero`.
- `FabricaDeProfesores.cs`: genera instancias de `Profesor`.
- `LectorDeDatos.cs`: facilita la entrada de datos por teclado.
- `StudentsFactory.cs`: crea instancias de alumnos decorados y adaptados (ejercicio 7).

---

### 🔹 **Iteradores**
Implementa el **patrón Iterator**, permitiendo recorrer las colecciones.
- `IIterable.cs`: interfaz que define las operaciones de iteración.
- `IIterador.cs`: interfaz para crear iteradores concretos.
- `IteradorCola.cs`: iterador específico para colas.
- `IteradorConjunto.cs`: iterador para conjuntos.
- `IteradorPila.cs`: iterador para pilas.

---

### 🔹 **MDPI**
Contiene las clases relacionadas con el sistema de enseñanza MDPI.
- `MDPI.cs`: incluye las clases `TeacherMDPI` y `StudentMDPI`, que simulan el entorno del profesor y los estudiantes.

---

### 🔹 **Objetos**
Define las clases base y entidades principales del dominio.
- `Alumno.cs`: clase abstracta base de los alumnos.
- `AlumnoMuyEstudioso.cs`: alumno que siempre obtiene mejores notas.
- `AlumnoNormal.cs`: alumno con comportamiento estándar.
- `IAlumno.cs`: interfaz que define el contrato común de un alumno.
- `IComparable.cs`: interfaz genérica de comparación.
- `Numero.cs`: implementación de un objeto comparable numérico.
- `Persona.cs`: clase base para entidades con nombre y DNI.
- `Profesor.cs`: representa a un profesor.

---

### 🔹 **Observer**
Implementa el **patrón Observer** (si se usa en versiones posteriores del trabajo).
- `IObservador.cs`: interfaz que define los observadores.

---

### 🔹 **Otros**
Contiene clases auxiliares de utilidad.
- `Funciones.cs`: métodos de apoyo para operaciones varias.
- `GeneradorDeDatos.cs`: genera datos aleatorios (nombres, números, etc.).

---

### 🔹 **Program**
Punto de entrada del sistema.
- `Program.cs`: contiene el método `Main`, que ejecuta las pruebas principales del sistema (instanciación de `Teacher`, generación de `Students` y evaluación de la clase).

---

## 🧩 Patrones Implementados

- Adapter  
- Decorator  
- Strategy  
- Factory Method  
- Iterator  
- (Opcional: Observer)

---

## 🚀 Ejecución
Para probar el sistema, ejecutar el método `Main` del archivo `Program.cs`.  
Este instancia un `TeacherMDPI`, crea 20 `Students` (10 normales y 10 muy estudiosos), los adapta y decora, y finalmente muestra sus calificaciones decoradas en consola.

---

© Proyecto académico - Universidad Nacional Arturo Jauretche (UNAJ)
