using System.Diagnostics;

namespace Decoratorv2.Computers;

//exp:1950
public class Computer
{
    public void Start()
    {
        Console.WriteLine($"{GetType().Name} is starting");
    }
    public void ShutDown()
    {
        Console.WriteLine($"{GetType().Name} is shutting down");

    }
}

//exp:1970
public class Laptop : Computer
{
    public void OpenLid()
    {
        Debug.WriteLine($"{GetType().Name}'s lid is opening");
    }
    public void CloseLid()
    {
        Debug.WriteLine($"{GetType().Name}'s lid is closing");
    }
}
//exp:1990
public class LaptopDecorator : Laptop
{
    public virtual void OpenLid()
    {
        //do something
        base.OpenLid();
    }
    public virtual void CloseLid()
    {
        base.CloseLid();
        //do something
    }
}
public class DellLaptop : LaptopDecorator
{
    public override void CloseLid()
    {
        base.CloseLid();
        Debug.WriteLine("Dell laptop is sleeping");
    }
    public override void OpenLid()
    {
        Debug.WriteLine("Dell laptop is waking up");
        base.OpenLid();
    }
}
public class AppleLaptop : Laptop
{
    
}