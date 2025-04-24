public class Staff
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public void OrderApprove(Order order)
    {
        order.UpdateStatus("Ready for shipping");
    }
    public void HandleStatusChanged(object sender, StatusChangedEventArgs e)
    {
        EmailService.SendEmail(Email, $"Hello {Name},\n\n{e.Message}\n\n\n");
    }
}