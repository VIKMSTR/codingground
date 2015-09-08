using System.IO;
using System;
class Vlak
{
    public void VypisNevirtualni(){ Console.WriteLine("Vlak");}
    public virtual void VypisVirtualni(){ Console.WriteLine("Vlak");}
}
class NakladniVlak : Vlak
{
    public new void VypisNevirtualni(){ Console.WriteLine("Nakladni Vlak");}
    public override void VypisVirtualni(){ Console.WriteLine("Nakladni Vlak");}
}


class Program
{
    static void Main()
    {
        Vlak v1 = new Vlak();
        Vlak v2= new NakladniVlak();
        NakladniVlak v3= new NakladniVlak();
        
        Console.WriteLine("Typ Vlak, Instance Vlak:");
        v1.VypisNevirtualni();
        v1.VypisVirtualni();
        Console.WriteLine("Typ Vlak, Instance NakladniVlak:");
        v2.VypisNevirtualni();
        v2.VypisVirtualni();
        Console.WriteLine("Typ NakladniVlak, Instance NakladniVlak:");
        v3.VypisNevirtualni();
        v3.VypisVirtualni();
    }
}
