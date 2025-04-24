public static class EmailService
{
    public static void SendEmail(string email, string message)
    {
        Console.WriteLine($"To: {email}");
        Console.WriteLine($"{message}");
    }
}
