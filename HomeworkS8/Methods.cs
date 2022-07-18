namespace Homework
{
    public class Methods
    {
        /// <summary>Метод печатает int массив в консоли</summary>
        public static void PrintArray(int[,] array)
        {
            Console.WriteLine("\nResulting array:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>Метод заполняет массив случайными числами от -99 до 100</summary>
        public static int[,] FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(-99, 100);
                }
            }
            return array;
        }
        /// <summary>Метод спрашивает размерность массива и создает пустой int массив указанного размера</summary>
        public static int[,] AskSizeCreateArray()
        {
            Console.Write("\nEnter number of lines: \t\t");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number of columns:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m, n];
            return array;
        }
        /// <summary>Метод упорядочит по возрастанию элементы каждой строки в двумерном массиве</summary>
        public static int[,] SortInLineArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    int minPosition = j;
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, k] < array[i, minPosition]) minPosition = k;
                    }
                    int temporary = array[i, j];
                    array[i, j] = array[i, minPosition];
                    array[i, minPosition] = temporary;
                }
            }
            return array;
        }
        /// <summary>Метод находит строку с наименьшей суммой элементов и выдает номер этой строки.</summary>
        public static int FindStringSmallestSum(int[,] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                list.Add(sum);
                Console.WriteLine();
                Console.Write($"sum {i + 1} line = \t{sum}");
            }
            return list.IndexOf(list.Min());
        }

    }
}