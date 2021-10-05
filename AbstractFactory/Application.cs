namespace AbstractFactory
{
    public class Application
    {
        private IButton _button;
        private ICheckbox _checkbox;

        private readonly IGuiFactory _guiFactory;

        public Application(IGuiFactory guiFactory)
        {
            _guiFactory = guiFactory;
        }

        public void CreateUi()
        {
           _button = _guiFactory.CreateButton();
           _checkbox = _guiFactory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }

    }
}