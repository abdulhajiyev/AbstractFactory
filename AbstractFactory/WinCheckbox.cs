using System;

namespace AbstractFactory
{
    public class WinCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Created Windows Checkbox");
        }
    }
}