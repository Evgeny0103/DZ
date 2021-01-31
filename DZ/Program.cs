using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{

    class Program
    {
        #region Пример №1

        /*
         * Написать метод GetFullName(string firstName, string lastName, string patronymic), 
         * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
         * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
         */

        /* static void Main(string[] args)

         {

             Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
             Console.WriteLine(GetFullName("Петров", "Петр", "Петрович"));
             Console.WriteLine(GetFullName("Панов", "Иван", "Алексеевич"));

         }

         static string GetFullName(string firstname, string lastname, string patronymic) 
         {

             return $"Ваше полное имя {firstname} {lastname} {patronymic}"; 
         }

         */
        #endregion

        #region Пример №2
        /* static void Main(string[] args) 
         {
             /*
              Написать программу, принимающую на вход строку — набор чисел, 
             разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
             Ввести данные с клавиатуры и вывести результат на экран.
             */
        /*  Console.WriteLine("Введите пожалуйста любые цифры, через пробел");
           string stroka = Console.ReadLine();
           var ints = stroka.Split(' ').Select(Int32.Parse).ToArray();
           int count = 0;
           for (var i = 0; i < ints.Length; i++)
           {
               count = ints[i] + count;
           }
           Console.WriteLine($"Суммма введеных вами чисел равна : {count}");
        }
        */

        #endregion

        #region Пример №3
        /*    public enum Season 
             {
               Wintrer = 1,
               Spring,
               Summer,
               Autumn
            }





            static void Main(string[] args) 
            {
                /*
                 * 
                 *Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
                 *На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
                 *Написать метод, принимающий на вход значение из этого перечисления и возвращающий 
                 *название времени года (зима, весна, лето, осень). 
                 *Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
                 *Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
                 */

        /* Console.WriteLine("Здравствуйте введите пожалуйста число от 1 до 12");
         int number = int.Parse(Console.ReadLine());
         GetMonth(number);




     }

     static  void  GetMonth(int number) 
     {  
         switch (number) 
         {
             case 12:
             case 1:
             case 2:
                 Console.WriteLine(Season.Wintrer);
                 break;
             case 3:
             case 4:
             case 5:
                 Console.WriteLine(Season.Spring);
                 break;
             case 6:
             case 7:
             case 8:
                 Console.WriteLine(Season.Summer);
                 break;
             case 9:
             case 10:
             case 11:
                 Console.WriteLine(Season.Autumn);
                 break;
             default:
                 Console.WriteLine("Ошибка : введите пожалуйста число от 1 до 12 ");
                 break;
         }


     }






   }
        */

        #endregion

        #region Пример №4

        /*
         * (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 

         */

        /* static void Main(string[] args)
         {
             Console.WriteLine(Fibonachi(12));
             Console.WriteLine(Fibonachi2(12));
         }

         static int Fibonachi(int n)
         {
             int a = 0;
             int b = 1;
             int tmp;

             for (int i = 0; i < n; i++)
             {
                 tmp = a;
                 a = b;
                 b += tmp;
             }

             return a;
         }

         static int Fibonachi2(int n)
         {
             if (n == 0 || n == 1)
             {
                 return n;
             }
             else
             {
                 return Fibonachi(n - 1) + Fibonachi(n - 2);
             }
         }
         */
        #endregion

    }
}