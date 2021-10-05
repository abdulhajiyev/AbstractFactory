﻿namespace AbstractFactory
{
    public class WinFactory : IGuiFactory
    {
        public IButton CreateButton() => new WinButton();

        public ICheckbox CreateCheckbox() => new WinCheckbox();
    }
}