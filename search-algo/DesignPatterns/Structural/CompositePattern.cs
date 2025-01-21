namespace search_algo.DesignPatterns.Structural;

public static class CompositePatternExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Composite Pattern Example");
        
        Leaf mouse = new Leaf {Name = "Mouse", Price = 500};
        Leaf keyboard = new Leaf {Name = "Keyboard", Price = 1000};
        Leaf monitor = new Leaf {Name = "Monitor", Price = 5000};
        Leaf cpu = new Leaf {Name = "CPU", Price = 10000};
        Leaf hdd = new Leaf {Name = "HDD", Price = 5000};
        
        Composite peripherals = new Composite {Name = "Peripherals"};
        peripherals.AddComponent(mouse);
        peripherals.AddComponent(keyboard);
        peripherals.AddComponent(monitor);
        
        Composite cabinet = new Composite {Name = "Cabinet"};
        cabinet.AddComponent(cpu);
        cabinet.AddComponent(hdd);
        
        peripherals.DisplayPrice();
        cabinet.DisplayPrice();
        
 
        Console.WriteLine("Composite Pattern Example Ends");
    }
}

public interface IComponent
{
    void DisplayPrice();
}
public class Leaf : IComponent
{
    public int Price { get; set; }
    public string Name { get; set; }
    public void DisplayPrice()
    {
        Console.WriteLine($"{Name} : {Price}");
    }
}

public class Composite : IComponent
{
    public string Name { get; set; }
    private List<IComponent> _components = new List<IComponent>();
    public void AddComponent(IComponent component)
    {
        _components.Add(component);
    }
    
    public void RemoveComponent(IComponent component)
    {
        _components.Remove(component);
    }
    
    public void DisplayPrice()
    {
        Console.WriteLine($"****{Name}****");
        foreach (var component in _components)
        {
            component.DisplayPrice();
        }
    }
}


