using System;

namespace AbstractFactory
{
    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Created Mac Checkbox");
        }
    }
}