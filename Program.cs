using System;

class Program
{ 
    //Opening the fridge door
    static void Main()
    {
        Wine w = new Wine(19.99m); // we used Wine in class so imma use it here
        Console.WriteLine($"Price: {w.Price}"); //this is the price you gonna pay for your yummylicious adult grape juice
    }

}   // closing frige door and aligning the curly braces

public class Wine
{
    public decimal Price; //public come on in, the water's fine
    private int superPrivateSecret = 420; // **music** cant touch this

    public Wine(decimal price)
    {
        Price = price;
    }
}
