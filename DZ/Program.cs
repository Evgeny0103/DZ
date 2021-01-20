using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        enum Month 
        {
            Январь =1,
            Февраль, 
            Март, 
            Апрель, 
            Май, 
            Июнь,
            Июль, 
            Август, 
            Сентябрь, 
            Октябрь, 
            Ноябрь, 
            Декабрь
        }
    
        static void Main(string[] args)
        {
            #region Пример №1
            /*
             * Запросить у пользователя минимальную и максимальную температуру за сутки и 
             * вывести среднесуточную температуру.
             */
            /* Console.WriteLine("Здравствуйте введите пожалуйста минимальную температу");
              string mintemper = Console.ReadLine();
              int minvalue = Convert.ToInt32(mintemper);
              Console.WriteLine("Введите пожалуйста максимальную температуру");
              string maxtemper = Console.ReadLine();
              int maxvalue = Convert.ToInt32(maxtemper);
              int result = (minvalue + maxvalue) / 2;
              Console.WriteLine($"Среднесуточная температура {result}");
              Console.ReadLine();
              */
            #endregion

            #region Пример № 2
            /*
             * Запросить у пользователя порядковый номер текущего месяца и вывести его название. 
             */
           

          /*  Console.WriteLine("Введите пожалуйста любое число от 1 до 12");
            string number = Console.ReadLine();
            int ValueMonth = Convert.ToInt32(number);
            

            switch (ValueMonth) 
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
            }

         
       
            */
            #endregion




        }


    }
}
