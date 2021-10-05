using System;

namespace AbstractFactory
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Created Mac Button");
        }
    }
}