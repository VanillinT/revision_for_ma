using System;
using System.IO;
using System.Text;

namespace revision_for_marinochka
{
    class Program
    {
        // Main - точка входа в нашу программу
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n                                  HELLO MARINOCHKA\n\n");
            string ASCII_Path = @"assets/stegosaurus.txt";
            string ASCII = File.ReadAllText(ASCII_Path);
            Console.WriteLine(ASCII + "\n\n\n");

            // начнём с приколов:
            Console.WriteLine("Рандомный текст для проверки кодирования в консоли\n"); //текст не выводится из-за дефолтного кодирования символов (показывает только латиницу)

            // включим UNICODE(UTF8), там есть кириллица
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Проверка. Всё работает!\n\n");


            // сделаем конь соль по больше
            Console.SetWindowSize(170, 80);


            // операции над числами

            // инициализируем 2 числовые переменные
            int a = 5;
            double b = 4.2;

            // заметим, что можно писать + между строкой и числами, они сложатся в строку - шарп в таком простом случае сам делает преобразования int или double в string
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);


            Console.WriteLine("\n\nПроведём немного операций над чиселами:");
            Console.WriteLine("a + b = " + (a + b));

            Console.WriteLine("\nможно даже возводить в степень:");
            Console.WriteLine("a^2 = " +  (a^2));

            Console.WriteLine("\nно возводить переменные типа double в степень нельзя, поэтому делаем так:");
            Console.WriteLine("b * b = " + (b * b));

            Console.WriteLine("\nфишка - если int умножить на double или наоборот, в итоге получится int (без нецелой части) - так же работает с делением");
            Console.WriteLine("a * b = " + (a * b));



            Console.WriteLine("\n\nУСЛОВИЯ");

            bool based = true;

            if (based)
                Console.WriteLine("Это база"); // если под условием всего одна строка, можно не юзать скобочки { } 
            else if (1 > 5)
                Console.WriteLine("охуеть"); // если навести курсор на то что подчёркнуто пишет unreachable code detected - умный компилятор понимает, что 1 не больше 5
            else
                Console.WriteLine("Это не база");

            // switch { case }  тоже есть, не хочу его писать (

            Console.WriteLine("\n\nМАССИВЫ");


            // выглядят намного лучше чем в плюсах:
            int[] array_1 = new int[4] { 1, 2, 3, 4 };

            // int[] - указываем, что тип переменной - массив из int
            // array_1 - называние переменной
            // new int[4] - создаём 'ящик' для переменных типа int длиной 4
            // { 1, 2, 3, 4 } - указываем что в этом ящие есть по дефолту

            Console.WriteLine("\nвыведем второй элемент первого массива (считам с 0)");
            Console.WriteLine("array_1[1] = " + array_1[1]);

            int[] array_2 = { 1, 2, 3 }; // можно не писать 'new int[...]' а сразу создать нужный массив произвольной длины


            Console.WriteLine("\n\nЦИКЛЫ");

            Console.WriteLine("\nfor\n");
            // выведем каждый элемент в array_2: 
            for(int i=0; i<array_2.Length; i++) // через точку можно получать всякие штуки, вроде длины массива - Length (кол-во элементов в нём)
            {
                Console.WriteLine($"array_2[{i}]: " + array_2[i]); // если поставить доллар перед строкой, то внутри строки можно писать переменные, засунув в { }
            }

            Console.WriteLine("\n\nforeach\n");
            // то же самое можно сделать намного проще при помощи foreach - он сам бежит по всем элементам массива 
            foreach(int element in array_2) // int element - тип и название для текущего элемента на каждой итерации
            {
                Console.WriteLine($"array_2[{element}]: " + element);
            }

            Console.WriteLine("\n\nwhile\n");
            // сделаем то же самое через while - поможет переменная-счётчик, которую мы будем увеличивать при каждой итерации на 1:
            int counter = 0;
            while(counter < array_2.Length)
            {
                Console.WriteLine($"array_2[{counter}]: " + array_2[counter]);
                counter++;
            }
        }
    }
}
