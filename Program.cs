using Factory_Mnager;

public class program
{

    public static void Main(string[] args)
    {
        BeefResturant beefResturant = new BeefResturant();
        beefResturant.OrderBurger();

        VeggiResturant veggiResturant = new VeggiResturant();
        veggiResturant.OrderBurger();

        ChikenResturant chikenResturant = new ChikenResturant();
        chikenResturant.OrderBurger();

        Console.ReadLine();
    }

}

