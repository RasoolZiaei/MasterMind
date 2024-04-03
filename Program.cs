Console.Title = "MASTER MIND";
Console.WriteLine("MASTER MIND");
Console.WriteLine("In this game, a random number is chosen by the computer and you have 10 chances to guess that number." +
    "\nIf your guessed number is correct in terms of value and position, the number will be displayed in green." +
    "\nIf your guessed number is correct only (wrong position), the number will be displayed in yellow." +
    "\nIf your guessed number is wrong, the number will be displayed in red.");
// CODED BY RASOOL ZIAEI \\*// 1403.01.03 \\*// The Practical Project Of The Introductory C# Course Of Sematec School.

while (true)
{
    Console.Write("Easy => Enter 1\nMedium => Enter 2\nHard => Enter 3\nCHOOS GAME LEVEL: ");
    string gameLevel = Console.ReadLine();
    Random random = new Random();
    switch (gameLevel)
    {
        //Easy level
        case "1":
            //select three-digit number by computer
            int ranomNumber = random.Next(100, 1000);
            Console.WriteLine("The computer chose a three-digit number " +
                "and you have 10 chances to guess that number.");
            // convert random number to string
            string numberAsString = ranomNumber.ToString();
            //Create an array with the length of the string
            int[] digits = new int[numberAsString.Length];
            // Placing each value of the numeric string in the array
            for (int i = 0; i < numberAsString.Length; i++)
            {
                digits[i] = int.Parse(numberAsString[i].ToString());
            };
            //Display array members
            //foreach (var item in digits)
            //{
            //    Console.Write(item);
            //}
            //Console.Write("\n");
            //Get user guess numbers
            int counter = 1;
            while (counter <= 10)
            {
                try
                {
                    Console.Write($"Guess number {counter} : ");
                    int guessedNumber = int.Parse(Console.ReadLine());
                    //checking the condition of entering a three-digit integer
                    if (guessedNumber.ToString().Length == 3)
                    {
                        //Create an array with the length of the string
                        int[] digitsOfGuessedNum = new int[3];
                        // Placing each of the string values in the array
                        for (int i = 0; i < 3; i++)
                        {
                            digitsOfGuessedNum[i] = int.Parse(guessedNumber.ToString()[i].ToString());
                        };
                        //Checking and comparing the values of two arrays
                        if (digitsOfGuessedNum[0] == digits[0] && digitsOfGuessedNum[1] == digits[1] && digitsOfGuessedNum[2] == digits[2])
                        {
                            //change color to green  => digitsOfGuessedNum[0,1,2]
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"YOU WON.\nThe Correct Number Is Equal To: {guessedNumber}");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (i == 0)
                                {
                                    if (digitsOfGuessedNum[0] == digits[0])
                                    {
                                        //change color to green  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                    else if (digitsOfGuessedNum[0] == digits[1] || digitsOfGuessedNum[0] == digits[2])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                }
                                else if (i == 1)
                                {
                                    if (digitsOfGuessedNum[1] == digits[1])
                                    {
                                        //change color to green  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                    else if (digitsOfGuessedNum[1] == digits[0] || digitsOfGuessedNum[1] == digits[2])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                }
                                else if (i == 2)
                                {
                                    if (digitsOfGuessedNum[2] == digits[2])
                                    {
                                        //change color to green  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                    else if (digitsOfGuessedNum[2] == digits[0] || digitsOfGuessedNum[2] == digits[1])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                }
                            }
                            if (counter == 10)
                            {
                                //change color to red  => digitsOfGuessedNum[0,1,2]
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"\nYou Lose!\nThe Correct Number Is Equal To: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{ranomNumber}");
                                Console.ReadKey();
                                Console.ResetColor();
                                break;
                            }
                            Console.ResetColor();
                            Console.Write("\n");
                            counter++;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter a three-digit integer number.");
                    Console.ResetColor();
                    break;
                }
            }
            break;
        //Medium level
        case "2":
            //select four-digit number by computer
            int ranomNumber2 = random.Next(1000, 10000);
            //Console.WriteLine(ranomNumber2);
            Console.WriteLine("The computer chose a four-digit number " +
                "and you have 10 chances to guess that number.");
            // convert random number to string
            string numberAsString2 = ranomNumber2.ToString();
            //Create an array with the length of the string
            int[] digits2 = new int[numberAsString2.Length];
            // Placing each value of the numeric string in the array
            for (int i = 0; i < numberAsString2.Length; i++)
            {
                digits2[i] = int.Parse(numberAsString2[i].ToString());
            };
            //Display array members
            //foreach (var item in digits2)
            //{
            //    Console.Write(item);
            //}
            //Console.Write("\n");
            //Get user guess numbers
            int counter2 = 1;
            while (counter2 <= 10)
            {
                try
                {
                    Console.Write($"Guess number {counter2} : ");
                    int guessedNumber = int.Parse(Console.ReadLine());
                    //checking the condition of entering a four-digit integer
                    if (guessedNumber.ToString().Length == 4)
                    {
                        //Create an array with the length of the string
                        int[] digitsOfGuessedNum = new int[guessedNumber.ToString().Length];
                        // Placing each of the string values in the array
                        for (int i = 0; i < guessedNumber.ToString().Length; i++)
                        {
                            digitsOfGuessedNum[i] = int.Parse(guessedNumber.ToString()[i].ToString());
                        };
                        //Checking and comparing the values of two arrays
                        if (digitsOfGuessedNum[0] == digits2[0] && digitsOfGuessedNum[1] == digits2[1] && digitsOfGuessedNum[2] == digits2[2] && digitsOfGuessedNum[3] == digits2[3])
                        {
                            //change color to green  => digitsOfGuessedNum[0,1,2,3]
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"YOU WON.\nThe Correct Number Is Equal To: {guessedNumber}");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (i == 0)
                                {
                                    if (digitsOfGuessedNum[0] == digits2[0])
                                    {
                                        //change color to green  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                    else if (digitsOfGuessedNum[0] == digits2[1] || digitsOfGuessedNum[0] == digits2[2] || digitsOfGuessedNum[0] == digits2[3])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                }
                                else if (i == 1)
                                {
                                    if (digitsOfGuessedNum[1] == digits2[1])
                                    {
                                        //change color to green  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                    else if (digitsOfGuessedNum[1] == digits2[0] || digitsOfGuessedNum[1] == digits2[2] || digitsOfGuessedNum[1] == digits2[3])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                }
                                else if (i == 2)
                                {
                                    if (digitsOfGuessedNum[2] == digits2[2])
                                    {
                                        //change color to green  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                    else if (digitsOfGuessedNum[2] == digits2[0] || digitsOfGuessedNum[2] == digits2[1] || digitsOfGuessedNum[2] == digits2[3])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (digitsOfGuessedNum[3] == digits2[3])
                                    {
                                        //change color to green  => digitsOfGuessedNum[3]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[3]);
                                    }
                                    else if (digitsOfGuessedNum[3] == digits2[0] || digitsOfGuessedNum[3] == digits2[1] || digitsOfGuessedNum[3] == digits2[2])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[3]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[3]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[3]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[3]);
                                    }
                                }
                            }
                            if (counter2 == 10)
                            {
                                //change color to red  => digitsOfGuessedNum[0,1,2,3]
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"\nYou Lose!\nThe Correct Number Is Equal To: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{ranomNumber2}");
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            }
                            Console.ResetColor();
                            Console.Write("\n");
                            counter2++;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter a four-digit integer number.");
                    Console.ResetColor();
                    break;
                }
            }
            break;
        //Hard level
        case "3":
            //select five-digit number by computer
            int ranomNumber3 = random.Next(10000, 100000);
            //Console.WriteLine(ranomNumber3);
            Console.WriteLine("The computer chose a five-digit number " +
                "and you have 10 chances to guess that number.");
            // convert random number to string
            string numberAsString3 = ranomNumber3.ToString();
            //Create an array with the length of the string
            int[] digits3 = new int[numberAsString3.Length];
            // Placing each value of the numeric string in the array
            for (int i = 0; i < numberAsString3.Length; i++)
            {
                digits3[i] = int.Parse(numberAsString3[i].ToString());
            };
            //Display array members
            //foreach (var item in digits3)
            //{
            //    Console.Write(item);
            //}
            //Console.Write("\n");
            //Get user guess numbers
            int counter3 = 1;
            while (counter3 <= 10)
            {
                try
                {
                    Console.Write($"Guess number {counter3} : ");
                    int guessedNumber = int.Parse(Console.ReadLine());
                    //checking the condition of entering a five-digit integer
                    if (guessedNumber.ToString().Length == 5)
                    {
                        //Create an array with the length of the string
                        int[] digitsOfGuessedNum = new int[guessedNumber.ToString().Length];
                        // Placing each of the string values in the array
                        for (int i = 0; i < guessedNumber.ToString().Length; i++)
                        {
                            digitsOfGuessedNum[i] = int.Parse(guessedNumber.ToString()[i].ToString());
                        }
                        //Checking and comparing the values of two arrays
                        if (digitsOfGuessedNum[0] == digits3[0] && digitsOfGuessedNum[1] == digits3[1] && digitsOfGuessedNum[2] == digits3[2] && digitsOfGuessedNum[3] == digits3[3] && digitsOfGuessedNum[4] == digits3[4])
                        {
                            //change color to green  => digitsOfGuessedNum[0,1,2,3,4]
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"YOU WON.\nThe Correct Number Is Equal To: {guessedNumber}");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (i == 0)
                                {
                                    if (digitsOfGuessedNum[0] == digits3[0])
                                    {
                                        //change color to green  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                    else if (digitsOfGuessedNum[0] == digits3[1] || digitsOfGuessedNum[0] == digits3[2] || digitsOfGuessedNum[0] == digits3[3] || digitsOfGuessedNum[0] == digits3[4])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[0]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[0]);
                                    }
                                }
                                else if (i == 1)
                                {
                                    if (digitsOfGuessedNum[1] == digits3[1])
                                    {
                                        //change color to green  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                    else if (digitsOfGuessedNum[1] == digits3[0] || digitsOfGuessedNum[1] == digits3[2] || digitsOfGuessedNum[1] == digits3[3] || digitsOfGuessedNum[1] == digits3[4])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[1]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[1]);
                                    }
                                }
                                else if (i == 2)
                                {
                                    if (digitsOfGuessedNum[2] == digits3[2])
                                    {
                                        //change color to green  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                    else if (digitsOfGuessedNum[2] == digits3[0] || digitsOfGuessedNum[2] == digits3[1] || digitsOfGuessedNum[2] == digits3[3] || digitsOfGuessedNum[2] == digits3[4])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[2]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[2]);
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (digitsOfGuessedNum[3] == digits3[3])
                                    {
                                        //change color to green  => digitsOfGuessedNum[3]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[3]);
                                    }
                                    else if (digitsOfGuessedNum[3] == digits3[0] || digitsOfGuessedNum[3] == digits3[1] || digitsOfGuessedNum[3] == digits3[2] || digitsOfGuessedNum[3] == digits3[4])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[3]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[3]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[3]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[3]);
                                    }
                                }
                                else if (i == 4)
                                {
                                    if (digitsOfGuessedNum[4] == digits3[4])
                                    {
                                        //change color to green  => digitsOfGuessedNum[4]
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(digitsOfGuessedNum[4]);
                                    }
                                    else if (digitsOfGuessedNum[4] == digits3[0] || digitsOfGuessedNum[4] == digits3[1] || digitsOfGuessedNum[4] == digits3[2] || digitsOfGuessedNum[4] == digits3[3])
                                    {
                                        //change color to yellow  => digitsOfGuessedNum[4]
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(digitsOfGuessedNum[4]);
                                    }
                                    else
                                    {
                                        //change color to red  => digitsOfGuessedNum[4]
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(digitsOfGuessedNum[4]);
                                    }
                                }
                            }
                            if (counter3 == 10)
                            {
                                //change color to red  => digitsOfGuessedNum[0,1,2,3,4]
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($"\nYou Lose!\nThe Correct Number Is Equal To: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{ranomNumber3}");
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                            }
                            Console.ResetColor();
                            Console.Write("\n");
                            counter3++;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter a five-digit integer number.");
                    Console.ResetColor();
                    break;
                }
            }
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the value correctly!");
            Console.ResetColor();
            break;
    }
    Console.Write("\nPlay again?\nTo play again type 'y' and press ENTER or to exit press other kyes: ");
    string playAgain = Console.ReadLine();
    if (playAgain == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}