public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component) { }

    public override string GetText()
    {
        return $"\u001b[31m{component.GetText()}\u001b[0m";  // Red color
    }
}
