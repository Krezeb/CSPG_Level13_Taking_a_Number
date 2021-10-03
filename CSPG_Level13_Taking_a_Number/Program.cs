using System;

namespace CSPG_Level13_Taking_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            AskForNumberMinMax("What is the airspeed velocity of an unladen swallow ?");
        }
        static int AskForNumber(string input)
        {
            int convertedNumber = Convert.ToInt32(Console.ReadLine());
            return convertedNumber;
        }
        static int AskForNumberMinMax(string input, int speedMin = 0, int speedMax = 100)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(input);
                int convertedNumber = AskForNumber(input);
                if (convertedNumber > speedMin && convertedNumber < speedMax)
                {
                    return convertedNumber;
                }
            }
        }
    }
}
//Challenge Taking a Number 100 XP
//Many previous tasks have required getting a number from a user.To save time writing out this code over 
//and over, you have decided to make a method to do this common task.
//Objectives:
//• Make a method with the signature int AskForNumber(string text). Display the text parameter 
//on the command line. Retrieve a response from the user, convert it to an int, and return it. Sample 
//usage: int result = AskForNumber("What is the airspeed velocity of an unladen 
//swallow ? ");
//• Make a method with the signature int AskForNumberInRange(string text, int min, int
//max).Only return if the entered number is between the min and max values.Otherwise, ask again.
//• Place this method in at least one of your previous programs to improve it.