using System;

namespace mas_0101_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] A = new double[10];
                Console.WriteLine("Введите число: ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num > 0)
                {
                    A[0] = num;
                }
                else
                { 
                    throw new Exception("Недопустимый аргумент");
                }
                Console.Write($"Массив A: {A[0]} ");
                for (int i = 1; i < 10; i++)
                {
                    A[i] = A[i / 2] + A[i - 1];
                    Console.Write($"{A[i]} ");
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("Неверный формат");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
