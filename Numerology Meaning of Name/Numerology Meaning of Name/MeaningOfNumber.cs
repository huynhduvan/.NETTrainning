namespace Numerology_Meaning_of_Name;

public class MeaningOfNumber
{
    string _meaning = "";
    
    public void SetMeaning(int number)
    {
        switch (number)
        {
            case 1:
                _meaning = "Meaning of number 1";
                break;
            case 2:
                _meaning = "Meaning of number 2";
                break;
            case 3:
                _meaning = "Meaning of number 3";
                break;
            case 4:
                _meaning = "Meaning of number 4";
                break;
            case 5:
                _meaning = "Meaning of number 5";
                break;
            case 6:
                _meaning = "Meaning of number 6";
                break;
            case 7:
                _meaning = "Meaning of number 7";
                break;
            case 8:
                _meaning = "Meaning of number 8";
                break;
            case 9:
                _meaning = "Meaning of number 9";
                break;
        }
    }

    public string GetMeaning()
    {
        return _meaning;
    }
}