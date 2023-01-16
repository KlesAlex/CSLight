using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // перебор массива
            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (int item in numbers)
            //{ Console.Write(item + " "); }
        
            /* игра бродилка
            char[,] map =
            {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', 'X', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', '#', '#', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', 'X', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', 'X', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
            };

            bool isWork = true;
            char[] bag = new char[1];

            // координаты юзера
            int userX = 6, userY = 6;

            // чтобы не мигал курсор
            Console.CursorVisible = false;

            while (isWork)
            {
                // отображение содержимого сумки
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                { Console.Write(bag[i] + " "); }

                // установка курсора на первой позиции
                Console.SetCursorPosition(0, 0);
                // прорисовка карты
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY-1, userX-1);
                Console.Write('@');

                // обработка управления
                ConsoleKeyInfo charKey = Console.ReadKey(); // обработка ввода с клавиатуры в переменную
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 2, userY - 1] != '#')
                        { userX--; }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX-1,userY-2]!='#')
                        { userY--; }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX - 1, userY] != '#')
                        { userY++; }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX, userY - 1] != '#')
                        { userX++; }
                        break;
                    //case ConsoleKey.E:
                    //    isWork = false;
                }

                if (map[userX - 1, userY - 1] == 'X')
                {
                    map[userX - 1, userY - 1] = 'O';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    { tempBag[i] = bag[i]; }
                    tempBag[bag.Length] = 'X';
                    bag = tempBag;
                }

                Console.Clear();
            }

            игра бродилка */

            // расширение массива через создание и заполнение допмассива
            //int[] bag = new int[1];
            //int[] tempBag = new int[bag.Length + 1];
            //for (int i = 0; i < bag.length; i++)
            //{
            //    tempBag[i] = bag[i];
            //}
            //bag = tempBag;

            // Ссылки на массив
            //int[] array = new int[3];
            //int[] tempArray = new int[5];
            //array = tempArray; // теперь первый объявленный массив ссылается на область памяти второго массива
            //array[0] = 5;
            //Console.WriteLine(tempArray[0]);

            /* Управление библиотекой
            bool isOpen = true;
            string[,] books =
            {
                { "Евгений Онегин",   "Александр Пушкин", "Михаил Лермонтов" },
                { "Роберт Мартин",    "Джесси Шелл",      "Марк Торк"        },
                { "Говард Лавкрафт",  "Стивен Кинг",      "Брем Стокер"      }
            };

            while (isOpen) {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов:\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i,j] + " | ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1 - узнать имя автора по индексу книги\n\n2 - найти книгу по автору.\n\n3 - выход.");
                Console.Write("Выберите пункт меню.");

                switch ( Convert.ToInt32(Console.ReadLine()) )
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine());
                        if (line >= books.GetLength(0)) {
                            Console.WriteLine("Такой полки не существует.");
                            break;
                        }
                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        if (column >= books.GetLength(1)) {
                            Console.WriteLine("Такого столбца не сущесвтует.");
                            break;
                        }

                        Console.WriteLine($"На полке {line} в столбце {column} находится {books[line-1,column-1]}");

                        break;
                    case 2:
                        string author;
                        bool isFind = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine($"Автор {author} находится на {i+1} полке в {j+1} столбце");
                                    isFind = true;
                                    break;
                                }
                            }
                        }
                        if (isFind == false) {
                            Console.WriteLine("Такого автора нет в нашей библиотеке.");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Указан неверный пункт меню");
                        break;
                }

                if (isOpen) {
                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                }

                Console.ReadKey();
                Console.Clear();

            }
            Управление библиотекой*/

            /* двумерные массивы
            //int[,] array;                     объявление
            //int[,] array = new int[5, 6];     объявление с ограничением размера
            //int[,] array = {                  //объявление и инициализация
            //    { 2, 3, 4 },
            //    { 4, 5, 1 }, 
            //    { 7, 8, 9 } 
            //};
            //int[,] array = new int[2, 3]      объявление и инициализация с ограничением размера
            //{
            //    { 5, 6, 7 },
            //    { 2, 7, 0 }
            //};
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            двумерные массивы*/

            /* регистрация пассажиров
            int[] sectors = { 6, 28, 15, 15, 10 };
            bool isOpen = true;

            while (isOpen)
            {

                Console.SetCursorPosition(0, 18);

                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n \n1 - забронировать места\n \n2 - выход из программы.\n \n");
                Console.Write("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine());
                        if (sectors.Length <= userSector || userSector <= 0)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.Write("Сколько мест нужно забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (sectors[userSector] < userPlaceAmount || userPlaceAmount <= 0)
                        {
                            Console.WriteLine("Некорректное кол-во мест");
                            break;
                        }
                        sectors[userSector-1] -= userPlaceAmount;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введенная команда не корректная");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
            регистрация пассажиров*/

            /*
            int[] array = { 2, 3, 4, 7, 8 };
            int sum = 0;
            int[] array = { 1, 3, 5, 8, 12, 2, -2 };
            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                //Console.WriteLine(array[i]);
                //sum += array[i];
                if (maxElement < array[i])
                { 
                    maxElement = array[i]; 
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(maxElement);
            */

            /* одномерный массив. Обозначается через []
            int[] cucumber = new int[10];
            Random rand = new Random();
            for (int i = 0; i < cucumber.Length; i++)
            {
                cucumber[i] = rand.Next(1, 101);
                Console.Write(cucumber[i] + ", ");
            }
            int[] cucumbers = { 24, 25, 17, 12, 28, int.MaxValue, int.MinValue };
            for (int i = 0; i < cucumbers.Length; i++)
            {
                Console.Write(cucumbers[i] + ", ");
            }
            одномерный массив.*/

            // высота и ширина консоли
            // Console.WindowHeight = 50;
            // Console.WindowWidth = 150;

            // покраска текста
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine("Покрашеный текст");

            // покраска фона
            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.WriteLine("Для просмотра фона");

            // установка позиции курсора
            // Console.SetCursorPosition(5, 15); на 5 вправо и на 15 вниз

            // очистка консоли
            // Console.Clear();

            // перенос строки при выводе сообщения через \n
            //Console.WriteLine("Я первая строка\nА я вторая строка\nНу а я третья строка");

            /* игра гладиаторы
            Random rand = new Random();
            
            float health1 = rand.Next(50, 200);
            int damage1   = rand.Next(10, 50);
            int armor1    = rand.Next(50, 100);

            float health2 = rand.Next(50, 200);
            int damage2   = rand.Next(10, 50); 
            int armor2    = rand.Next(50, 100);

            int round     = 0;
            float DamageRound;

            Console.WriteLine($"Гладиатор 1 - {health1} здоровье, {damage1} урон, {armor1} броня");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровье, {damage2} урон, {armor2} броня");

            while (health1 > 0 && health2 > 0)
            {
                round++;
                Console.WriteLine($"Раунд: {round}");

                // первый бьет второго
                DamageRound = Convert.ToSingle((rand.Next(0, damage1 + 1))) / 100 * armor2;
                Console.WriteLine($"Первый гладиатор наносит второму урон {DamageRound}.");
                if (health2 > DamageRound)
                {
                    health2 -= DamageRound;
                    Console.WriteLine($"У второго гладиатора осталось {health2} здоровья.");
                }
                else
                {
                    Console.WriteLine("Второй гладиатор погиб. Бой окончаен. Победил первый гладиатор");
                    break;
                }

                // второй бьет первого
                DamageRound = Convert.ToSingle((rand.Next(0, damage2 + 1))) / 100 * armor1;
                Console.WriteLine($"Второй гладиатор наносит ответный удар на {DamageRound} урона.");
                if (health1 > DamageRound)
                {
                    health1 -= DamageRound;
                    Console.WriteLine($"У первого гладиатора осталось {health1} здоровья.");
                }
                else
                {
                    Console.WriteLine("Первый гладиатор погиб. Бой окончаен. Победил второй гладиатор");
                    break;
                }
            }
            игра гладиаторы*/

            /* игра угадай число+
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100. Оно больше чем {lower} но меньше чем {higher}");
            Console.WriteLine($"Что это за число? У вас {triesCount} пыток, чтобы отгадать.");

            while (triesCount-- > 0)
            {
                Console.Write("Введите число: ");
                userInput = Convert.ToInt32( Console.ReadLine() );

                if (userInput == number)
                {
                    Console.WriteLine("Поздравляем. Вы угадали!");
                    triesCount = 5;
                    break;
                }
                else
                {
                    Console.WriteLine("К сожалению вы не угадали.");
                }
            }

            if (triesCount == -1)
            {
                Console.WriteLine($"К сожалению все попытки отгадать закончились. Вы проиграли. Было загадано число {number}");
            }
            *игра угадай число-/ 

            // работа с рандомными числами
            /*Random rand = new Random();
            int value = rand.Next(0, 10);

            while (true)
            {
                value = rand.Next(0, 10);
                Console.WriteLine(value);
                Console.ReadKey();
            }*/

            // Основные типы int | float |
            // Целочисленные типы
            //byte b;         // от 0 до 255.
            //sbyte sb;       // от -128 до 127
            //short s;        // от -32768 до 32767
            //ushort us;      // от 0 до 65535
            //int i;          // от -2147483648 до 2147483647
            //uint ui;        // от 0 до 4294672295
            //long l;         // определеяем по MaxValue и MinValue см. подсказку
            //ulong ul;       // аналогично лонгу но не отрицательно
            // Числа с плавающей точкой
            //float f = 5.7f; // точность до 7 знаков. При инициализации необходимо указывать f иначе будет пытаться преобразовать к типу double
            //double d = 5.7; // точность до 15 знаков
            // Символьный тип
            //char c = 'Й';   // нужен один символ или пробел. Определяется одинарными кавычками
            // Строковый тип
            //string str = "Юг";// Оформляется двойными кавычками. Содержит множество char
            // Булево. Логический тип.
            //bool bl;

            // инициализация при объявлении
            //int age1 = 15;
            // инициализация после объявления
            //int age2;
            //age2 = 27;

            // При объявлении переменных из нескольких слов лучше не использовать нижнее подчеркивание
            // а как в 1с каждое следующее слово с заглавной буквы. Но первое с маленькой

            // Арифметические операторы:
            // + - * / % (сложение, вычитание, умножение, деление, деление по модулю

            // Работа с c# interactive
            // Открыть вид->другие окна->c# interactive
            // 1 особенность при делении целочисленных чисел результат будет как целое число. Дробная часть будет отброшена.
            // Чтобы поделить с дробной частью, для одного из чисел нужно явно указать дробную часть. Например 5 / 2.0
            // Без дробной части это деление нацело.

            // Как избежать целочисленное деление в коде
            // Используем конструкцию конвертации одной из переменных
            // Convert.ToSingle
            //float result;
            //int x, y;
            //x = 5;
            //y = 2;
            //result = Convert.ToSingle(x) / y;

            // Пример деления по модулю
            //int timeInMinets = 130;
            //int hour;
            //int minute;
            //hour = timeInMinets / 60; // целочисленное кол-во часов
            //minute = timeInMinets % 60; // остаток от деления те самые минуты

            // Сокращение математических операций
            //int age = 18;
            //age++;    // Добавить единицу
            //age += 2; // Добавить два
            //age -= 3; // Вычесть три
            //age *= 2; // Умножить на два
            //age /= 3; // Разделить на три

            // Математические операции производятся в том же порядке как и в математике
            // Сначала умножение,деление,деление по модулю, затем сложение и вычитание.
            // Приоритет выделяем скобками

            // Логические операторы (можно выполнять в c# interactive)
            // Равенство: ==
            // Не равно: !=
            // Сравнения >, >=, <, <=
            // Логическое И &&
            // Логическое ИЛИ ||

            // Конкатенация
            //string greeting = "Hello";
            //string name = "Aleksandr";
            //string message = greeting + ", " + name;
            // Console.WriteLine(message); // можно при выводе добавить в сообщение строку (message+" еще текст").
            //int age = 23;
            // можно дополнить строку числом. Например "завтра тебе исполнится " + age
            // Порядок присоединения слева направо. Если прибавляем 2 числа по очереди - строки станут числом.
            // То есть +5 +1 - получим 51. Чтобы было сложения чисел - приоритет выделим скобками
            // "Привет, завтра тебе исполнится: " + (5+1)

            // Console.WriteLine(); - иактивируется комбинацией cw + tab + tab

            // интерполяция
            //string name = "Aleksandr";
            //int age = 37;
            //Console.WriteLine($"Ваше имя: {name}, вам {age} лет!");

            // Конвертация данных в сишарп
            //int age;
            //string input = "15";
            //age = Convert.ToInt32(input);

            //Console.ReadKey(); - ожидание нажатия любой клавиши

            // Ввод значения переменной пользователем
            //string name;
            //Console.Write("Введите ваше имя: ");
            //name = Console.ReadLine();
            //Console.WriteLine($"Ваше имя: {name}");

            // Вариант решения проблемы с русским языком
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            // Ввод целочисленного значения
            //int age;
            //Console.Write("Введите возраст: ");
            //age = Convert.ToInt32(Console.ReadLine()); // добавляем конвертацию из строки в число
            //Console.WriteLine($"Вам {age} лет");

            // Прибавление и уменьшение значения на 1 называется инкримент и декремент
            // int i=0;
            // Постфиксная форма
            // i++;
            // i--;
            // Префиксная форма
            // ++i;
            // --i;

            /*
            int health;
            int armor;
            int damage;
            int precentConverter = 100;

            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * armor / precentConverter;

            Console.WriteLine($"Вам нанесли {damage} урона. У вас оста+" +
                $"лось {health}");
            */

            // сравнение через if
            /*int money;
            Console.Write("Машина стоит 1000. Сколько у вас денег? ");
            money = Convert.ToInt32( Console.ReadLine() );

            if (money >= 1000)
            {
                Console.WriteLine("Вам хватает денег на покупку автомобиля");
            }
            else
            {
                Console.WriteLine("Вам не хватает денег на покупку автомобиля");
            }*/

            // Условный оператор свитч
            /*string dayOfWeek;
            dayOfWeek = Console.ReadLine();
            switch (dayOfWeek)
            {
                case "понедельник":
                case "вторник":
                case "среда":
                case "четверг":
                case "пятница":
                    Console.WriteLine("Пора на работу");
                    break;
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("Можно отсыпаться");
                    break;
                default;
                    Console.WriteLine("Вы ввели неверную информацию");
                    break;
            }*/

            // Циклы
            // while
            /*int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32( Console.ReadLine() );
            while (age-- > 0)
            {
                Console.WriteLine($"С днем рождения. Вам: {age + 1} лет.");
            }*/

            // for
            /*for (i = 1; i < 10; i++)
            {
                Console.WriteLine($"Текущее значение переменной: {i}");
            }*/

        }
    }
}
