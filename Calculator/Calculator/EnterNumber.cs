namespace Calculator;

public class EnterNumber
{
    public double GetNumber()
    {
        double num = "";

        Console.WriteLine("Enter a number:  ");
        num = Console.ReadLine();
        return num;
    }
}
