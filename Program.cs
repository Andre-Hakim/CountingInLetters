using System;

namespace CountingInLetters
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Provide a Number You Would Like to Convert Into Letters.");
            //Loop until User Exits
            while (true)                                            
            {
                //Ask for UserInput
                string UserInput = Console.ReadLine();
                //Call Converter Class
                Converter converting = new Converter(UserInput);
                //Use ConverToLetter Method
                converting.ConvertToLetter();                       
            }


        }
    }
}
