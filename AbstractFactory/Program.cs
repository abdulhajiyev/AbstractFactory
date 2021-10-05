using System;

namespace AbstractFactory
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Application app;
            IGuiFactory factory;
            Console.WriteLine("Select os:\n1) Mac\n2) Windows");
            var os = Convert.ToInt32(Console.ReadLine());
            switch (os)
            {
                case 1:
                    factory = new MacFactory();
                    app = new Application(factory);
                    break;
                default:
                    factory = new WinFactory();
                    app = new Application(factory);
                    break;
            }
            app.Paint();
        }
    }
}