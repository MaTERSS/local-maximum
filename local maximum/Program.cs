/*
 Дан одномерный массив целых чисел из 30 элементов.
Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он больше своих соседей)
Крайний элемент является локальным максимумом, если он больше своего соседа.
Программа должна работать с массивом любого размера.
Массив всех локальных максимумов не нужен.
*/

using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {            
            int elements = 30;
            int minValue = 0;
            int maxValue = 51;
            int[] numbers = new int[elements];

            Random random = new Random();

            Console.WriteLine("Исходный массив:");
;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue); 
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Локальные максимумы:");
            for (int i = 0; i < numbers.Length; i++)
            {                
                if (i == 0) 
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                else if (i == numbers.Length - 1) 
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                else 
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
            }
        }
    }
}