using System;
namespace practico
{
public class Numeros
{
    public static void ejercicio1()
    {
        Console.WriteLine("Ingrese un número para encontrar el mayor de sus dígitos:");
        int numero = int.Parse(Console.ReadLine());
        int mayor = ObtenerMayor(numero);
        Console.WriteLine($"El mayor dígito del número es: {mayor}");
    }

    public static void ejercicio2()
    {
        Console.WriteLine("Ingrese un número para calcular la suma de sus dígitos pares:");
        int numero = int.Parse(Console.ReadLine());
        int sumaPares = SumaDigitosPares(numero);
        Console.WriteLine($"La suma de los dígitos pares del número es: {sumaPares}");
    }

    public static void ejercicio3()
    {
        Console.WriteLine("Ingrese un número para llevar su mayor dígito al final:");
        int numero = int.Parse(Console.ReadLine());
        MoverMayor(ref numero);
        Console.WriteLine($"El número después de mover el mayor dígito al final es: {numero}");
    }

    public static void ejercicio4()
    {
        Console.WriteLine("Ingrese un número para verificar si está ordenado en sus dígitos:");
        int numero = int.Parse(Console.ReadLine());
        bool ordenado = EstaOrdenado(numero);
        Console.WriteLine($"¿El número está ordenado en sus dígitos? {ordenado}");
    }

    public static void ejercicio5()
    {
        Console.WriteLine("Ingrese un número para contar los dígitos impares antes de uno par:");
        int numero = int.Parse(Console.ReadLine());
        int cantDigPares = CantDigPares(numero);
        Console.WriteLine($"La cantidad de dígitos impares que están antes de uno par es: {cantDigPares}");
    }

    private static int ObtenerMayor(int num)
    {
        int mayor = 0;
        while (num > 0)
        {
            int digito = num % 10;
            mayor = Math.Max(mayor, digito);
            num /= 10;
        }
        return mayor;
    }

    private static int SumaDigitosPares(int num)
    {
        int suma = 0;
        while (num > 0)
        {
            int digito = num % 10;
            if (digito % 2 == 0)
                suma += digito;
            num /= 10;
        }
        return suma;
    }

    private static void MoverMayor(ref int num)
    {
        int mayor = ObtenerMayor(num);
        num = int.Parse(num.ToString().Replace(mayor.ToString(), "") + mayor.ToString());
    }

    private static bool EstaOrdenado(int num)
    {
        int previo = 10;
        while (num > 0)
        {
            int digito = num % 10;
            if (digito > previo)
                return false;
            previo = digito;
            num /= 10;
        }
        return true;
    }

    private static int CantDigPares(int num)
    {
        int cantidad = 0;
        bool encontradoPar = false;

        while (num > 0)
        {
            int digito = num % 10;
            if (!encontradoPar && digito % 2 == 0)
                encontradoPar = true;
            else if (encontradoPar && digito % 2 != 0)
                cantidad++;
            num /= 10;
        }

        return cantidad;
    }
}
}