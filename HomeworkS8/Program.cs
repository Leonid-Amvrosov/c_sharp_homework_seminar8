namespace Homework
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Text.Menu();
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.D1)
                {
                    Text.Task54();
                    Solutions.Task54Sol();
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    Text.Task56();
                    Solutions.Task56Sol();
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    Text.Task58();
                    Solutions.Task58Sol();
                }
                else
                {
                    Console.WriteLine("\n\nPROGRAM IS OVER!\n");
                }
            }
            catch
            {
                Console.WriteLine("\nINCORRECT DATA TRY AGAIN!");
                Main();
            }
        }
    }
}
