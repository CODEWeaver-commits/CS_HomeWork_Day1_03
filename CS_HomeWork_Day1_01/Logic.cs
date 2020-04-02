using System;
using ConsoleIO;

namespace CS_HomeWork_Day1_01
{
    public static class Logic
    {
        public static string ErrorMessage { get; private set; }
        private static byte NumberA { get; set; }
        private static byte NumberB { get; set; }
        
        private static void StringToByte()
        {
            NumberA = byte.Parse(ConsoleInput.StringNumberA);
            NumberB = byte.Parse(ConsoleInput.StringNumberB);
        }
        private static void Cycle()
        {
            StringToByte();
            while (NumberA != NumberB + 1)
            {
                for (byte i = 0; i < NumberA; i++)
                {
                    ConsoleOutput.WriteOutput(NumberA);
                }
                Console.WriteLine();
                NumberA++;
            }
        }
        public static void Initialization()
        {
            ConsoleInput.Input();
            while(!IsValidNumbers(ConsoleInput.StringNumberA, ConsoleInput.StringNumberB))
            {
                ConsoleOutput.writeMessage(ErrorMessage);
                ConsoleInput.Input();
            }
        }

        public static void Output()
        {
            ConsoleOutput.OutputMessage();
            Cycle();
        }

        static bool IsValidNumbers(string A, string B)
        {
            if (!(byte.TryParse(A, out byte numberA) | byte.TryParse(B, out byte numberB)))
            {
                ErrorMessage = "Ошибка! Введите число!";
                return false;
            }
            else if (numberA > numberB)
            {
                ErrorMessage = "Ошибка! Число А не можеть быть больше числа B."
                         + "\nПовторите попытку ввода."; 
                return false;
            }
            else if ((numberA <= 0 & numberB <= 0) | (numberA <= 0 | numberB <= 0))
            {
                ErrorMessage = "Ошибка! Числа должны быть больше 0.";
                return false;
            }
            else if (numberA > 255 & numberB > 255)
            {
                ErrorMessage = "Ошибка! Числа должны быть меньше 255.";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}