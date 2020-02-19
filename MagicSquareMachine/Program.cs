using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquareMachine
{
    class Program
    {
        public static void printDirections()
        {
            Console.WriteLine("Welcome to the Magic Square Machine!\n");
            Console.WriteLine("A magic square is a grid of numbers in which all of the rows, columns, and diagnols equal the same number.\n");
            Console.WriteLine("In a moment, you will be prompted to enter 9 integers (numbers 0 through 9)\n");
            Console.WriteLine("The numbers will be displayed for you as you go.\n");
            Console.WriteLine("Once all of the numbers are entered, the program will tell you whether or not a magic square has formed.\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static int getInt()
        {
            int n1 = 0;
            String input = "";
            Console.WriteLine("Please enter an integer: \n");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }
        public static void printBoard(int r1c1, int r1c2, int r1c3, int r2c1, int r2c2, int r2c3, int r3c1, int r3c2, int r3c3)
        {
            Console.WriteLine("|  " + r1c1 + "  |  " + r1c2 + "  |  " + r1c3 + "  |");
            Console.WriteLine("|  " + r2c1 + "  |  " + r2c2 + "  |  " + r2c3 + "  |");
            Console.WriteLine("|  " + r3c1 + "  |  " + r3c2 + "  |  " + r3c3 + "  |");
        }
        public static bool checkSquare(int firstNum, int secondNum, int thirdNum, int fourthNum, int fifthNum, int sixthNum, int seventhNum, int eighthNum, int ninthNum)
        {
            int row1 = 0;
            int row2 = 0;
            int row3 = 0;
            int col1 = 0;
            int col2 = 0;
            int col3 = 0;
            int diag1 = 0;
            int diag2 = 0;

            row1 = firstNum + secondNum + thirdNum;
            row2 = fourthNum + fifthNum + sixthNum;
            row3 = seventhNum + eighthNum + ninthNum;
            col1 = firstNum + fourthNum + seventhNum;
            col2 = secondNum + fifthNum + eighthNum;
            col3 = thirdNum + sixthNum + ninthNum;
            diag1 = firstNum + fifthNum + ninthNum;
            diag2 = thirdNum + fifthNum + seventhNum;

            if ((row1 == row2) && (row2 == row3) && (row3 == col1) && (col1 == col2) && (col2 == col3) && (col3 == diag1) && (diag1 == diag2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void printResults(int topLeft, int topMiddle, int topRight, int middleLeft, int middleCenter, int middleRight, int bottomLeft,
                                        int bottomMiddle, int bottomRight, bool result)
        {
            Console.Clear();
            Console.WriteLine("Using the numbers you entered, here is your grid");
            Console.WriteLine("|  " + topLeft + "  |  " + topMiddle + "  |  " + topRight + "|  ");
            Console.WriteLine("|  " + middleLeft + "  |  " + middleCenter + "  |  " + middleRight + "|  ");
            Console.WriteLine("|  " + bottomLeft + "  |  " + bottomMiddle + "  |  " + bottomRight + "|  ");
            Console.ReadLine();

            if (result == true)
            {
                Console.Clear();
                Console.WriteLine("The numbers that you have entered form a magic square!");
            }
            else if (result == false)
            {
                Console.Clear();
                Console.WriteLine("The numbers that you have entered don't form a magic square.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The numbers that you have entered don't form a magic square.");
            }
            Console.ReadLine();
        }
        public static void magicSquareV1()
        {
            int input1 = 0;
            int input2 = 0;
            int input3 = 0;
            int input4 = 0;
            int input5 = 0;
            int input6 = 0;
            int input7 = 0;
            int input8 = 0;
            int input9 = 0;
            bool resultOfSquare = false;

            printDirections();

            input1 = getInt();

            while( (input1 < 1) || (input1 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input1 = getInt();
            }
            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input2 = getInt();

            while ((input2 < 1) || (input2 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input2 = getInt();
            }
            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input3 = getInt();

            while ((input3 < 1) || (input3 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input3 = getInt();
            }

            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input4 = getInt();

            while ((input4 < 1) || (input4 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input4 = getInt();
            }

            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input5 = getInt();

            while ((input5 < 1) || (input5 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input5 = getInt();
            }

            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input6 = getInt();

            while ((input6 < 1) || (input6 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input6 = getInt();
            }

            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input7 = getInt();

            while ((input7 < 1) || (input7 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input7 = getInt();
            }

            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input8 = getInt();

            while ((input8 < 1) || (input8 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input8 = getInt();
            }

            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);

            input9 = getInt();

            while ((input9 < 1) || (input9 > 9))
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, you entered an invalid number.\n");
                Console.WriteLine("Please try again, and remember to enter a number between 1 and 9.\n");
                input9 = getInt();
            }
            printBoard(input1, input2, input3, input4, input5, input6, input7, input8, input9);
            resultOfSquare = checkSquare(input1, input2, input3, input4, input5, input6, input7, input8, input9);
            printResults(input1, input2, input3, input4, input5, input6, input7, input8, input9, resultOfSquare);
        }
        static void Main(string[] args)
        {
            magicSquareV1();
        }
    }
}