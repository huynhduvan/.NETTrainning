namespace Calculator;

public class EnterNumber
{
    public double GetNumber()
    {
        var oper = "";

        Console.WriteLine("Enter Operator:  ");
        oper = Console.ReadLine();
        return oper;
    }
}