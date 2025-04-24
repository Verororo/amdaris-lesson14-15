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
        customer.Subscribe(this);

        Staff responsibleStaff = StaffService.freeStaff.First();
        responsibleStaff.Subscribe(this);

        UpdateStatus("Pending");
    }
    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
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
