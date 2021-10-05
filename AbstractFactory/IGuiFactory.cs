namespace AbstractFactory
{
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}