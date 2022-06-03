namespace Calculator 
{
    class MainScreen
    {
        static void Main(string[] args)
        {
            bool flag = true;
            var scrOper = new AskingOperator();
            var scrNum = new EnterNumber();
            double sumNum;
            int i = 0;
            
            Console.WriteLine("Calculator");
            
            while (flag)
            {
                var Oper = scrOper.GetOperator(); 
                double num1 = scrNum.GetNumber();

                if (i == 0)
                {
                    double num2 = scrNum.GetNumber();
                    i++;
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

                Console.WriteLine("Press "C" to Continues? ");
                string check = Console.ReadLine();

                if (check =! "C" || check != "c")
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
