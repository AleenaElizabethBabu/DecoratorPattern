using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Components
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "This is the text.";
        }
    }
}
