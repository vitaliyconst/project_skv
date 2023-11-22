using System;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_2
{

    class Program
    {

        static void ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for (int i = 0, j = (array.Length - 1); 
                j >= 0; i++, j--) 
            {
                reverseArray[j] = array[i];

            }

            Console.Write("\n\t Reverse array: ");
            
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.Write($"{reverseArray[i]} ");
            }

        }

      static  int[] SubArray(int[] array, int index, int count)
        {
            int [] newArray = new int [count];

            if (index > array.Length)
            {
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = 1;
                }
            }
            else
            {
                for (int j = 0, i = index; j < count ; i++, j++)
                {
                    if (i < array.Length)
                    { newArray[j] = array[i]; }
                    else
                    {
                        { newArray[j] = 1; }
                    }

                }
            }

            ShowArray(newArray, count);
            return newArray;
        }

        static void ShowArray(int[] array, int size)
        {
            Console.Write("\n\t New array = ");
            for (int i = 0; i < size ; i++)
            {
                Console.Write("{0} ", array[i]);
            }

        }


        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* 
             * Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
             * Потрібно:
             * 1) Створити метод MyReverse(int [ ] array),
             * який приймає як аргумент масив цілих чисел і повертає 
             * інвертований масив (елементи масиву у зворотному порядку).
             * 2) Створіть метод int [] SubArray (int [] array, int index, int count). 
             * Метод повертає частину отриманого як аргумент масиву, починаючи з позиції 
             * зазначеної в аргументі index, розмірністю, яка відповідає значенню аргументу count.
             * Якщо аргумент count містить значення більше, ніж кількість елементів, 
             * які входять до частини вихідного масиву (від зазначеного індексу index, 
             * до індексу останнього елемента), то при формуванні нового масиву розмірністю в count, 
             * заповніть одиницями ті елементи, які не були скопійовані з вихідного масиву. 
             */

            int sizeOfArray = 10;
            int[] array = new int[sizeOfArray];
            Random rndnum = new Random();

            Console.Write("\n\tOriginal array: ");

            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = rndnum.Next(1, 20);
                Console.Write($"{array[i]} ");
            }

            ReverseArray(array);

            Console.Write("\n\t Write index of first array " +
                "\n\t from which numbers will be copied to second massive: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\t Write size of second array: ");
            int count = Convert.ToInt32(Console.ReadLine());

            SubArray(array, index, count);

            Console.ReadKey();
        }
    }
}