using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {

        static void Main(string[] args)

        {
            #region Пример №1
            /*
             
            Написать программу, выводящую элементы двумерного массива по диагонали.

             */


            /*   int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
               int hight = matrix.GetLength(0);
               int width = matrix.GetLength(1);
               for (int i = 0; i < hight; i++)
               {
                   for (int j = 0; j < width; j++)
                   {
                      if (i == j) 
                      {
                          Console.Write($"{matrix[i, j]}");
                      }
                   }
                   Console.WriteLine();

               }
            */



            #endregion

            #region Пример №2

            /*
             * Написать программу «Телефонный справочник»: 
             * создать двумерный массив 5х2, 
             * хранящий список телефонных контактов: 
             * первый элемент хранит имя контакта, 
             * второй — номер телефона/email. 
             * 
             */



            /*string[,] phoneNumber = new string[5, 2];
            for (int i = 0; i < phoneNumber.GetLongLength(0); i++)
            {
                for (int j = 0; j < phoneNumber.GetLongLength(1); j++)
                {   // Сначала вводим имя потом Enter потом номер
                    Console.WriteLine($"name + {i} phone {j}");
                    phoneNumber[i, j] = Console.ReadLine();
                }
              
            }

            Console.WriteLine();


            for (int i = 0; i < phoneNumber.GetLongLength(0); i++)
            {
                for (int j = 0; j < phoneNumber.GetLongLength(1); j++)
                {
                    Console.Write($"{phoneNumber[i, j]}\t");
                }
                Console.WriteLine();

            }

            */
            #endregion

            #region Пример №3
            /* 
             * Написать программу, выводящую введённую пользователем строку
             * в обратном порядке(olleH вместо Hello).
            */

            // Вариант 1
            /* char[] a = "Hello".ToCharArray();
             Array.Reverse(a);
             string s = new string(a);
             Console.WriteLine(s);

             // Вариант 2
             string slovo = Console.ReadLine();
             string reverse = string.Empty;
             for (int i = slovo.Length - 1; i > -1; i--)
                 reverse += slovo[i];
             Console.WriteLine(reverse);
            */


            #endregion

            #region Пример № 4
            /*
             * *«Морской бой»: вывести на экран массив 10х10, 
             * состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
             */

           /* char[][] array = new char[10][];
            array[0] = new char[10];
            array[1] = new char[10];
            array[2] = new char[10];
            array[3] = new char[10];
            array[4] = new char[10];
            array[5] = new char[10];
            array[6] = new char[10];
            array[7] = new char[10];
            array[8] = new char[10];
            array[9] = new char[10];

            char sheep = 'X';
            char fc = 'O';

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = (char)random.Next(88, 90);
                    if (array[i][j] == 88)
                    {
                        array[i][j] = sheep;
                    }
                    else
                    {
                        array[i][j] = fc;
                    }
                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}");
                }
                Console.WriteLine();
           */
                #endregion

            

            }
        }
    }
}

