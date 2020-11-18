using System;

public class Average
{
    public static void Main()
    {
        double average, markDouble, sum = 0, markCounter = 0;
        string markString;

        Console.Write("Insert a mark: ");
        markString = Console.ReadLine();   /*we read the mark as a string to 
        check the word "end"*/

        while(markString != "end")    /*while user does not introduce the word 
        "end" we convert it to double to work with it*/
        {
            markDouble = Convert.ToDouble(markString);
            markCounter++;   //counter for marks given by user
            sum += markDouble;    //sum of all the marks is stored in variable
            Console.Write("Insert a mark: ");
            markString = Console.ReadLine();
        }

        if(markCounter != 0)    //average is calculated if user inserts marks
        {
            average = sum / markCounter;
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
