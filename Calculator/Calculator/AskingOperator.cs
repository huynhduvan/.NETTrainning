namespace Calculator;

public class AskingOperator
{
    public string? GetOperator()
    {
        var oper = "";

        Console.WriteLine("Enter Operator:  ");
        oper = Console.ReadLine();
        return oper;
    }
}