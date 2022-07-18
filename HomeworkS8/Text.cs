namespace Homework
{
    class Text
    {
        /// <summary>Метод выводит в консоль меню домашнего задания</summary>
        public static void Menu()
        {
            Console.WriteLine("\nSELECT A MENU ITEM AND PRESS THE CORRESPONDING KEY:\n");
            Console.WriteLine("If you want to choose   Task54 press the button:\t1");
            Console.WriteLine("\t\t\tTask56 press the button:\t2");
            Console.WriteLine("\t\t\tTask58 press the button:\t3");
            Console.Write("\nIf you want to exit program press any other button\t");
        }
        /// <summary>Метод выводит в консоль условие задачи 54</summary>
        public static void Task54()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.");
        }
        /// <summary>Метод выводит в консоль условие задачи 56</summary>
        public static void Task56()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        }
        /// <summary>Метод выводит в консоль условие задачи 58</summary>
        public static void Task58()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 58: Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.");
        }
    }
}