using System;


namespace CountingInLetters
{
    class Converter
    {
        private string _userInput;
        private long _mainInt;
        private bool _convertSuccess;
        private string _letters;
        public Converter(string UserInput)
        {
            _userInput = UserInput;
        }

        public bool ConvertToLetter()
        {
            //Can this be converted to a long?
            _convertSuccess = long.TryParse(_userInput, out _mainInt);
            IsConvertSuccess(_convertSuccess);
            return _convertSuccess;
        }
        
        private void IsConvertSuccess(bool ConvertSuccess)
        {
            if (ConvertSuccess)
            {
                Console.WriteLine("Converted...");
                //System.Threading.Thread.Sleep(1000);       Uncomment delay to simulate processing.
                Convert(_mainInt);
                
            }
            //Ask for User Input again when conversion to long fails.
            else
            {
                Console.WriteLine("Cannot Convert Int to Characters...Please Try Again.");
                _userInput = Console.ReadLine();
                ConvertToLetter();

            }

        }
        public void Convert(long _mainInt)
        {
            //Where we convert our long into a Letter. This is done by converting the ASCII code into a Character. 
            while (_mainInt > 0)
            {
                char c;

                //We are subtracting 1 so that the first index starts at 1 and not 0. 
                //'A' here is the same as adding 65.
                c = (char)(((_mainInt - 1) % 26) + 'A'); 

                //Converting the character into string form and adding it to our string which will print our final letters.
                _letters = ((char)c).ToString() + _letters;

                //This next line will execute division so that while our long is greater than 26 it will loop through once more and prepend any other characters.
                _mainInt = (_mainInt - 1) / 26;
            }
            Console.WriteLine(_letters);  //Display Results.

        }
    }
}
