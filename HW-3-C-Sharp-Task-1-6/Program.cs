//Задание 1
//Напишите метод, который отображает квадрат из некоторого символа. Метод принимает в качестве пара-
//метра: длину стороны квадрата, символ.

//Задание 2
//Напишите метод, который проверяет является ли переданное число «палиндромом». Число передаётся в
//качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
//Палиндром — число, которое читается одинаково как справа налево, так и слева направо. Например:
//1221 — палиндром;
//3443 — палиндром;
//7854 — не палиндром.

//Задание 3
//Напишите метод, фильтрующий массив на основании переданных параметров. Метод принимает параметры:
//оригинальный_массив, массив_с_данными_для_фильтрации.
//Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
//Например:
//1 2 6 -1 88 7 6 — оригинальный массив;
//6 88 7 — массив для фильтрации;
//1 2 - 1 — результат работы метода.

//Задание 4
//Создайте класс «Веб-сайт». Необходимо хранить в полях класса: название сайта, путь к сайту, описание
//сайта, ip адрес сайта. Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным
//полям через методы класса.

//Задание 5
//Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания, описа-
//ние журнала, контактный телефон, контактный e-mail.
//Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через
//методы класса.

//Задание 6
//Создайте класс «Магазин». Необходимо хранить в полях класса: название магазина, адрес, описание про-
//филя магазина, контактный телефон, контактный e-mail.
//Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через
//методы класса.

using System;

namespace HW_3_C_Sharp_Task_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            NewText text = new NewText("123454321");

            //Задание 1
            Console.WriteLine("Task 1");
            int size = 0;
            char ch;
            Console.Write("Input a size of the square - ");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a symbol - ");
            ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            text.GetSquare(ch, size);                     //Вызов метода отображения квадрата из символа
            Console.WriteLine($"{new string('-', 35)}\n");

            //Задание 2
            Console.WriteLine("Task 2");
            Console.Write("Input any text - ");
            NewText check = new NewText (Console.ReadLine());
            Console.WriteLine($"Is {check.text} a palindrome? - {check.CheckPalindrom()}");   //Вызов метода проверки на палиндром
            Console.WriteLine($"{new string('-', 35)}\n");

            //Задание 3
            Console.WriteLine("Task 3");
            int[] intArr1 = { 3, 5, 17, -1 };
            int[] intArr2 = { -1, 5 };
            int[] newInt = text.ExceptionFromArray(intArr1, intArr2);   //Вызов метода фильтрации данных в массиве 1 исключая данны из массива 2
            Console.Write($"Array before checking:  ");
            foreach (int item in intArr1)
                Console.Write($"{item} ");
            Console.Write($"\nArray for exception:  ");
            foreach (int item in intArr2)
                Console.Write($"{item} ");
            Console.Write($"\nArray after exception:  ");
            foreach (int item in newInt)
                Console.Write($"{item} ");
            Console.WriteLine($"\n{new string('-', 35)}\n");

            //Задание 4
            Console.WriteLine("Task 4");
            WebSite web1 = new WebSite ("Google", "https://www.google.com.ua", "8.8.8.8", "Searching site" );
            web1.Print();
            Console.WriteLine($"{new string('-', 35)}\n");

            //Задание 5
            Console.WriteLine("Task 5");
            Magazine cosmo = new Magazine("Cosmo", 2012, "776-57-18", "mailcosmo@gmail.com", "Nice women`s magazine");
            cosmo.SetPhoneEmail("774-41-31", "cosmo@email.com");
            cosmo.ShowAll();
            Console.WriteLine($"{new string('-', 35)}\n");

            //Задание 6
            Console.WriteLine("Task 6");
            Shop Dafi = new Shop("Dafi", "366-15-15", "s.Dnipro, st.Zaporozkoe av., 35", "dafi@ukrnet.ua");
            Dafi.Name = "Dafi-2000";
            Dafi.Address = "s. Dnipro, Star Boulevard, 1a";
            Dafi.Print();
        }
    }
}
