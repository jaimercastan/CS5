using System;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30092026
            // Sintaxis: while
            // Inicializacion;
            // while(expresion)
            // {
            //      Bloque de Instrucciones
            //      iterador;
            // }
            // Iterar: repetir
            // Ejemplo 1: Ciclo Ascendente (rango: 1-3)
            // m: variable de control
            int m = 1; // Inicializacion
            while(m <= 3)
            {
                // Bloque de instrucciones
                m += 1;
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador 
            }
            // Ejercitacion
            // 1. Definir un ciclo para imprimir tu nombre 5 veces
            // Nota: Para la expresion, utilizar el operador <.

            int n = 0;
            while(n < 5)
            {
                Console.WriteLine($"Tu nombre: Jaime Castan");
                n += 1; // Iterador
            }

            //b. Ciclo descendente
            int d = 3;
            while(d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;

            }
            //c. Incrementos
            // Secuancia: 3 6 9 12 15 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {1}");
                i += 3;
            }
            // d. Decrementos
            // Ejercitacion
            // 1. Definir un ciclo para imprimir "331" 8 veces.
            // Nota: Para la solucion, define un ciclo descendente con devrementos de 2 unidades
            int a = 16;
            while(a > 0)
            {
                Console.WriteLine("331");
                a -= 2;
               
            }
            // Actividad 1: Ciclo infinito
            // 1. Definir un ciclo infinito ascendente
            // 2. Definir un ciclo infinito descendente
            // Nota: Para la solucion, utilizar el operador de diferencia.

            int k = 0;
            while (k >= -1)
            {
                Console.WriteLine($"k: {k}");
                k += 1;
            }
            int e = 0;
            while (e != 1)
            {
                Console.WriteLine($"e: {e}");
                e -= 1;
            }

        }
    }
}