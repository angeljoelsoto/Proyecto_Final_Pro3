
using System; 
namespace practico{
    class Matriz{

//EJERCICIO 1
static void ejercicio1()
    {
        int[,] matriz = new int[5, 5];

        int numero = 1;
        for (int fila = 4; fila >= 0; fila--) 
        {
            for (int columna = fila; columna >= 0; columna--)
            {
                matriz[fila, columna] = numero;
                numero++;
            }
        }

 Console.WriteLine(" Matriz triangular " );
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
    }
    //ejercicio 2 
    static void ejercicio2()
    {
        int[,] matriz = new int[5, 5];
        
        int numero = 1;
        for (int fila = 4; fila >= 0; fila--)
        {
            for (int columna = fila; columna >= 0; columna--)
            {
                matriz[fila, columna] = numero;
                numero++;
            }
        }

        Console.WriteLine("Matriz triangular 2 ");
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
    }
    //EJERCICIO 3 
    static void ejercicio3()
    {
        int[,] matriz = new int[4, 5];

        int numero = 1;
        for (int fila = 0; fila < 4; fila++)
        {
          if (fila % 2 == 0)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    matriz[fila, columna] = numero;
                    numero++;
                }
            }
            else 
            {
                for (int columna = 4; columna >= 0; columna--)
                {
                    matriz[fila, columna] = numero;
                    numero++;
                }
            }
        }
        Console.WriteLine("Matriz serpiente ");
        for (int columna = 0; columna < 5; columna++)
        {
            for (int fila = 0; fila < 4; fila++)
            {
                Console.Write(matriz[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
    }
    //EJERCICIO 4
    static void ejercicio4()
    {
        int[,] cuadradoMagico = new int[5, 5];

        int fila = 0;
        int columna = 2;
        int numero = 1;

        while (numero <= 25)
        {
            cuadradoMagico[fila, columna] = numero;
            numero++;

            int nuevaFila = (fila - 1 + 5) % 5;
            int nuevaColumna = (columna + 1) % 5;

            if (cuadradoMagico[nuevaFila, nuevaColumna] != 0)
            {
                nuevaFila = (fila + 1) % 5;
                nuevaColumna = columna;
            }

            fila = nuevaFila;
            columna = nuevaColumna;
        }
        Console.WriteLine("Matriz cuadrado magico ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(cuadradoMagico[i, j] + "\t");
            }
            Console.WriteLine();
        }
 
   }
   //EJERCICIO 5
   static void ejercicio5()
    {
        int[,] matriz = new int[5, 5]
        {
            { 5, 4, 3, 2, 1 },
            { 4, 4, 3, 2, 1 },
            { 3, 3, 3, 2, 1 },
            { 2, 2, 2, 2, 1 },
            { 1, 1, 1, 1, 1 }
        };
        Console.WriteLine("Matriz repetida ");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
}



