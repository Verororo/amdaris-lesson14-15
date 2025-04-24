public class EspressoBuilder : BeverageBuilder
{
    public override void SetName()
    {
        Beverage.Name = "Espresso";
    }

    public override void AddIngridients()
    {
        var blackCoffee = new BlackCoffee();

        Beverage.CoreIngridients.Add(blackCoffee);
    }
}
