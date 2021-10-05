using System;

namespace AbstractFactory
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Select os:\n1) Mac\n2) Windows");
            var os = Convert.ToInt32(Console.ReadLine());
            IGuiFactory factory = os switch
            {
                1 => new MacFactory(),
                _ => new WinFactory()
            };
            var app = new Application(factory);
            app.CreateUi();
            app.Paint();
        }
    }
}