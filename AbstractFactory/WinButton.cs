using System;

namespace AbstractFactory
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Created Windows Button");
        }
    }
}