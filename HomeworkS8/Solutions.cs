namespace Homework
{
    class Solutions
    {
        /// <summary>Метод запускает в консоли решение задачи 54</summary>
        public static void Task54Sol()
        {
            int[,] array = Methods.AskSizeCreateArray();
            Methods.FillArray(array);
            Methods.PrintArray(array);
            Methods.SortInLineArray(array);
            Methods.PrintArray(array);
        }
        /// <summary>Метод запускает в консоли решение задачи 56</summary>
        public static void Task56Sol()
        {
            int[,] array = Methods.AskSizeCreateArray();
            if (array.GetLength(0) == array.GetLength(1))
            {
                Console.WriteLine("\nYOU MUST ENTER RECTANGULAR ARRAY SIZE!(ROWS MUST NOT BE EQUAL TO COLUMNS)\n");
                Task56Sol();
            }
            else
            {
                Methods.FillArray(array);
                Methods.PrintArray(array);
                int lineNumber = Methods.FindStringSmallestSum(array);
                Console.WriteLine($"\n\nLine number with the smallest sum is :\t{lineNumber + 1} \n");
            }
        }
        /// <summary>Метод запускает в консоли решение задачи 58</summary>
        public static void Task58Sol()
        {
            int[,] array1 = Methods.AskSizeCreateArray();
            Methods.FillArray(array1);
            Methods.PrintArray(array1);
            int[,] array2 = new int[array1.GetLength(0), array1.GetLength(1)];
            Methods.FillArray(array2);
            Methods.PrintArray(array2);
            Methods.PrintArray(Methods.MultiMatrix(array1, array2));
            Console.WriteLine();
        }
        /// <summary>Метод запускает в консоли решение задачи 60</summary>
        public static void Task60Sol()
        {
            int[,,] array = Methods.AskSizeCreate3DArray();
            if (array.GetLength(0) * array.GetLength(1) * array.GetLength(2) > 90)
            {
                Console.WriteLine("Too big for unique two digit numbers! Try to enter smaller values!");
            }
            else
            {
                Methods.RandomFill3DArray(array);
                Methods.Print3DArray(array);
            }
        }
        /// <summary>Метод запускает в консоли решение задачи 62</summary>
        public static void Task62Sol()
        {
            int value = 1;
            int[,] array = Methods.AskSizeCreateArray();
            Methods.SpiralFillArray(array, value);
            Methods.PrintArray(array);
        }
    }
}