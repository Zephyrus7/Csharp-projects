using System;

namespace Assignment3
{
    class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-10) for the question to run or 0 to exit: ");
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
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
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
        /// Write code that prompts the user for a menu choice.
        /// The program will display a message based on the following:
        ///   Choice            Message
        ///   1                 "Calculate area"
        ///   2                 "Calculate volume"
        ///   3                 "Calculate surface area"
        ///   4                 "Exit the program"
        ///   any other input   "ERROR: Invalid choice"
        /// </summary>
        
        ///H.A.E

        ///WARNING! .NET 5.0 Runtime needs to be installed to run this program!
        public static void Question1()
        {

            string userInput;

            Console.WriteLine("1                 Calculate Area\n");
            Console.WriteLine("2                 Calculate Volume\n");
            Console.WriteLine("3                 Calculate surface area\n");
            Console.WriteLine("4                 Exit the program\n");

            Console.WriteLine("Choose an option by typing the number of the selected choice");

            userInput = Console.ReadLine();

            if (userInput.ToString() != "1" && userInput.ToString() != "2" && userInput.ToString() != "3" && userInput.ToString() != "4")

                Console.WriteLine("ERROR: Invalid Choice");

            else
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("You have selected 'Calculate Area'");
                        break;

                    case "2":

                        Console.WriteLine("You have selected 'Calculate Volume'");
                        break;

                    case "3":

                        Console.WriteLine("You have selected 'Calculate surface area'");
                        break;

                    case "4":

                        Console.WriteLine("You have selected 'Exit the program'");
                        break;

                }


        }

        /// <summary>
        /// Write code that allows the user to enter two integers and a character.
        /// If the character is 'A', then add the two integers.
        /// If the character is 'S', then subtract the second integer from the first.
        /// Otherwise, multiply the integers.
        /// Display the results of the arithmetic.
        /// </summary>
        public static void Question2()
        {
            
            Console.WriteLine("Provide integer 1 "); 
            int userInputInt1 = Convert.ToInt32(Console.ReadLine()); 


            Console.WriteLine("Provide integer 2 "); 
            int userInputInt2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide a character");
            string userInputChar = Console.ReadLine();


            if (userInputChar.ToString() != "A" && userInputChar.ToString() != "S")
            {
                int multiply = userInputInt1 * userInputInt2;
                Console.WriteLine("The multiplication of provided numbers is " + multiply);
            }

            switch(userInputChar)                
                
                {
                case "A":
                    int sum = userInputInt1 + userInputInt2;
                    Console.WriteLine("The sum of the provided numbers is " + sum);
                    break;

                case "S":
                    int subtraction = userInputInt2 - userInputInt1;
                    Console.WriteLine("The subtraction of the provided numbers is " + subtraction);
                    break;

            }






        }

        /// <summary>
        /// Write code that prompts the user for the number of courses and residency status
        /// (domestic or international) and calculates tuition cost. Cost is calculated based on the
        /// following:
        ///     Domestic        $325 per course
        ///     International   $1375 per course
        /// You decide how you want the user to enter their residency status and prompt accordingly.
        /// You must use named constants for the cost per course
        /// Display the total cost.
        /// </summary>
        public static void Question3()
        {
            const int domestic = 325;
            const int international = 1375;

            Console.WriteLine("Type domestic or international to choose:");
            var userInput = Console.ReadLine();

            Console.WriteLine("Enter number of courses to be taken:");
            var courseInput = Console.ReadLine();

            switch (userInput)
            {
                
                case "international":
                    int internationalTotal = international * int.Parse(courseInput);
                    
                    Console.WriteLine("Your total is: $" + internationalTotal);
                    break;

                case "domestic":
                    int domesticTotal = domestic * int.Parse(courseInput);
                    
                    Console.WriteLine("Your total is: $" + domesticTotal);
                    break;
            }





        }

        /// <summary>
        /// Write code that prompts the user for a day of the week. The program will display a 
        /// message based on the following:
        ///     Choice      Message
        ///     Sun         Home
        ///     Mon         Work
        ///     Tue         Work
        ///     Wed         Home
        ///     Thu         Work
        ///     Fri         Work
        ///     Sat         Work
        /// </summary>
        public static void Question4()
        {
            string userInput;

            Console.WriteLine("Provide a day of the week to display the message\n");
            Console.WriteLine("You can either type 'Sun-Mon-Tue-Wed-Thu-Fri-Sat");
            userInput = Console.ReadLine();


            switch (userInput)
            {
                case "Sun":

                    Console.WriteLine("Home");
                    break;

                case "Mon":

                    Console.WriteLine("Work");
                    break;

                case "Tue":

                    Console.WriteLine("Work");
                    break;

                case "Wed":

                    Console.WriteLine("Home");
                    break;

                case "Thu":

                    Console.WriteLine("Work");
                    break;

                case "Fri":

                    Console.WriteLine("Work");
                    break;

                case "Sat":

                    Console.WriteLine("Work");
                    break;




            }



        }



        /// <summary>
        /// Write code for a furniture company. Ask the user to choose Pine, Oak or Mahogany.
        /// Show the price of a table manufactured with the choosen wood. Pine tables cost $100, 
        /// Oak tables cost $125, and Mahogany tables cost $310. You must use named constants and
        /// a switch statement. You must accept any variation on the case (Eg. Pine, pine, PINE, piNe, etc
        /// </summary>
        public static void Question5()
        {
            const int PINE = 100;
            const int OAK = 125;
            const int MAHOGANY = 310;

            Console.WriteLine("Enter your table material selection to choose Pine, Oak or Mahogany");
            var userInput = Console.ReadLine();

            string userInputUpper = userInput.ToUpper();

            switch (userInputUpper)
            {

                case "PINE":

                    Console.WriteLine("You have chosen Pine and your total is $" + PINE);
                    break;

                case "OAK":
               
                    Console.WriteLine("You have chosen Oak and your total is $" + OAK);
                    break;

                case "MAHOGANY":

                    Console.WriteLine("You have chosen Mahogany and you total is" + MAHOGANY);
                    break;
            }
        }

        /// <summary>
        /// Write code that prompts the user for an hourly pay rate. If the value entered is less than
        /// $5.65, display an error message
        /// </summary>
        public static void Question6()
        {
            Console.WriteLine("Please enter an hourly pay rate above or equal to $5.65");
            string userInput = Console.ReadLine();
            decimal userInputDecimal = Convert.ToDecimal(userInput);
            
            Decimal minWage = 5.65m;
            Decimal number2 = userInputDecimal;

            if (userInputDecimal < minWage) 
            {
                Console.WriteLine("ERROR: Provided hourly pay rate can't be lower than $5.65");
               
            }

            if (userInputDecimal >= minWage)
            {
                Console.WriteLine("Provided hourly pay rate is $" + userInputDecimal);
            }

        }

        /// <summary>
        /// Write code that prompt a user for an hourly pay rate. If the user enters a value less than
        /// $5.65 or greater than $49.99, prompt the user again. If the user enters an invalid value again,
        /// display an appropriate error message. If the user enters a valid value on either the first or
        /// second attempt, display the pay rate as well as the weekly rate which is calculated as 40 times 
        /// the hourly rate. 
        /// </summary>
        public static void Question7()
        {
            Console.WriteLine("Please enter an hourly pay rate in between $5.65 and $49.99");
            string userInput = Console.ReadLine();
            decimal userInputDecimal = Convert.ToDecimal(userInput);

            Decimal minWage = 5.65m;
            Decimal maxWage = 49.99m;
            Decimal number3 = userInputDecimal;

            //If user provides below limit
            
            if (userInputDecimal < minWage)
            {
                Console.WriteLine("ERROR: Provided hourly pay rate can't be lower than $5.65.");
                Console.WriteLine("Please provide an hourly pay in between $5.65 and $49.99.");
                
                string userPrompt2a = Console.ReadLine();
                decimal userPrompt2Decimal1 = Convert.ToDecimal(userPrompt2a);

                if(userPrompt2Decimal1 < minWage)
                {
                    Console.WriteLine("ERROR: An appropiate value hasn't been provided");
                }


                if (userPrompt2Decimal1 > maxWage)
                {
                    Console.WriteLine("ERROR: An appropiate value hasn't been provided");
                }

                if (userPrompt2Decimal1 <= maxWage)
                {
                    Console.WriteLine("You have entered $"+ userPrompt2Decimal1);
                }

                if (userPrompt2Decimal1 >= minWage)
                {
                    Console.WriteLine("You have entered $" + userPrompt2Decimal1);

                }






            }

            //If user provides above limit
           
            if (userInputDecimal > maxWage)
            {

                Console.WriteLine("ERROR: Provided hourly pay rate can't be higher than $49.99");
                Console.WriteLine("Please provide an hourly pay rate in between $5.65 and $49.99");

                string userPrompt2b = Console.ReadLine();
                decimal userPrompt2Decimal2 = Convert.ToDecimal(userPrompt2b);

                if (userPrompt2Decimal2 < minWage)
                {
                    Console.WriteLine("ERROR: An appropiate value hasn't been provided");
                }

                if (userPrompt2Decimal2 > maxWage)
                {
                    Console.WriteLine("ERROR: An appropiate value hasn't been provided");
                }

                if (userPrompt2Decimal2 <= maxWage)
                {
                    Console.WriteLine("You have entered $" + userPrompt2Decimal2);
                }

                if (userPrompt2Decimal2 >= minWage)
                {
                    Console.WriteLine("You have entered $" + userPrompt2Decimal2);
                }

            }  
                
                
                //If user provides correct value
                
                if (userInputDecimal <= maxWage)
                {
                    if (userInputDecimal >= minWage)
                    {
                        Console.WriteLine("You have entered $" + userInputDecimal);
                        decimal weeklyPay = userInputDecimal * 40;
                        Console.WriteLine("Weekly pay rate is $" + weeklyPay);
                    }
                }

                
            
            
        
        
        }

        /// <summary>
        /// Write a program for a college's admissions office. The user enters a numeric high school grade
        /// point average (ex. 3.2) and an admission test score. Print the message "Accept" if the student
        /// meets either of the following requirements:
        ///     A grade point average of 3.0 or higher and an admission test score of at least 60
        ///     A grade point average of less than 3.0 and an admission test score of at least 80
        /// If the student does not meet either of the qualification criteria, print "Reject"
        /// </summary>
        public static void Question8()
        {
            Console.WriteLine("Please enter your high school GPA ");
            string inputAverage = Console.ReadLine();
            double inputAverageDouble = Convert.ToDouble(inputAverage);

            Console.WriteLine("Please enter your admission test score");
            string inputAdmission = Console.ReadLine();
            int inputAdmissionInt = Convert.ToInt32(inputAdmission);

            if (inputAdmissionInt <= 80)
            {
                if(inputAverageDouble < 3.0)
                {
                    Console.WriteLine("Reject");
                }
            
                
                if(inputAdmissionInt >= 60)
                {
                    if (inputAverageDouble >= 3.0)
                    {
                        Console.WriteLine("Accept");
                    }
                }
                


            
            }

            if(inputAdmissionInt >= 80)
            {
                if (inputAverageDouble < 3.0)
                {
                    Console.WriteLine("Accept");
                }

                if (inputAverageDouble >= 3.0)
                {
                    Console.WriteLine("Accept");
                }

            }

        }

        /// <summary>
        /// Write code that prompts the user for an hourly pay rate and hours worked. Compute gross pay
        /// (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax).
        /// Withholding tax is computed as a percentage of gross pay based on the following:
        ///     Gross pay                       Withholding Percentage
        ///     Up to an including 300.00       10%
        ///     300.01 and up                   12%
        /// </summary>
        public static void Question9()
        {
            Console.WriteLine("Please enter hourly pay rate");
            double inputHourly = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter hours worked");
            double inputWorked = Convert.ToDouble(Console.ReadLine());

            double totalWorkCheck = inputHourly * inputWorked;

            if (totalWorkCheck <= 300)
            {
                double percent10 = (totalWorkCheck / 100) * 10;
                double netPay10 = totalWorkCheck - percent10;
                Console.WriteLine("Tax is $" + percent10 + " and net pay is $" + netPay10);
            }

            if (totalWorkCheck >= 300.01)
            {
                double percent12 = (totalWorkCheck / 100) * 12;
                double netPay12 = totalWorkCheck - percent12;
                Console.WriteLine("Tax is $" + percent12 + " and net pay is $" + netPay12);

            }
        }

        /// <summary>
        /// Write code for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly fee
        /// for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more,
        /// but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is 
        /// $50 per week. Prompt the user for the length and width of a lawn, and then print the weekly
        /// mowing fee, as well as the total fee for the 20-week season.
        /// </summary>
        public static void Question10()
        {
            Console.WriteLine("Please enter width of the lawn");
            double inputWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter length of the lawn");
            double inputLength = Convert.ToDouble(Console.ReadLine());

            double lawnArea = inputWidth * inputLength;

            int lawnAreaInt = Convert.ToInt32(lawnArea);



            if (lawnArea < 400)
            {
                Console.WriteLine("Weekly fee is $25 and 20-week fee is $500");
            }

            if (lawnArea >= 400)
            {

                if (lawnArea < 600)
                {
                    Console.WriteLine("Weekly fee is $35 and 20-week fee is $700");
                }

                if(lawnArea >= 600)
                {
                    Console.WriteLine("Weekly fee is $50 and 20-week fee is $1000");
                }


            }

            

        }
    }
}
