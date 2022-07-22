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
        /// <summary>Метод создает новую матрицу произведения элементов двух предыдущих матриц.</summary>
        public static int[,] MultiMatrix(int[,] array1, int[,] array2)
        {
            int[,] multArray = new int[array1.GetLength(0), array1.GetLength(1)];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    multArray[i, j] = array1[i, j] * array2[i, j];
                }
            }
            return multArray;
        }
        /// <summary>Метод заполняет массив по спирали</summary>        
        /// <param name="array">Массив который надо заполнить</param>
        /// <param name="value">Число с которого начнется заполнение</param>
        public static void SpiralFillArray(int[,] array, int value)
        {
            int size = array.GetLength(0);
            if (size > array.GetLength(1)) size = array.GetLength(1);
            if (array.GetLength(0) * array.GetLength(1) % 2 != 0) size++;
            else if (array.GetLength(0) < array.GetLength(1)) size++;
            int i = 0;
            int j = 0;
            for (int count = 0; count < size / 2; count++)
            {
                for (i = count, j = count; j < array.GetUpperBound(1) + 1; j++)
                {
                    if (array[i, j] != 0) break;
                    else array[i, j] = value++;
                }
                if (j >= array.GetUpperBound(1) - count) j--;
                i++;
                for (; i < array.GetUpperBound(0) + 1; i++)
                {
                    if (array[i, j] != 0) break;
                    else array[i, j] = value++;
                }
                j--;
                if (i >= array.GetUpperBound(0) - count) i--;
                for (; j >= array.GetLowerBound(1); j--)
                {
                    if (array[i, j] != 0) break;
                    else array[i, j] = value++;
                }
                i--;
                if (j <= array.GetLowerBound(1) + count) j++;
                for (; i > array.GetLowerBound(0) + count; i--)
                {
                    if (array[i, j] != 0) break;
                    else array[i, j] = value++;
                }
                if (i < array.GetLowerBound(0) - count) i++;
            }
        }
        /// <summary>Метод спрашивает размерность массива и создает пустой int массив указанного размера</summary>
        public static int[,,] AskSizeCreate3DArray()
        {
            int m = 0, n = 0, h = 0;
            Console.Write("\nEnter height of array:\t\t");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter width of array:\t\t");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter length of array:\t\t");
            h = Convert.ToInt32(Console.ReadLine());
            int[,,] array = new int[m, n, h];
            return array;
        }
        /// <summary>Метод заполняет массив двузначными случайными уникальными числами от 10 до 99</summary>
        public static void RandomFill3DArray(int[,,] array)
        {
            int value = 10;
            List<int> twodigits = new List<int>(90);
            for (int i = 0; i < twodigits.Capacity; i++)
            {
                twodigits.Add(value++);
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        int temp = twodigits[new Random().Next(0, twodigits.Count)];
                        array[i, j, k] = temp;
                        twodigits.Remove(temp);
                    }
                }
            }
        }
        /// <summary>Метод печатает int массив в консоли</summary>
        public static void Print3DArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\n");
            }
        }
    }
}