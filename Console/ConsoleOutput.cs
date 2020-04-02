using System;
using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleOutput
    {
        public static void writeMessage(string Message)
        {
            Clear();
            WriteLine(Message);
            WriteLine("Для продолжения нажмите любую клавишу...");
            ReadKey();
            Clear();
        }
        public static void InputMessage(string number)
        {
            Console.Write($"Введите число {number}: ");
        }

        public static void OutputMessage()
        {
            WriteLine();
            WriteLine("Результат:");
        }

        public static void WriteOutput(byte number)
        {
            Write(number + " ");
        }
    }
}
