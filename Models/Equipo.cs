using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 1)  Crear una clase básica y un objeto de esa clase. 
// 2) Utilizar un constructor para inicializar un objeto. 
// 3) Utilizar propiedades para acceder a los campos de una clase. 
// 4) Crear y utilizar métodos dentro de una clase. 

namespace POO_EJERCICIOS.Models;

public class Equipo
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public int CantidadJugadores { get; set; }
    public int CantidadCuerpoTecnico { get; set; }
    public int CantidadHinchada { get; set; }
    public int CantidadDirectivos { get; set; }
    public int CantidadOficiosVarios { get; set; }

    public Equipo(string nombre,  int cantidadJugadores, int  cantidadCuerpoTecnico, int cantidadHinchada, int cantidadDirectivos, int cantidadOficiosVarios)
    {
        Id = new Guid();
        Nombre = nombre;
        CantidadJugadores = cantidadJugadores;
        CantidadCuerpoTecnico = cantidadCuerpoTecnico;
        CantidadHinchada = cantidadHinchada;
        CantidadDirectivos = cantidadDirectivos;
        CantidadOficiosVarios = cantidadOficiosVarios;
    }

    public void MostrarDetalles() // la palabra "void" se utiliza para que no retorne nada
    {
        Console.WriteLine($"Id: {Id}, Jugadores: {CantidadJugadores}, Cuerpo Técnico: {CantidadCuerpoTecnico}, Hinchada: {CantidadHinchada}, Directivos: {CantidadDirectivos}, Oficios Varios: {CantidadOficiosVarios}");
    }

    public void JugarFutbol()
    {
        Console.WriteLine("El equipo está jugando futbol.");
    }

}


