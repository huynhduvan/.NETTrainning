namespace Numerology_Meaning_of_Name;

public class ConvertToNumber
{
    int _numberOfName;
    int _totalNumber = 0;

    public void SetNumber(string userName)
    {
        foreach (char ch in userName.ToUpper())
        {
            string c = ch.ToString();
            
            if (c == "A" || c == "J" || c == "S")
            {
                int numb = 1;
                _totalNumber += numb;
            }
            else if (c == "B" || c == "K" || c == "T") 
            {
                int numb = 2;
                _totalNumber += numb;
            }
            else if (c == "C" || c == "L" || c == "U") 
            {
                int numb = 3;
                _totalNumber += numb;
            }
            else if (c == "D" || c == "M" || c == "V") 
            {
                int numb = 4;
                _totalNumber += numb;
            }
            else if (c == "E" || c == "N" || c == "W") 
            {
                int numb = 5;
                _totalNumber += numb;
            }
            else if (c == "F" || c == "O" || c == "X") 
            {
                int numb = 6;
                _totalNumber += numb;
            }
            else if (c == "G" || c == "P" || c == "Y") 
            {
                int numb = 7;
                _totalNumber += numb;
            }
            else if (c == "H" || c == "Q" || c == "Z") 
            {
                int numb = 8;
                _totalNumber += numb;
            }
            else if (c == "I" || c == "R")
            {
                int numb = 9;
                _totalNumber += numb;
            }
        }

        int integer1 = _totalNumber / 10;
        _numberOfName = integer1 + _totalNumber % 10;
        
        while (_numberOfName >= 10)
        {
            int inter2 = _numberOfName / 10;
            _numberOfName = inter2 + _numberOfName % 10;
        }
    }
    
    public int GetNumber()
    {
        return _numberOfName;
    }
}