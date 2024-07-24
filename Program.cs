// EJERCICIOS POO
using POO_EJERCICIOS.Models;


// 1)  Crear una clase básica y un objeto de esa clase. 
// 2) Utilizar un constructor para inicializar un objeto. 
// 3) Utilizar propiedades para acceder a los campos de una clase. 
// 4) Crear y utilizar métodos dentro de una clase. 

Console.WriteLine("Bienvenido, vamos a registrar un nuevo equipo");
var EquipoNuevo = new Equipo("Atletico Nacional", 26, 8, 1000000, 5, 30);
Console.WriteLine($"el equipo nuevo registrado es: {EquipoNuevo.CantidadHinchada}");
Console.WriteLine($"el equipo:{EquipoNuevo.Nombre} tiene {EquipoNuevo.CantidadDirectivos} directivos");
Console.WriteLine($"las especificaciones del equipo son:"); // aqui se crea el metodo mostrar  y se utiliza
EquipoNuevo.MostrarDetalles();
// 5) Crear una clase Estudiante con propiedades para nombre, edad y matrícula. Crear una lista 
// de estudiantes y agregar varios estudiantes a la lista. Mostrar los detalles de cada 
// estudiante. 

// creamos una lista de estudiantes
var estudiantes = new List<Estudiante>();


//agregamos  elementos a la lista
estudiantes.Add(new Estudiante(nombre: "Camilo Ruiz", edad: 19, matricula: 123433389));
estudiantes.Add(new Estudiante(nombre: "Diana Correa", edad: 18, matricula: 987612221));
estudiantes.Add(new Estudiante(nombre: "John Doe", edad: 20, matricula: 123456789));
estudiantes.Add(new Estudiante(nombre: "Jane Smith", edad: 22, matricula: 987654321));

Console.WriteLine(estudiantes.Count);
Console.WriteLine("los detalles de cada estudiante son los siguientes:");
foreach (var estudiante in estudiantes)
{
    estudiante.MostrarEstudiante();
}

// 6) Crear una clase Habitacion y una clase Reserva. La clase Habitacion debe tener propiedades 
// como número de habitación y tipo. La clase Reserva debe tener propiedades como fecha 
// de inicio, fecha de fin y la habitación reservada. 


// 7) Crear una clase Prenda con propiedades para nombre, talla y precio. Crear una clase Tienda 
// que gestione una colección de prendas y permita agregar y buscar prendas. 
// 8) Crear una clase Empleado con propiedades para nombre, cargo y salario. Crear una clase 
// Empresa que gestione una colección de empleados y permita agregar y buscar empleados. 
// 9) Crear una clase Curso con propiedades para nombre, código y duración. Crear una clase 
// Escuela que gestione una colección de cursos y permita agregar y buscar cursos. 
// 10) Crear una clase base Figura con un método CalcularArea. Crear clases derivadas Circulo y 
// Rectangulo que sobrescriban el método CalcularArea. 
// 11) Crear una clase base Vehiculo con un método Arrancar. Crear clases derivadas Coche y Moto 
// que sobrescriban el método Arrancar. 
// 12) Crear una clase base Empleado con un método Trabajar. Crear clases derivadas Desarrollador 
// y Gerente que sobrescriban el método Trabajar. 
// 13) Crear una jerarquía de clases para representar diferentes tipos de transporte (coche, 
// bicicleta, autobús). Implementar métodos para iniciar el viaje, detener el viaje y obtener 
// detalles del viaje. 
// 14) Crear una jerarquía de clases para representar diferentes tipos de productos (Electrónico, 
// Ropa, Alimento). Implementar métodos para calcular el precio final (con impuestos) y 
// mostrar los detalles del producto. 
// 15) Crear una jerarquía de clases para representar diferentes tipos de personal (Doctor, 
// Enfermera, Administrativo). Implementar métodos para mostrar detalles del personal y 
// calcular el salario. 

