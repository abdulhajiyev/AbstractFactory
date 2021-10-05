namespace AbstractFactory
{
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton() => new MacButton();

        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}