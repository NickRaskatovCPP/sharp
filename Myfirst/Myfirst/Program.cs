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
int x, y, z;
x = 10;
y = 25;
z = x * y;

Console.WriteLine(z);
Console.ReadLine();

//булевые логические переменные
bool accesIsAllowed;
accesIsAllowed = 5 != 4;
Console.WriteLine(accesIsAllowed);

//конкатенция (сложение строк)
string greeting = 'Даров'
string name = 'бро'
string message = greeting + " " + name;
Console.Writeline(message + ", опять ты");

//Складываем числа и строки
int time = 5;
Console.Writeline(5 + 5 + " завтра встречаемся в " + (time+1));
//получим сообщение 10 завтра встречаемся в 6
//cw tab tab = напишется console.Writeline()

//интерполяция
int age = 27;
string name = "Vasya"
Console.Writeline("Ваше имя: " + name + " Вам " + age + "лет!");
//Выведет: Ваше имя Vasya Вам 27 лет!
//Методом интерполяции это записывается так:
Console.Writeline($"Ваше имя: {name} Вам {age} лет!");

//конвертация (смена, изменение, приведение) типов данных:
int age = 22;
string input = "15";
age = Convert.ToInt32(input); //конвертирует в int
Console.WriteLine(); //выводит значение

//конвертация float на примере:
float result
int x = 5, y = 2;
result = Convert.ToSingle(x) / y; //приводим к float (дробному числу)
Console.WriteLine(result);

//конвертация bool переменных ( булевых значений )
int trigger = 1;
bool triggerInBool = ConvertToBoolean(trigger);
Console.WriteLine(triggerInBool); //получим true (т.к. 1 = true, 0 = false);
int reconvert = Convert.ToInt32(triggerInBool);
Console.writeline(reconvert);

//Вывод в консоль: 
Console.WriteLine();

//Считывание данных, которые ввел пользователь
string name;
name = console.ReadLine();
Consoole.WriteLine($"Ваше имя: {name}");

//Для ввода и вывода русских символов
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string name;
Console.Writeline("Введите ваше имя: "); //если требуется вывод в одну строку - пишем write вместо writeline
name = console.ReadLine();
Consoole.WriteLine($"Ваше имя: {name}");

//При считывании данных из консоли - консоль возвращает строку, если нам надо вывести число:

using System;
class HelloWorld
        {
            static void Main()
            {
                int age;
                Console.WriteLine("enter your age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вам {age} лет");
            }
        }

//инкремент и декремент
int i = 0;
i++ //инкремент в постфиксной форме (увеличение на 1 после возврата переменной)
--i //декремент в префиксной записи (уменьшение на 1 перед возвратом переменной)
Console.Writeline(i)

//Пишем программу-калькулятор высчитывающую урон наносимый персонажу:
using System;
class HelloWorld
    {
        static void Main()
        {
            int health;
            int armor;
            int damage;
            int precentConverter = 100; //переводит переменную армор в %

            Console.WriteLine("Введите кол-во здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * armor / precentConverter;
            Console.WriteLine($"Вам нанесли {damage} урона, у вас осталось {health} здоровья");
        }
    }

//Пример калькулятора цены для магазина
using System;
class HelloWorld
    {
        static void Main()
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine("Добро пожаловать в пекарню! Сегодня вся еда по" + foodUnitPrice + "монет");
            Console.Write("Сколько у вас монет ? ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам требуется? ");
            food = Convert.ToInt32(Console.ReadLine());
            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} едениц еды, и {money} монет");
        }
    }

 //Условные конструкции If и прочие: 
