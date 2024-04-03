using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обозначение переменных, математические операции
            //int x, y, z;
            //x = 10;
            //y = 25;
            //z = x * y;

            //Console.WriteLine(z);
            //Console.ReadLine();

            //булевые логические переменные
            //bool accesIsAllowed;
            //accesIsAllowed = 5 != 4;
            //Console.WriteLine(accesIsAllowed);

            //конкатенция (сложение строк)
            //string greeting = 'Даров'
            //string name = 'бро'
            //string message = greeting + " " + name;
            //Console.Writeline(message + ", опять ты");

            //Складываем числа и строки
            //int time = 5;
            //Console.Writeline(5 + 5 + " завтра встречаемся в " + (time+1));
            //получим сообщение 10 завтра встречаемся в 6

            //cw tab tab = напишется console.Writeline()

            //интерполяция
            //int age = 27;
            //string name = "Vasya"
            //Console.Writeline("Ваше имя: " + name + " Вам " + age + "лет!");
            //Выведет: Ваше имя Vasya Вам 27 лет!
            //Методом интерполяции это записывается так:
            //Console.Writeline($"Ваше имя: {name} Вам {age} лет!");

            //конвертация (смена, изменение, приведение) типов данных:
            //int age = 22;
            //string input = "15";
            //age = Convert.ToInt32(input); - конвертирует в int
            //Console.WriteLine(); - выводит значение

            //конвертация float на примере:
            //float result
            //int x = 5, y = 2;
            //result = Convert.ToSingle(x) / y; - приводим к float (дробному числу)
            //Console.WriteLine(result);

            //конвертация bool переменных ( булевых значений )
            //int trigger = 1;
            //bool triggerInBool = ConvertToBoolean(trigger);
            //Console.WriteLine(triggerInBool); - получим true (т.к. 1 = true, 2 = false);
            //int reconvert = Convert.ToInt32(triggerInBool);
        }

    }
}
