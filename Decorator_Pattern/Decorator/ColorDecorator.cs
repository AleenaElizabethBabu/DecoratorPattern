// ColorDecorator.cs
using DecoratorPattern.Decorator;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorator
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m";
        }
    }
}
