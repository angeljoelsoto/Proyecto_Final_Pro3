using System;
using System.Collections.Generic;
namespace practico{
class Serie
{

    static void ejercicio1(int n)
    {
        int resultado = CalcularFibonacci(n);
        Console.WriteLine($"El {n}-ésimo término de la serie de Fibonacci es: {resultado}");
    }

    static void ejercicio2(int n)
    {
        int resultado = CalcularSerie1(n);
        Console.WriteLine($"El {n}-ésimo término de la serie 1 es: {resultado}");
    }

    static void ejercicio3(int n)
    {
        int resultado = CalcularSumaSerie(n);
        Console.WriteLine($"La suma de los primeros {n} términos de la serie es: {resultado}");
    }

    static void ejercicio4(int n)
    {
        int resultado = CalcularSerie2(n);
        Console.WriteLine($"El {n}-ésimo término de la serie 2 es: {resultado}");
    }

    static void ejercicio5(int n)
    {
        List<int> serie = GenerarSerie(n);
        int sumaPares = SumarNumerosPares(serie);
        Console.WriteLine($"La suma de los números pares hasta el {n}-ésimo término de la serie 2 es: {sumaPares}");
    }

    static List<int> GenerarSerie(int n)
    {
        List<int> serie = new List<int>();
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            serie.Add(num);
            if (i % 2 != 0)
            {
                num *= 2;
            }
            else
            {
                num += 1;
            }
        }
        return serie;
    }










    static int SumarNumerosPares(List<int> serie)
    {
        int suma = 0;
        for (int i = 0; i < serie.Count; i++)
        {
            if (serie[i] % 2 == 0)
            {
                suma += serie[i];
            }
        }
        return suma;
    }







    static int CalcularFibonacci(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("El valor de n debe ser mayor que cero.");
        }

        if (n == 1 || n == 2)
        {
            return n - 1; // Los primeros dos términos de Fibonacci son 0 y 1
        }

        int a = 0;
        int b = 1;
        int result = 0;

        for (int i = 2; i < n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }

    static int CalcularSerie1(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        int valor = 1;
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                valor *= 2;
            }
            else
            {
                valor += 1;
            }
        }

        return valor;
    }

    static int CalcularSumaSerie(int n)
    {
        // La serie es una progresión aritmética donde d = 2
        // La suma de los primeros n términos es n * (primer término + último término) / 2
        return n * (0 + 2 * (n - 1)) / 2;
    }

    static int CalcularSerie2(int n)
    {
        if (n == 1)
        {
            return 2;
        }
        else
        {
            int previo = CalcularSerie2(n - 1);
            return previo * 2 + 1;
        }
    }
}
}