namespace Numerology_Meaning_of_Name;

public class FullName
{
    public string? GetUserName()
    {
        var userName = "";
        
        Console.WriteLine("Input user name: ");
        userName = Console.ReadLine();
        return userName;
    }
}