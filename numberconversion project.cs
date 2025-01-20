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

        static int binaryToDenary(string num)
        {

            int denaryNum = 0;
            for(int i = 0; i<8; i++)
            {

                if (num[8-(i+1)].ToString() == "1")
                {

                    denaryNum = denaryNum + 2 >> i;

                }

            }

            return denaryNum;

        }
        static string denaryToBinary(int num)
        {

            denaryNumberValidation(num);
            int currentNum = num;
            string binaryNum = "";
            for (int i = 7; i != 0; i--)
            {

                int test = currentNum - (2 >> i);
                if (test >= 0)
                {
                    currentNum = test;
                    binaryNum = binaryNum + "1";

                }

                else
                {

                    binaryNum = binaryNum + "0";

                }

            }

           return binaryNum;


        }

        static string binaryToHexadecimal(string num)
        {

            binaryNumberValidation(num);
            string digit1 = num[0] + num[1] + num[2] + num[3].ToString();
            string digit2 = num[4] + num[5] + num[6] + num[7].ToString();
            hexadecimalDigitConverter(digit1);
            hexadecimalDigitConverter(digit2);
            string hexadecimalValue = digit1 + digit2;
            return hexadecimalValue;

        }

        static void hexadecimalToBinary(string num)
        {

            hexadecimalValidation(num);
            
            string digit1 = "";
            string digit2 = "";
            string nibble1 = "";
            string nibble2 = "";
            string binaryValue = "";
            
            digit1 = num[0].ToString();
            digit2 = num[1].ToString();

            nibble1 = hexDigitToBinary(digit1);
            nibble2 = hexDigitToBinary(digit2);

            binaryValue = nibble1 + nibble2;


        }
        static string denaryToHexadecimal(int num)
        {

            string binaryNum = "";
            string hexValue = "";
            
            binaryNum = denaryToBinary(num);
            hexValue = binaryToHexadecimal(binaryNum);

            return hexValue;


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

        static string binaryNumberValidation(string num)
        {

            bool validInput = false;
            while (validInput == false)
            {

                int lengthCheck = num.Length;
                if (lengthCheck != 8)
                {

                    Console.WriteLine("binary number not of appropriate length, try again: ");
                    num = Console.ReadLine();

                }
                else
                {

                    for (int i = 0; i < lengthCheck; i++)
                    {

                        if (num[i].ToString() != "0") 
                        {

                            if (num[i].ToString() != "1")
                            {
                                
                                Console.WriteLine("binary number needs to be only 1s and 0s, try again: ");
                                num = Console.ReadLine();
                                break;

                            }

                        }
                        

                    }
                    validInput = true;
                }

            }
            return num;



        }

        static string hexadecimalDigitConverter(string num)
        {

            string hexadecimalDigit = "";
            int denaryNum = 0;
            for (int i = 0; i < 4; i++)
            {

                if (num[4 - (i + 1)].ToString() == "1")
                {

                    denaryNum = denaryNum + 2 >> i;

                }

            }

            if (denaryNum <= 9)
            {

                hexadecimalDigit = denaryNum.ToString();

            }
            else
            {

                switch (denaryNum)
                {

                    case  10:
                        hexadecimalDigit = "A";
                        break;

                    case  11:
                        hexadecimalDigit = "B";
                        break;

                    case 12:
                        hexadecimalDigit = "C";
                        break;

                    case 13:
                        hexadecimalDigit = "D";
                        break;

                    case 14:
                        hexadecimalDigit = "E";
                        break;

                    default:
                        hexadecimalDigit = "F";
                        break;

                }

            }

            return hexadecimalDigit;

        }

        static string hexDigitToBinary(string hexDigit)
        {

            string binaryNum = "";
            switch (hexDigit)
            {
                case "0":
                    binaryNum = "0000";
                    break;

                case "1":
                    binaryNum = "0001";
                    break;

                case "2":
                    binaryNum = "0010";
                    break;

                case "3":
                    binaryNum = "0011";
                    break;

                case "4":
                    binaryNum = "0100";
                    break;

                case "5":
                    binaryNum = "0101";
                    break;

                case "6":
                    binaryNum = "0110";
                    break;

                case "7":
                    binaryNum = "0111";
                    break;

                case "8":
                    binaryNum = "1000";
                    break;

                case "9":
                    binaryNum = "1001";
                    break;
                    
                case "A":
                    binaryNum = "1010";
                    break;

                case "B":
                    binaryNum = "1011";
                    break;

                case "C":
                    binaryNum = "1100";
                    break;

                case "D":
                    binaryNum = "1101";
                    break;

                case "E":
                    binaryNum = "1110";
                    break;

                default:
                    binaryNum = "1111";
                    break;


            }

            return binaryNum;

        }

        static string hexadecimalValidation(string hexdigit)
        {

            bool validInput = false;


            while(validInput == false)
            {
                for(int i = 0; i < hexdigit.Length; i++)
                {
                    if (hexdigit.Length != 2)
                    {

                        Console.WriteLine("Hexademcimal value is of inappropriate length, try again: ");
                        hexdigit = Console.ReadLine();

                    }
                    else if (hexdigit[i].ToString() != "1")
                    {

                        if (hexdigit[i].ToString() != "2")
                        {

                            if (hexdigit[i].ToString() != "3")
                            {

                                if (hexdigit[i].ToString() != "4")
                                {

                                    if (hexdigit[i].ToString() != "5")
                                    {

                                        if (hexdigit[i].ToString() != "6")
                                        {

                                            if (hexdigit[i].ToString() != "7")
                                            {

                                                if (hexdigit[i].ToString() != "8")
                                                {

                                                    if (hexdigit[i].ToString() != "9")
                                                    {

                                                        if (hexdigit[i].ToString() != "A")
                                                        {

                                                            if (hexdigit[i].ToString() != "B")
                                                            {

                                                                if (hexdigit[i].ToString() != "C")
                                                                {

                                                                    if (hexdigit[i].ToString() != "D")
                                                                    {

                                                                        if (hexdigit[i].ToString() != "E")
                                                                        {

                                                                            if (hexdigit[i].ToString() != "F")
                                                                            {

                                                                                Console.WriteLine("Input doesn't have a required digit, try again: ");
                                                                                hexdigit = Console.ReadLine();

                                                                            }

                                                                        }

                                                                    }

                                                                }

                                                            }

                                                        }

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }

                            }

                        }


                    }

                    else
                    {

                        validInput = true;

                    }

                }

            }

            return hexdigit;

        }
            
            


    }
}
