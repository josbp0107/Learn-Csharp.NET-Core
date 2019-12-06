﻿using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
           var engine = new EscuelaEngine();
           engine.Inicializar();

           WriteLine("==========");
           ImprimirCursosEscuelas(engine.Escuela);
           
        }

        // private static bool Predicado(Curso obj)
        // {
        //     return obj.Nombre == "301";
        // }

        private static void ImprimirCursosEscuelas(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }

        }

    }
}
