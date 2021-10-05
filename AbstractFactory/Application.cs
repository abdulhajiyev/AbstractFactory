namespace AbstractFactory
{
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGuiFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}