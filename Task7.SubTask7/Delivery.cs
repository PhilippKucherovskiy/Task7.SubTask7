
using System;

abstract class Delivery
{
    public string Address;
    public string[] UserData;
    public virtual void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}
    




