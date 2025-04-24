public class Barista
{
    public Beverage Make(BeverageBuilder builder, params IComponent[] additionalIngridients)
    {
        builder.CreateBeverage();
        builder.SetName();
        builder.AddIngridients();
        if (additionalIngridients.Length > 0) 
        {
            builder.AddAdditionalIngridients(additionalIngridients);
        }
        return builder.Beverage;
    }
}