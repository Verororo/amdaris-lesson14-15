public class Staff : IObserver
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public void OrderApprove(Order order)
    {
        order.UpdateStatus("Ready for shipping");
    }
    public void Update(string message)
    {
        EmailService.SendEmail(Email, $"Hello {Name},\n\n{message}\n\n\n");
    }
    public void Subscribe(IObservable order)
    {
        order.AddObserver(this);
    }
    public void Unsubscribe(IObservable order)
    {
        order.RemoveObserver(this);
    }
}