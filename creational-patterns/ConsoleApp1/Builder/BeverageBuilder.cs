public abstract class BeverageBuilder
{
    public Beverage Beverage { get; set; }
    public void CreateBeverage()
    {
        Beverage = new Beverage();
    }
    public abstract void SetName();
    public abstract void AddIngridients();
    public void AddAdditionalIngridients(IComponent[] additionalComponents)
    {
        Beverage.AdditionalIngridients = [.. additionalComponents];
    }
}
