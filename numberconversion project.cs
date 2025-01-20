using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversion_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //presents all the number conversions possible and asks the user which one they would like to perform
            Console.WriteLine("Which Conversion would you like: ");
            
            Console.WriteLine("A) 8-bit binary number to a denary value");
            
            Console.WriteLine("B) Denary value (0 to 255) into a binary number");
            
            Console.WriteLine("C) 8 bit binary number to a hexadecimal value");
            
            Console.WriteLine("D) Two digit hexadecimal value to binary");

            Console.WriteLine("E) Denary value (0 to 255) into Hexadecimal");

            Console.WriteLine("F) Two digit hexadecimal value to denary");

            Console.WriteLine("G) Binary addition between two binary numbers");
            string conversionChoice = Console.ReadLine(); // accepts a user input for their conversion of choice

            bool validInput = false;
            while (validInput == false)
            {

                if (conversionChoice == "A")
                {
                    validInput = true;
                }

                else if (conversionChoice == "B")
                {
                    validInput = true;
                }

                else if (conversionChoice == "C")
                {
                    validInput = true;
                }

                else if (conversionChoice == "D")
                {
                    validInput = true;
                }

                else if (conversionChoice == "E")
                {
                    validInput = true;
                }

                else if (conversionChoice == "F")
                {
                    validInput = true;
                }

                else if (conversionChoice == "G")
                {
                    validInput = true;
                }

                else
                {
                    Console.WriteLine("Invalid input, input must be a letter from A-G (case sensitive), Re-enter choice: ");
                    conversionChoice = Console.ReadLine();
                }
                
                

            }

                //create a form of selection to check the option they have input and provide a necessary result for the conversion type they want, with the input variable having the convention of the option, then the type of number input
                switch (conversionChoice)
            {

                case "A":
                    Console.WriteLine("Enter your binary number: ");
                    string aBinaryNumber = Console.ReadLine();
                    binaryToDenary(aBinaryNumber);
                    break;

                case "B":
                    Console.WriteLine("Enter your denary value: ");
                    int bDenaryNumber = int.Parse(Console.ReadLine()); //converts the input from a string to an integer
                    denaryToBinary(bDenaryNumber);
                    break;

                case "C":
                    Console.WriteLine("Enter your binary number: ");
                    string cBinaryNumber = Console.ReadLine();
                    binaryToHexadecimal(cBinaryNumber);
                    break;

                case "D":
                    Console.WriteLine("Enter your hexadecimal value: ");
                    string dHexNumber = Console.ReadLine();
                    hexadecimalToBinary(dHexNumber);
                    break;

                case "E":
                    Console.WriteLine("Enter your denary value: ");
                    int eDenaryNumber = int.Parse(Console.ReadLine());
                    denaryToHexadecimal(eDenaryNumber);
                    break;

                case "F":
                    Console.WriteLine("Enter your hexadecimal value: ");
                    string fHexNumber = Console.ReadLine();
                    hexadimalToDenary(fHexNumber); 
                    break;

                default:
                    Console.WriteLine("Enter your first binary number: "); //Takes 2 user inputs as two are required for binary addition to take place
                    string gBinaryNumber1 = Console.ReadLine(); 
                    Console.WriteLine("Enter your second binary number: ");
                    string gBinaryNumber2 = Console.ReadLine();
                    binaryAddition(gBinaryNumber1, gBinaryNumber2);
                    break;


            }


        }

        static void binaryToDenary(string num)
        {



        }
        static void denaryToBinary(int num)
        {

            string binaryNum = "";
            denaryNumberValidation(num);
            for (int i = 8; i != 0; i--)
            {

                if()

            }


        }

        static void binaryToHexadecimal(string num)
        {



        }

        static void hexadecimalToBinary(string num)
        {



        }
        static void denaryToHexadecimal(int num)
        {



        }
        static void hexadimalToDenary(string num)
        {



        }
        static void binaryAddition(string num1, string num2)
        {



        }

        static int denaryNumberValidation(int num)
        {

            bool validNumber = false;
            while (validNumber == false)
            {

                if (num < 0)
                {
                    Console.WriteLine("Number too small,has to be a number between 0 to 255, re-enter choice: ");
                    num = int.Parse(Console.ReadLine());
                }
                else if (num > 0)
                {
                    Console.WriteLine("Number too big,has to be a number between 0 to 255, re-enter choice: ");
                    num = int.Parse(Console.ReadLine());
                }
                else
                {
                    validNumber = true;
                }
            }

            return num;

        }

        

    }
}
