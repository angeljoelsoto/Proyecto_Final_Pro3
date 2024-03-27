using System;
namespace practico
{
    public class Practico
    {
        static void Main(String[] args)
        {
         int n = 5; // Puedes cambiar este valor para probar con diferentes términos de la serie
        CalcularTermino(n);
        }

    static void CalcularTermino(int n)
    {
        if (n <= 0)
        {
            Console.WriteLine("El valor de n debe ser positivo.");
            return;
        }

        int[] serie = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            if (i < 3)
                serie[i] = i + 1;
            else
                serie[i] = serie[i - 1] + serie[i - 2] + serie[i - 3];
        }

        Console.WriteLine($"El término {n} de la serie es: {serie[n - 1]}");
    }
}
               
}