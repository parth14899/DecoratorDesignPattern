using System;

class Program
{
    static void Main()
    {
        // Create the base component
        IComponent<string> component = new ConcreteComponent();
        
        // decorators
        IComponent<string> plainDecorated = new PlainDecorator(component);
        IComponent<string> upperCaseDecorated = new UpperCaseDecorator(component);
        IComponent<string> colorDecorated = new ColorDecorator(component);

        //OutPut in Console 
        Console.WriteLine("Plain Decorator: " + plainDecorated.GetText());
        Console.WriteLine("Upper Case Decorator: " + upperCaseDecorated.GetText());
        Console.WriteLine("Color Decorator: " + colorDecorated.GetText());
    }
}
