using System;
using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleInput
    {
        public static string StringNumberA { get; private set; }
        public static string StringNumberB { get; private set; }

        
        public static void Input()
        {
            ConsoleOutput.InputMessage("A");
            StringNumberA = ReadLine();
            ConsoleOutput.InputMessage("B");
            StringNumberB = ReadLine();
        }
    }
}
