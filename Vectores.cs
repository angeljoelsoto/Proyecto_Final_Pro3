using System;
namespace practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio5();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Ingrese los elementos del vector separados por espacios:");
            string[] valores = Console.ReadLine().Split(' ');

            int[] vector = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                vector[i] = Convert.ToInt32(valores[i]);
            }

            int cantidadPares = ContarNumerosPares(vector);

            Console.WriteLine("La cantidad de números pares en el vector es: " + cantidadPares);
        }

        static int ContarNumerosPares(int[] vector)
        {
            int count = 0;

            foreach (int num in vector)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ingrese los elementos del vector separados por espacios:");
            string[] valores = Console.ReadLine().Split(' ');

            int[] vector = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                vector[i] = Convert.ToInt32(valores[i]);
            }

            // Ordenar el vector utilizando MergeSort
            MergeSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vector ordenado:");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
        }

        static void MergeSort(int[] vector, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int medio = (inicio + fin) / 2;

                MergeSort(vector, inicio, medio);
                MergeSort(vector, medio + 1, fin);

                Merge(vector, inicio, medio, fin);
            }
        }

        static void Merge(int[] vector, int inicio, int medio, int fin)
        {
            int n1 = medio - inicio + 1;
            int n2 = fin - medio;

            int[] izquierda = new int[n1];
            int[] derecha = new int[n2];

            Array.Copy(vector, inicio, izquierda, 0, n1);
            Array.Copy(vector, medio + 1, derecha, 0, n2);

            int i = 0, j = 0;
            int k = inicio;

            while (i < n1 && j < n2)
            {
                if (izquierda[i] <= derecha[j])
                {
                    vector[k] = izquierda[i];
                    i++;
                }
                else
                {
                    vector[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                vector[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                vector[k] = derecha[j];
                j++;
                k++;
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ingrese los elementos del vector separados por espacios:");
            string[] valores = Console.ReadLine().Split(' ');

            int[] vector = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                vector[i] = Convert.ToInt32(valores[i]);
            }

            InsertionSort(vector);

            Console.WriteLine("Vector ordenado:");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
        }

        static void InsertionSort(int[] vector)
        {
            for (int i = 1; i < vector.Length; i++)
            {
                int key = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > key)
                {
                    vector[j + 1] = vector[j];
                    j = j - 1;
                }
                vector[j + 1] = key;
            }
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese los elementos del vector separados por espacios:");
            string[] valores = Console.ReadLine().Split(' ');

            int[] vector = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                vector[i] = Convert.ToInt32(valores[i]);
            }

            Console.Write("Ingrese el dato que desea eliminar del vector: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Eliminar el dato x del vector
            vector = EliminarDato(vector, x);

            Console.WriteLine("Vector después de eliminar el dato " + x + ":");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
        }

        static int[] EliminarDato(int[] vector, int x)
        {
            int count = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] != x)
                {
                    vector[count] = vector[i];
                    count++;
                }
            }
            Array.Resize(ref vector, count);
            return vector;
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ingrese los elementos del vector separados por espacios:");
            string[] valores = Console.ReadLine().Split(' ');

            int[] vector = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                vector[i] = Convert.ToInt32(valores[i]);
            }

            Console.WriteLine("Ingrese el índice de inicio (a):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el índice de fin (b):");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && b < vector.Length && a <= b)
            {
                InvertirParteVector(vector, a, b);

                Console.WriteLine("Vector con la parte invertida:");
                foreach (int num in vector)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Los índices ingresados están fuera de rango.");
            }
        }

        static void InvertirParteVector(int[] vector, int inicio, int fin)
        {
            while (inicio < fin)
            {
                int temp = vector[inicio];
                vector[inicio] = vector[fin];
                vector[fin] = temp;
                inicio++;
                fin--;
            }
        }
    }
}