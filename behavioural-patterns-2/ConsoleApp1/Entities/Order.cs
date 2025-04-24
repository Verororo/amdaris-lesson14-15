using ConsoleApp1.Services;
using System;

public class Order
{
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    
    public event StatusChangedEventHandler StatusChanged;
    
    public string Name { get; set; }
    private string status;
    public string Status 
    { 
        get { return status; }
        set 
        { 
            status = value;
            OnStatusChanged(new StatusChangedEventArgs($"{Name} is now {status}"));
        } 
    }
    
    public Order(Customer customer, string name)
    {
        Name = name;
        
        StatusChanged += customer.HandleStatusChanged;
        
        Staff responsibleStaff = StaffService.freeStaff.First();
        StatusChanged += responsibleStaff.HandleStatusChanged;
        
        Status = "Pending";
    }
    
    public void UpdateStatus(string status)
    {
        Status = status;
    }
    
    protected virtual void OnStatusChanged(StatusChangedEventArgs e)
    {
        StatusChanged?.Invoke(this, e);
    }
}

public class StatusChangedEventArgs : EventArgs
{
    public string Message { get; }
    
    public StatusChangedEventArgs(string message)
    {
        Message = message;
    }
}
