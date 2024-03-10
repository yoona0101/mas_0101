using System;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            int n = 3;
            int[,] a = new int[n, n];
            int[] mas1 = new int[6];
            int[] mas2 = new int[3];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(3, 10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив элементов, лежащих на главной диагонали и выше: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j > i) || (i == j))
                    {
                        mas1[i] = a[i, j];
                        Console.Write(mas1[i] + " ");
                    }

                }
            }
            Console.WriteLine("\nМассив элементов, расположенных ниже главной диагонали: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                    {
                        mas2[i] = a[i, j];
                        Console.Write(mas2[i] + " ");

                    }

                }
            }
            Console.Write("\n");
        }
        catch(Exception) { }
    }
}