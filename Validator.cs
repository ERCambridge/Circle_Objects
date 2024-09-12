using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Validator
    {
        public double validateNumber()
        {
            double theValue = 0;

            bool isValidNumber = false; 

            // Loop until we get a valid numeric value

            do
            {
                Console.WriteLine("Please enter a circle radius value");

                // Get the input from the user
                string userInput = Console.ReadLine();

                try 
                {
                    theValue = double.Parse(userInput);
                    isValidNumber = true;
                }
                catch (FormatException exceptionBlock)
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message); 
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); 

            
            return theValue;
        }

        public bool validateYN(Circle growCircle)
        {
            bool isThereInput = false;

            string whatUserTyped = "";
            bool getInput = true;

            do
            {
                Console.WriteLine("\nWould you like to grow the circle? (Y/N)?");
                whatUserTyped = Console.ReadLine();

                whatUserTyped = whatUserTyped.ToUpper();

                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false;
                    isThereInput = true;
                    growCircle.Grow();
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false;
                        isThereInput = false;
                    }
                }
            } while (getInput);
            return isThereInput;
        }


    }
}
