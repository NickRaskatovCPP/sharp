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
            //Console.WriteLine(triggerInBool); - получим true (т.к. 1 = true, 0 = false);
            //int reconvert = Convert.ToInt32(triggerInBool);
            //Console.writeline(reconvert);

            //Вывод в консоль: 
            //Console.WriteLine();

            //Считывание данных, которые ввел пользователь
            //string name;
            //name = console.ReadLine();
            //Consoole.WriteLine($"Ваше имя: {name}");

            //Для ввода и вывода русских символов
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //string name;
            //Console.Writeline("Введите ваше имя: "); - если требуется вывод в одну строку - пишем write вместо writeline
            //name = console.ReadLine();
            //Consoole.WriteLine($"Ваше имя: {name}");

            //При считывании данных из консоли - консоль возвращает строку, если нам надо вывести число:
            //int age;
            //Console.Writeline("Введите ваш возраст: ");
            //age = Convert.ToInt32(console.ReadLine()); - приводим тип данных
            //Consoole.WriteLine($"Ваш возраст: {name}");

            //инкремент и декремент
            //int i = 0;
            //i++ - инкремент в постфиксной форме (увеличение на 1 после возврата переменной)
            //--i - декремент в префиксной записи (уменьшение на 1 перед возвратом переменной)
            //Console.Writeline(i)

            //Пишем программу-калькулятор высчитывающую урон наносимый персонажу:
            //int health;
            //int armor;
            //int damage;
            //int precentConverter = 100; - переводит переменную армор в %

            //Console.Writeline("Введите кол-во здоровья: ");
            //healt = Convert.ToInt32(console.ReadLine());
            //Console.Writeline("Введите кол-во брони: ");
            //armor = Convert.ToInt32(console.ReadLine());
            //Console.Writeline("Введите кол-во урона: ");
            //damage = Convert.ToInt32(console.ReadLine());

            //health -= damage * armor / precentConverter
            //Consoole.WriteLine($"Вам нанесли {damage} урона, у вас осталось {helth} здоровья");

            //Пример калькулятора цены для магазина
            //int money;
            //int food;
            //int foodUnitPrice = 10; 

            //Console.writeline("Добро пожаловать в пекарню! Сегодня вся еда по Э + foodUnitPrice + " монет.");
            //Console.write("Сколько у вас монет ?");
            //money = Convert.ToInt32(Console.ReadLine());
            //Console.write("Сколько еды вам требуется?");
            //food = convertToInt32(Console.ReadLine());

            //money -= food * foodUnitPrice;
            //Console.WriteLine($"У вас в сумке {food} едениц еды, и {money} монет");
        
        }

    }
}
