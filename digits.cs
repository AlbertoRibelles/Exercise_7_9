using System;

class digits
{
    static void Main()
    {
        //counters for number depending on how many digits they have
        int singleDigit = 0, doubleDigit = 0, tripleDigit = 0, multipleDigit = 0;
        string number;
        
        Console.Write("Insert a number: ");
        number = Console.ReadLine(); /*read the number as string to check the 
        word "end"*/
        
        //while user does not introduce "end" we set different conditions
        while (number!="end")
        {
            int input = Convert.ToInt32(number);
            
            if (input != 0)
            {
                if (input/10 == 0)
                    singleDigit ++;
                else if (input/100 == 0)
                    doubleDigit ++;
                else if (input/1000 == 0)
                    tripleDigit ++;
                else
                    multipleDigit++;
            }
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
        singleDigit, doubleDigit, tripleDigit, multipleDigit);
    }
}
