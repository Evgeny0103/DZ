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
            #region Пример № 1
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


            /* Console.WriteLine("Введите пожалуйста любое число от 1 до 12");
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
             Console.Read();
            */
            #endregion

            #region Пример № 3
            /* Определить, является ли введённое 
             * пользователем число чётным.*/
            /* Console.WriteLine("Введите пожалуйста число");
             string value = Console.ReadLine();
             int number = Convert.ToInt32(value);
             if (number % 2 == 0)
             {
                 Console.WriteLine("Вы ввели четное число");

             }
             else 
             {
                 Console.WriteLine("Вы ввели нечетное число");
             }
            */
            #endregion

            #region Пример № 4
            /*
             * Для полного закрепления понимания простых типов найдите любой чек, 
             * либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
             * только за место динамических, по вашему мнению, данных 
             * (это может быть дата, название магазина, сумма покупок) 
             * подставляйте переменные, которые были заранее заготовлены 
             * до вывода на консоль.

             */
            /* string nameIE = "ИП Бакуменко К.В. "; // Индивидуальный предприниматель
             string nameShop = "Салон Сфинкс"; // Название магазина 
             string kassa = "Касса";
             string nomerkassy = "Штрих-21";
             string prodazha = "Продажа";
             string nameGames = "Grand Theft Auto IV DVD"; // Название игры
             string price = "435.00"; // Цена
             string totalPrice = "435.00";
             string idKassir = "Д/К 000021408076"; // Идентификатор кассира
             string discountoncard = "Скидка на карту 5 %";// Скидка
             string discount = "21.75";
             string outcome = "413.25"; // Итог
             string cash = "450.00";
             string surrender = "36.75"; // Сдача
             string nameKassy = "КАССИР 1";
             DateTime date = new DateTime(2008, 12, 08, 16, 12, 00);

             Console.WriteLine($" \t \t \t {nameIE}\n******************************************************" +
                 $"\n\t \t \t {nameShop} \n******************************************************" +
                 $"\n {kassa} \t \t \t \t \t   {nomerkassy} \n-------------------------{prodazha}-----------------------" +
                 $"\n1) {nameGames} \n2 \t \t \t \t\t \t ={price} \n======================================================= " +
                 $"\nВСЕГО \t \t \t \t\t \t ={totalPrice}\n{idKassir} \n{discountoncard} \nСкидка  \t \t \t\t \t ={discount}" +
                 $"\n=======================================================\nИТОГ \t \t \t \t\t \t ={outcome}" +
                 $"\nналичными \t \t \t \t\t ={cash}\nСДАЧА\t \t  \t \t  \t \t  ={surrender}\n" +
                 $"{date.ToString("dd.MM.yy")} {date.ToString("HH.mm.ss")}\t \t\t \t {nameKassy}");
             Console.Read();
            */
            #endregion

            #region Пример № 5
            /*
             * (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
             */

            /*  Console.WriteLine("Введите пожалуйста любой месяц года");
              string month = Console.ReadLine();
              Console.WriteLine("Введите пожалуйста температуру");
              string temper = Console.ReadLine();
              int tempValue = Convert.ToInt32(temper);
              if ((month == "Декабрь" || month == "Январь" || month == "Февраль") && (tempValue > 0))
              {
                  Console.WriteLine("Дождливая зима");
              }
              else 
              {
                  Console.WriteLine($"{month} {tempValue}");
              }
              Console.Read();
            */
            #endregion

            #region Привер № 6
            /*
             * Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, 
             * к примеру, чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, 
             * офис номер 2 работает с понедельника до воскресенья.
             */
           /* int workdayoffice1 = 0b_0111100; // переменная для проверки режима работы офиса №1 
            int workdayoffice2 = 0b_1111110; // переменная для проверки режима работы офиса №2

            int office1 = 0b_0000000; // Берем пустой шаблон для того чтобы добавить дни работы для офиса
            int office2 = 0b_0000000;


            // Маски дней недели:
            int Monday = 0b_1000000; // Понедельник
            int TuesDay = 0b_0100000;  // Вторник
            int Wednesday = 0b_0010000; // Среда
            int Thursday = 0b_0001000; // Четверг
            int Friday = 0b_0000100; // Пятница
            int Saturday = 0b_0000010; // Суббота
            int Sunday = 0b_0000001; // Воскресенье


            // Для каждого офиса задаем режим работы
            int DayWorkOffice1 = office1 | TuesDay | Wednesday | Thursday | Friday;
            int DayWorkOffice2 = office2 | Monday | TuesDay | Wednesday | Thursday | Friday | Saturday;


            // Если режим работы совпадает с нужным нам шаблонам получим true  
            Console.WriteLine(workdayoffice1 == DayWorkOffice1);
            Console.WriteLine(workdayoffice2 == DayWorkOffice2);
            Console.Read();
           */

            #endregion




        }


    }
}
