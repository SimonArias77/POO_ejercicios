using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// 5) Crear una clase Estudiante con propiedades para nombre, edad y matrícula. Crear una lista 
// de estudiantes y agregar varios estudiantes a la lista. Mostrar los detalles de cada 
// estudiante. 

namespace POO_EJERCICIOS.Models;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Matricula { get; set; }

    public Estudiante(string nombre, int edad, int matricula)
    {
        Nombre = nombre;
        Edad = edad;
        Matricula = matricula;
    }

    public void MostrarEstudiante()
    {
        Console.WriteLine($"los detalles del estudiante son los siguientes: {Nombre}, {Edad}, {Matricula}");
    }
}

