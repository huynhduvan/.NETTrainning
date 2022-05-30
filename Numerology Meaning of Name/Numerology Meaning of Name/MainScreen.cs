namespace Numerology_Meaning_of_Name 
{
    static class MainScreen
    {
        static void Main(string[] args)
        {
            //Get full name
            var scrFullName = new FullName();
            var userName = scrFullName.GetUserName();
            while (string.IsNullOrEmpty(userName)) //Check error
            {
                Console.WriteLine("User Name is missing");
                userName = scrFullName.GetUserName();
            }
            
            //Convert name to number
            var scrConvert = new ConvertToNumber();
            scrConvert.SetNumber(userName);
            int numberOfName = scrConvert.GetNumber();
            
            //Meaning of number
            var scrMeaning = new MeaningOfNumber();
            scrMeaning.SetMeaning(numberOfName);
            var meaning = scrMeaning.GetMeaning();
            
            //Output
            var output = $"Your Active Number is {numberOfName} and its Meaning {meaning}";
            Console.WriteLine(output);
        }
    }
}