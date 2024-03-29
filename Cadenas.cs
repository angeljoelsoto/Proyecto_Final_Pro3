using System;

public class Cadenas
{
    public static void ejercicio1()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();

        int cantidadPalabras = ContarPalabras(texto);
        Console.WriteLine("Cantidad de palabras en el texto: " + cantidadPalabras);
    }

    
    private static int ContarPalabras(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
            return 0;

        int cantidadPalabras = 0;

        string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        cantidadPalabras = palabras.Length;

        return cantidadPalabras;
    }

    public static void ejercicio2()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string cadenaOrigi = Console.ReadLine();

        string EVocales = EliminarVocales(cadenaOrigi);
        Console.WriteLine(EVocales);
    }

    public static string EliminarVocales(string input)
    {
        string result = "";
        foreach (char character in input)
        {
            if (!"aeiouAEIOU".Contains(character))
            {
                result += character;
            }
        }
        return result;
    }

    public static void ejercicio3()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string text = Console.ReadLine();

        string Grande = EncontrarPalabraMasLarga(text);
        Console.WriteLine("La palabra mas larga es: " + Grande);
    }


    public static string EncontrarPalabraMasLarga(string cadena)
    {
        string[] palabras = cadena.Split(new char[] { ' ', ',', '.', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        
        string palabraMasLarga = "";
        
        foreach (string palabra in palabras)
        {
            if (palabra.Length > palabraMasLarga.Length)
            {
                palabraMasLarga = palabra;
            }
        }
        
        return palabraMasLarga;
    }

    



    public static void ejercicio4()
    {
        Console.WriteLine("Ingrese una oracion:");
        string palabra = Console.ReadLine();
        
        string palabraSinPrimeraLetra = EliminarPrimerasLetrasCadaPalabra(palabra);
        
        Console.WriteLine("Palabras sin la primera letra: " + palabraSinPrimeraLetra);
    }

    public static string EliminarPrimerasLetrasCadaPalabra(string oracion)
    {
        string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < palabras.Length; i++)
        {
            if (palabras[i].Length > 1)
            {
                palabras[i] = palabras[i].Substring(1);
            }
            else
            {
                palabras[i] = ""; 
            }
        }
        return string.Join(" ", palabras);
    }

    public static void ejercicio5()
    {
        Console.WriteLine("Ingrese una oracion:");
        string palabra = Console.ReadLine();
        
        string palabraSinPrimeraLetra = InvertirPalabras(palabra);
        
        Console.WriteLine("palabras invertidas: " + palabraSinPrimeraLetra);
    }

    public static string InvertirPalabras(string oracion)
    {
        string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < palabras.Length; i++)
        {
            palabras[i] = InvertirString(palabras[i]);
        }
        return string.Join(" ", palabras);
    }

    public static string InvertirString(string str)
    {
        char[] caracteres = str.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }





}
