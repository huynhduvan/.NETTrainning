namespace Calculator 
{
    class MainScreen
    {
        static void Main(string[] args)
        {
            bool flag = true;
            var scrOper = new AskingOperator();
            var scrNum = new EnterNumber();
            
            Console.WriteLine("Calculator");
            
            var Oper = scrOper.GetOperator();

            for (int i = 0; i < 3; i++)
            {
                
            }

            while (flag)
            {
                Console.Write("Enter a Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                if (sumNum == 0)
                {
                    Console.Write("Enter a Number: ");
                    double num = Convert.ToDouble (Console.ReadLine());
                     num2 = num;
                }
                
                if (Oper == "+")
                {
                    
                    sumNum = num1 + num2;
                } 
                else if (Oper == "-")
                {
                    sumNum = num1 - num2;
                } 
                else if (Oper == "*")
                {
                    sumNum = num1 * num2;
                } 
                else if (Oper == "/")
                {
                     sumNum = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Incorrect Operator");
                }


                Console.WriteLine("Sum:  {0}",sumNum);

                Console.WriteLine("Quit (Q)? ");
                string check = Console.ReadLine();

                if (check == "Q" || check == "q")
                {
                    flag = false;
                }
                else
                {
                    num2 = sumNum;
                }
            }
        }
    }
}