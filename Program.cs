using System;

class MasterMind
{
    static void Main(string[] args)
    {
        Console.Title = "MASTER MIND";
        do
        {
            Console.Clear(); // Clears the console screen

            Console.WriteLine("Welcome to MASTER MIND!");
            Console.WriteLine("Select the difficulty level: ");
            Console.WriteLine("1. Easy (3-digit code, 10 attempts)");
            Console.WriteLine("2. Normal (4-digit code, 10 attempts)");
            Console.WriteLine("3. Hard (5-digit code, 10 attempts)");

            int difficultyLevel = GetDifficultyLevel(); // فراخوانی متد تعیین سطح بازی که خروجی آن عددی بین 1 تا 3 است

            int codeLength;
            switch (difficultyLevel)
            {
                case 1:
                    codeLength = 3;
                    break;
                case 2:
                    codeLength = 4;
                    break;
                case 3:
                    codeLength = 5;
                    break;
                default: //به هر دلیلی که سطح بازی به سوئیچ پاس نشود، مقدار دیفالت اجرا می شود
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid input, defaulting to Normal.");
                    Console.ResetColor();
                    codeLength = 4;
                    break;
            }

            int[] secretCode = GenerateSecretCode(codeLength); //فراخوانی متد تولید یک عدد صحیح تصادفی و ریختن آن در آرایه
            Console.WriteLine($"I have generated a {codeLength}-digit code. You have 10 attempts to guess it.");

            bool guessedCorrectly = false;
            for (int attempt = 1; attempt <= 10; attempt++) // دریافت اعداد حدسی کاربر تا سقف 10 شانس
            {
                Console.WriteLine($"Attempt {attempt} of 10:");
                int[] guess = GetGuess(codeLength);

                if (CheckGuess(secretCode, guess)) //فراخوانی متد مقایسه کلی عدد دریافتی از کاربر با عدد تصادفی سیستم
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! You've guessed the code!");
                    Console.ResetColor();
                    guessedCorrectly = true;
                    break;
                }
                else
                {
                    ShowColoredFeedback(secretCode, guess);// فراخوانی متد مقایسه جزء به جرء عدد دریافتی از کاربر با عدد تصادفی سیستم
                }
            }

            if (!guessedCorrectly)//در صورتی که کاربر بعد از 10 شانس نتواند عدد را عدس بزند، این شرط اجرا می شود
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've used all your attempts. The secret code was: {string.Join("", secretCode)}");
                Console.ResetColor();
            }

            Console.WriteLine("Do you want to play again? (y/n)");
        } while (Console.ReadKey(true).Key == ConsoleKey.Y);

        Console.WriteLine("Thank you for playing MASTER MIND. Goodbye!");
        Console.ReadKey();
    }

    static int GetDifficultyLevel() // تعیین سطح بازی. اطمینان از اینکه کاربر فقط و فقط عدد صحیح
                                    // بین 1 تا 3 وارد میکند و همان عدد به متغیر پاس دادی می شود
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int level) && level >= 1 && level <= 3)
            {
                return level;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid input! Please enter a valid difficulty level (1 to 3): ");
                Console.ResetColor();
            }
        }
    }

    static int[] GenerateSecretCode(int length) //تولید یک عدد صحیح تصادفی با طول دلخواه و ریختن آن در یک آرایه از جنس عدد صحیح.
                                                //نکته مهم اینکه مطمئن هستیم عدد اول آرایه هیچگاه صفر نیست
    {
        Random random = new Random();
        int[] code = new int[length];

        // Ensure the first digit is not zero
        code[0] = random.Next(1, 10);  // Generates a random digit between 1 and 9 for the first digit

        // Generate the rest of the digits, which can include zero
        for (int i = 1; i < length; i++)
        {
            code[i] = random.Next(0, 10); // Generates a random digit between 0 and 9
        }
        return code;
    }


    static int[] GetGuess(int length) //دریافت عدد حدسی کاربر
    {
        while (true)
        {
            Console.Write($"Enter a {length}-digit guess: ");
            string input = Console.ReadLine();

            if (input.Length == length && int.TryParse(input, out int test))//بررسی اینکه کاربر فقط عدد صحیح با طول مورد نظر وارد میکند
            {
                int[] guess = new int[length];
                for (int i = 0; i < length; i++) // ریختن عدد دریافتی از کاربر در آرایه
                {
                    guess[i] = int.Parse(input[i].ToString());
                }
                return guess;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Invalid input! Please enter exactly {length} digits.");
                Console.ResetColor();
            }
        }
    }

    static bool CheckGuess(int[] secretCode, int[] guess)// مقایسه کلی عدد دریافتی از کاربر با عدد تصادفی سیستم
    {
        for (int i = 0; i < secretCode.Length; i++)
        {
            if (secretCode[i] != guess[i])
            {
                return false;
            }
        }
        return true;
    }

    static void ShowColoredFeedback(int[] secretCode, int[] guess) //مقایسه جزء به جرء عدد دریافتی از کاربر با عدد تصادفی سیستم.
    {
        Console.Write("Feedback: ");
        for (int i = 0; i < secretCode.Length; i++)
        {
            if (guess[i] == secretCode[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(guess[i]);
                Console.ResetColor();
            }
            else if (Array.IndexOf(secretCode, guess[i]) != -1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(guess[i]);
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(guess[i]);
                Console.ResetColor();
            }
        }
        Console.WriteLine(); // Adds a new line to separate feedback from other outputs
    }
}
