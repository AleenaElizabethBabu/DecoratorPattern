using DecoratorPattern.Decorator;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorator
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return "Prefix: " + base.GetText();
        }
    }
}
