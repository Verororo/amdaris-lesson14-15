public class Customer : IObserver
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public Order CreateOrder(string name)
    {
        var order = new Order(this, name);
        return order;
    }
    public void Update(string message)
    {
        EmailService.SendEmail(Email, $"Dear {Name},\n\n{message}\n\n\n");
    }
}
