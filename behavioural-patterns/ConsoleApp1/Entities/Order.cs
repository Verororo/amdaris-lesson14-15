using ConsoleApp1.Services;

public class Order : IObservable
{
    private List<IObserver> Observers { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    
    public Order(Customer customer, string name)
    {
        Observers = new List<IObserver>();

        Name = name;
        Subscribe(customer);

        Staff responsibleStaff = StaffService.freeStaff.First();
        Subscribe(responsibleStaff);

        UpdateStatus("Pending");
    }
    public void Subscribe(IObserver observer)
    {
        Observers.Add(observer);
    }
    public void Unsubscribe(IObserver observer)
    {
        Observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (IObserver observer in Observers)
        {
            observer.Update($"{Name} is now {Status}");
        }
    }
    public void UpdateStatus(string status)
    {
        Status = status;
        NotifyObservers();
    }
}
