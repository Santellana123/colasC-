using System;
using System.Collections;
// Crear una cola
Queue miCola = new Queue();
int a = 1;
do
{
    Console.WriteLine("Seleccione una operación:");
    Console.WriteLine("1. Agregar elemento a la cola");
    Console.WriteLine("2. Eliminar elemento de la cola");
    Console.WriteLine("3. Imprimir la cola");
    Console.WriteLine("4. Salir");

    int opcion;
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Clear();
        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el elemento a agregar: ");
                if (int.TryParse(Console.ReadLine(), out int elementoAgregar))
                {
                    EnqueueElemento(miCola, elementoAgregar);
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor entero válido.");
                }
                break;
            case 2:
                DequeueElemento(miCola);
                break;
            case 3:
                ImprimirCola(miCola);
                break;
            case 4:
                Console.WriteLine("Saliendo del programa.");
                a =2;
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
    }

} while (a==1);


// Método para insertar elementos en la cola
static void EnqueueElementos(Queue cola, int elemento)
{
    cola.Enqueue(elemento);
    Console.WriteLine($"Se agregó el elemento {elemento} a la cola.");
}

// Método para eliminar un elemento de la cola
static void DequeueElemento(Queue cola)
{
    if (cola.Count > 0)
    {
        int elementoEliminado = (int)cola.Dequeue();
        Console.WriteLine($"Se eliminó el elemento {elementoEliminado} de la cola.");
    }
    else
    {
        Console.WriteLine("La cola está vacía. No se puede eliminar ningún elemento.");
    }
}

// Método para imprimir la cola
static void ImprimirCola(Queue cola)
{
    Console.Write("Contenido de la cola: ");
    foreach (var elemento in cola)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}
static void EnqueueElemento(Queue cola, int elemento)
{
    cola.Enqueue(elemento);
    Console.WriteLine($"Se agregó el elemento {elemento} a la cola.");
}