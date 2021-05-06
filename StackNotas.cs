using System;
using System.Collections.Generic;

namespace Stack
{
    class StackNotas
    {
        List<string> notas = new List<string>();

        // Push -> Agregar elemento
        // Peek -> Ver elemento de arriba
        // Pop -> Ver + Quitar
        // Saber cuántos elementos tiene dentro

        public int Count 
        {
            get => this.notas.Count;
        }

        // Imprimir stack

        public void Push(string nota)
        {
            // La parte de arriba del Stack es el final de la List
            this.notas.Add(nota);
        }

        public string Pop() // Pop = quitar el valor que está arriba y devolverlo
        {
            // 1. Devolver valor
            // 2. Borrar 

            // ...Excepto cuando no hay nada que borrar
            if (this.notas.Count == 0)
            {
                return null;
            }

            //Respaldar el valor
            string value = this.notas[this.notas.Count - 1];
            //Borrar de la lista
            this.notas.RemoveAt(this.notas.Count -1);
            
            // Devolver el valor respaldado
            return value; // <----- La función llega hasta aquí 
        }

        public string Peek()
        {
            // Count 5 -> 4
            // Count 3 -> 2
            // Count 0 -> -1 (Exception!)
            if (this.notas.Count == 0)
            {
                Console.WriteLine("No hay elementos en el Stack");
                return null;
            }
            else
            {
                return this.notas[this.notas.Count - 1];
            }
        }

        public void PrintStack()
        {
            // TODO: implementar

            // for (int i = 0; i < notas.Count; i++)
            // {
            //     Console.WriteLine(notas[i]);
            // }

            for (int i = this.notas.Count -1; i >= 0; i--)
            {
                Console.WriteLine(notas[i]);
            }
        }
    }
}