using System;
class HelloWorld
    {
        static void Main()
        {
            int age;
            Console.Write("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18) //-в круглых скобках пишем условия
            { //внутри этих скобок выполняется код, если условие оказалось истинным(в данном случае age >= 18)
                Console.WriteLine("Велком!");
                Console.WriteLine("Чего вам плеснуть?");
            }
            else //-выполняется это условие, если значение булевой переменной False
            {
                Console.WriteLine("Приходите когда вам исполнится " + (18 - age) + " лет");
                Console.WriteLine("ПНХ");
            }
            Console.WriteLine("сведение разветвления в 1 путь из IF и Else");
        }
    }


//Еще 1 пример: тренировки по дням недели
using System;
    class HelloWorld
    {
        static void Main()
        {
            string day;
            Console.Write("Введите день недели: ПН,ВТ,СР,ЧТ,ПТ и т.д.");
            day = Console.ReadLine(); //-приводить не надо, т.к.стринг
            if (day == "ПН")
            {
                Console.WriteLine("Плечи");
            }
            else if (day == "СР")
            {
                Console.WriteLine("Спина");
            }
            else if (day == "ПТ")
            {
                Console.WriteLine("Бицепс");
            }
            else
            {
                Console.WriteLine("Отдых");
            }
        }
    }

    //Операторы логического и/ или
    //Логическое И && (аналог умножения, если одна из переменных false (0) то результат false (0)
    //Логическое ИЛИ || (аналог сложения, если одна из переменных true (0) то результат true (0)
    //Пример применения:
using System;
class HelloWorld
    {
        static void Main()
        {
            int money = 500;
            int level = 9;
            if (money >= 500 || level > 9)
            {
                Console.WriteLine("Добро пожаловать");
            }
            else
            {
                Console.WriteLine("ПНХ");
            }
        }
    }

//Условный оператор switch - при нем все варианты взаимоисключающие.
//Его полезно применять при большом кол-ве вариантов сравнения.
using System;
class HelloWorld
    {
        static void Main()
        {
            string day;
            day = Console.ReadLine();
            switch (day)
            {
                case "ПН":
                case "ЧТ":
                case "ПТ":
                    Console.WriteLine("идем в кино");
                    Console.WriteLine("идем в галлерею");
                    Console.WriteLine("идем к памятникам");
                    break;
                case "ВТ":
                case "СБ":
                    Console.WriteLine("едем в кино");
                    Console.WriteLine("летим в кино");
                    Console.WriteLine("мчимся в кино");
                    break;
                case "СР":
                    Console.WriteLine("идем в кино");
                    Console.WriteLine("идем в кино");
                    break;
                default:
                    Console.WriteLine("Не верно указан день");
                    break;
            }
        }
    }


//Проверка пароля через if
using System;
class HelloWorld
    {
        static void Main()
        {
            string pass = "1234";
            string uInput;

            Console.WriteLine("Введите ваш пароль: ");
            uInput = Console.ReadLine();
            if (uInput == pass)
            {
                Console.WriteLine("Пароль верен");
            }
            else
            {
                Console.WriteLine("Пароль не верен, осталась 1 попытка");
            }

        }
    }

//Конвертер валют (создали валюту задлали курсы валют)
using System;
class HelloWorld
    {
        static void Main()
        {
            float rub;
            float usdt;
            int rubusdt = 94, usdtrub = 96;
            float howmutch;
            string operation;
            Console.WriteLine("Добро пожаловать в обменник!");
            Console.Write("Введите баланс в рублях ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс в usdt ");
            usdt = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("1. Обмен рублей на usdt ");
            Console.WriteLine("2. Обмен usdt на рубли ");
            Console.Write("Ваш выбор: ");
            operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на usdt ");
                    Console.Write("Сколько вы хотите обменять? ");
                    howmutch = Convert.ToSingle(Console.ReadLine());
                    if (rub >= howmutch)
                    {
                        rub -= howmutch;
                        usdt += howmutch / rubusdt;

                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");

                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен usdt на рубли ");
                    Console.Write("Сколько вы хотите обменять? ");
                    howmutch = Convert.ToSingle(Console.ReadLine());
                    if (usdt >= howmutch)
                    {
                        usdt -= howmutch;
                        rub += howmutch * usdtrub;

                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");

                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция");
                    break;
            }
            Console.WriteLine($"Ваш баланс: {rub} рублей " + $" {usdt} usdT");
        }
    }

//Циклы
//while - выполняется до тех пор, пока условие верно
//while  - цикл с условием
//Пример

using System;
class HelloWorld
    {
        static void Main()
        {
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (age++ > 0 && age < 20)
            {
                Console.WriteLine("C др крч! Тебе исполнилось " + age);
                if (age == 18) //условие остановки выполнения программы
                {
                    break; //точка остановки выполнения программы
                }
            }
        }
    }

//Можно сделать, что бы цикл пропустил одну итерацию
//пропустим поздравление с 16 летием:
using System;
class HelloWorld
    {
        static void Main()
        {
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            while (age-- > 0)
            {

                if (age == 16) //при каких условиях пропустить 1 итерацию скрипта
                {
                    continue; //точка пропуска итеррации скрипта
                }
                Console.WriteLine("C др крч! Тебе исполнилось " + age);
            }

        }
    }
//Цикл For
//цикл с параметром. Обычно задается начальное и конечное значение переменной

using System;
class HelloWorld
    {
        static void Main() {
            for (int i = 0; i < 10; i++) { //i начинается с нуля, до тех пор пока i < 10 условие будет 
                Console.WriteLine(i);      //выполняться, каждую итерацию увеличиваем i на единицу
            }                              //Если не хотим выводить 0 - используем проверку и пропуск 0
        }
    }

//цикл for  на примере проверки пароля
using System;
class HelloWorld
    {
        static void Main()
        {
            int popitki = 5; //так как циклов 5 с уменьшением кол-ва попыток на 1 подойдет цикл for
            string pass = "1234";
            string user;

            for (int i = 0; i < popitki; i++)
            {
                Console.Write("Введите пароль: ");
                user = Console.ReadLine();
                if (user == pass)
                {
                    Console.Write("Доступ разрешен");
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неправильный пароль, осталось " + (popitki - (i + 1)) + " попыток ");
                }
            }
        }
    }


//калькулятор банковского вклада без пополнения
using System;
class HelloWorld
    {
        static void Main()
        {
            int year;
            double money; //сколько денег
            int years; //сколько лет
            int percent; //процент годовых
                         //просим пользователя ввести эти данные
            Console.Write("Введите текущий год ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сумму вклада: ");
            money = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите срок вклада: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите процент по вкладу: ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.Write((i + 1) + ". В " + ++year + " году у вас " + money);
                Console.ReadLine(); //что бы повторять итерацию по нажатию кнопки пишем это
            }
        }
    }