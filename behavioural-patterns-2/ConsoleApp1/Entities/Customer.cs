﻿public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public Order CreateOrder(string name)
    {
        var order = new Order(this, name);
        return order;
    }
    
    public void HandleStatusChanged(object sender, StatusChangedEventArgs e)
    {
        EmailService.SendEmail(Email, $"Dear {Name},\n\n{e.Message}\n\n\n");
    }
}
