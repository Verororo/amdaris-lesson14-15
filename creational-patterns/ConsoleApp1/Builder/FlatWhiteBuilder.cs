public class FlatWhiteBuilder : BeverageBuilder
{
    public override void SetName()
    {
        Beverage.Name = "Flat white";
    }

    public override void AddIngridients()
    {
        var blackCoffee = new BlackCoffee();
        var milk = new RegularMilk();

        Beverage.CoreIngridients.Add(blackCoffee);
        Beverage.CoreIngridients.Add(blackCoffee);
        Beverage.CoreIngridients.Add(milk);
    }
}
