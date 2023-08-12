namespace H1_Extra_Hex
{
    internal class Program
    {
        static void Main()
        {
            // Infinite while loop.
            while (true)
            {
                // Changes text color to white.
                Console.ForegroundColor = ConsoleColor.White;

                // Creates string for user input, called "input" and changes text color to red.
                string input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                // If the "input" variable is empty, then write error and start the while loop over.
                if (input == string.Empty)
                {
                    Console.WriteLine("Empty string, please write a hexcode");
                    continue;
                }

                // If the input does not contain a hashtag, then it outputs an error and starts over.
                if (!input.Contains("#"))
                {
                    Console.WriteLine("Hex has to contain # in the beginning");
                    continue;
                }

                // Removes the # from the input variable
                input = input.Remove(0, 1);

                // Checks if the input is either too short or too long and if it is, then it restarts the loop.
                if (input.Length < 3 || input.Length > 6)
                {
                    Console.WriteLine("Need a minimum of 3 numbers and a maximum of 6 numbers");
                    continue;
                }

                // Calls method to check if its hex characters, if it is not, then it outputs an error and the valid characters. Repeats the loop.
                if (!IsHexCharacters(input))
                {
                    Console.WriteLine("Invalid characters!");
                    Console.WriteLine("Valid characters: #ABCDEF012345679");
                    continue;
                }
                
                // If we reach this part of the code, then its a valid hexcode! Changes text color to green and says its valid, in the console.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your hexcode is valid!");
            }
        }

        static bool IsHexCharacters(string input)
        {
            // Creates a char array and converts input to CharArray.
            char[] chars = input.ToCharArray();

            // string of allowed characters
            string allowedCharacters = "aAbBcCdDeEfF0123456789";

            // Checks each char in the array, if any characters arent allowed it will return false.
            foreach (char c in chars)
            {
                if (!allowedCharacters.Contains(c.ToString()))
                {
                    return false;
                }
            }

            // If the foreach doesnt return false, it ends and then it returns true here.
            return true;
        }
    }
}