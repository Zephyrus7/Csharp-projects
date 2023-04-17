using System;

namespace COMP100.A4
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-7) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        #endregion

        /// <summary>
        /// Write code to produce a table of numbers from 10 to 1, with their squares and cubes. 
        /// You must use a loop and your table must look professional.
        /// </summary>
        private static void Question1()
        {
            Console.WriteLine("Number      Squares     Cubes\n");
            double difference = -1, first = 10, last = 1;

            while (first >= last)
            {
                double cubeCalc = first * first * first;
                double squareCalc = first * first;
                
                Console.WriteLine($"{first,5}{squareCalc,13}{cubeCalc,10}\n");
                first += difference;
            }
        }

        /// <summary>
        /// Write code that displays a conversion table from Fahrenheit to Celsius. It must request
        /// the starting Fahrenheit value, the ending Fahrenheit value, and the increment. 
        /// Thus, instead of the condition checking for a fixed count, the condition checks for 
        /// the ending Fahrenheit value. 
        /// You must use a loop and your table must look professional.
        /// </summary>
        private static void Question2()
        {
            Console.WriteLine("Please provide the starting Fahrenheit value");
            int faBeginVal = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please provide the ending Fahrenheit value");
            int faEndVal = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please provide the increment");
            int incrDecr = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nFahrenheit-----Celsius");
            
            while (faBeginVal <= faEndVal)
            {
                double Celsius = (5.0 / 9)*(faBeginVal - 32);
                
                Console.WriteLine($"{faBeginVal,5} {Celsius,15:f}\n");
                faBeginVal += incrDecr;
            }

        }

        /// <summary>
        /// Write code that calculates and displays the amount of money available in a 
        /// bank account that initially has $1,000 deposited in it and that earns 8 percent 
        /// interest a year. It should display the amount available at the end of each year 
        /// for a period of ten years. Use the relationship that the money available at the
        /// end of each year equals the amount of money in the account at the start of the
        /// year plus .08 times the amount available at the start of the year.
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// Year Balance
        ///  1   $1,080.00
        ///  2   $1,166.40
        ///  3   $1,259.71
        ///  4   $1,360.49
        ///  5   $1,469.33
        ///  6   $1,586.87
        ///  7   $1,713.82
        ///  8   $1,850.93
        ///  9   $1,999.00
        /// 10   $2,158.92
        /// 
        /// </summary>
        private static void Question3()
        {
            Console.WriteLine("Year -- Balance");

            double startVal = 1, endVal = 10, add = 1;
            double interestVal = 0;
            double startBalance = 1000;
            double endBalance = 2158.92;
            
            
            
            while ( startBalance < endBalance || startVal < endVal )
            {
                interestVal = (startBalance * 0.08);
                double currentBalance = startBalance + interestVal;
                
                Console.WriteLine($"{startVal,2} {currentBalance,13:c}\n");
                
                startVal += add;
                startBalance += interestVal;
            }
        }

        /// <summary>
        /// Write code that continuously requests a grade. If the grade is less than 0 or 
        /// greater than 100, your program should print an appropriate message informing the 
        /// user that an invalid grade has been entered, else the grade should be added to a 
        /// total. If the grade is 999, the program should exit the loop and display the sum, 
        /// number of valid grades and the average of the valid grades entered. (You must NOT 
        /// display an invalid message) 
        /// P.S. The value 999 is use to terminate the cycle and should not be used in any of 
        /// the calculation. You must not display an “Invalid grade”
        /// </summary>
        private static void Question4()
        {
            int gradeInput = 0;
            int total = 0;
            
            
            while (true)
            {
                Console.Write("Provide a grade: ");
                gradeInput= Convert.ToInt32(Console.ReadLine());
                
                if (gradeInput > 100 || gradeInput < 0)
                {
                    Console.WriteLine("The grade input is invalid");
                    continue;
                }
                else
                {
                    total = gradeInput + total;
                }
                
                if (total >= 999)
                {
                    break;
                }
            }
            Console.WriteLine($"\nThe grades total= {total}\n");
        }

                /// <summary>
                /// Print the decimal, octal, and hexadecimal values of all characters between the 
                /// start and stop characters entered by a user. For example, if the user enters an 
                /// a and a z, the program should print all the characters between a and z and their 
                /// respective numerical values. Make sure that the second character entered by the 
                /// user occurs later in the alphabet than the first character. If it does not, write 
                /// a loop that repeatedly asks the user for a valid second character until one is 
                /// entered.
                /// 
                /// Your output should be formatted as shown below:
                /// 
                /// Letter   Decimal   Octal   Hex
                ///      a	      97     141	61
                ///      b	      98     142    62
                ///      c        99     143	63
                ///      d       100     144	64
                ///      e	     101     145	65
                ///
                /// </summary>
                private static void Question5()
        {
            Console.Write("Please provide the starting character\n");
            char startInput = Convert.ToChar(Console.ReadLine());
            
            Console.Write("Please provide the ending characher\n");
            char endInput = Convert.ToChar(Console.ReadLine());
            
            int decimalVal = (int)startInput;
            string octa = Convert.ToString(decimalVal, 8);
            string hexadeci = Convert.ToString(decimalVal, 16);
            char progress;
           
            if (startInput > endInput)
            {
                for (; ;)
                {
                    Console.WriteLine("Please provide another (valid) character");
                    endInput = Convert.ToChar(Console.ReadLine());
                    
                    if (startInput < endInput)
                    {
                        break;
                    }
                }
            }
            
            Console.WriteLine("Letter ----- Decimal ---- Octal ---------- Hex\n");
            
            for (progress = startInput; progress <= endInput; progress++)
            {
                decimalVal = (int)progress;
                octa = Convert.ToString(decimalVal, 8);
                hexadeci = Convert.ToString(decimalVal, 16);
                
                Console.WriteLine($"{progress,3} {decimalVal,11} {octa,13} {hexadeci,16}");
            }

        }

        /// <summary>
        /// Write code to compute the (x, y) pairs for the equation below for x in the 
        /// range 1 to 5 in 0.5 increments.
        /// 
        /// Equation: y = 2x² - x - 6 
        /// 
        /// Your output should be formatted as shown below:
        /// 
        /// x	  2x²   -x	   -6    y
        /// 1.0	  2.0	-1.0   -6   -5.0
        /// 1.5	  4.5	-1.5   -6	-3.0
        /// 2.0	  8.0	-2.0   -6	 0.0
        /// 2.5	 12.5	-2.5   -6	 4.0
        ///
        /// </summary>
        private static void Question6()
        {
            ///(N/A)
        }

        /// <summary>
        /// Write code to reverse the digits of a positive integer number. For example, if 
        /// the number 8735 is entered, the number displayed should be 5378. (Hint: Use a do 
        /// statement and continuously strip off and display the units digit of the number. 
        /// If the variable num initially contains the number entered, the units digit is 
        /// obtained as (num % 10). After a units digit is displayed, dividing the number 
        /// by 10 sets up the number for the next iteration. Thus, (8735 % 10) is 5 and 
        /// (8735 / 10) is 873. The do statement should continue as long as the remaining 
        /// number is not zero).
        /// </summary>
        private static void Question7()
        {
            int number;

            Console.Write("\nProvide a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nReversed: ");

            while (number > 0)

            {
                Console.Write(number % 10);
                number = number / 10;                  
            }

        }

    }
}
   
