namespace CSharpIntroExercises;

class Program
{
    static void Main(string[] args)
    {
        
        /*Question4();
        Question5();
        Question6();
        Question7();
        
        
        Question11();
        Question12();
        Question13();
        */
        Question14();

    }

    private static void Question4()
    {
        //4.	Check if a number is prime.
        Console.WriteLine("Enter a number to check if it is prime:");
        int possiblePrime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The number {possiblePrime} is prime: {CheckPrimeNumber(possiblePrime)}");
    }

    private static void Question5()
    {
        //5.	Check if a word is plural - simple check
        Console.WriteLine("Enter a word to check if it is plural");
        string word = Console.ReadLine();
        string plurality = word.EndsWith('s') ? "plural" : "singular";
        Console.WriteLine($"word is {plurality}");
    }

    private static void Question6()
    {
        //6.	Reverse a String: Reverse the characters in a given string.
        //Check if the string is a palindrome. (same backwards as forwards)
        Console.WriteLine("Enter a word to check if it is a palindrome");
        String possiblePalindrome = Console.ReadLine();
        String reversed = ReverseWord(possiblePalindrome);
        bool isPalindrome = possiblePalindrome.Equals(reversed);
        Console.WriteLine($"{possiblePalindrome} reversed is {reversed}; Palindrome: {isPalindrome}");
    }

    private static void Question7()
    {
        //7.	Check if a work is an isogram (contains no duplicated letters)
        Console.WriteLine("Enter a word to check if it's an isogram (no duplicated letters.)");
        string possibleIsogram = Console.ReadLine();
        string isAnIsogram = CheckIsogram(possibleIsogram) ? "is" : "isn't";
        Console.WriteLine($"{possibleIsogram} {isAnIsogram} an isogram.");
    }
    //TODO: Add 8, 9, 10

    private static void Question11()
    {
        //11.	€1000 is deposited in a savings account and €1000 is deposited at the end of each year.
        // If the interest rate is 5% calculate and display the amount in the account after 6 years.
        double savings = 1000;
        double interestRate = 0.05;
        for (int i = 1; i <= 6; i++)
        {
            savings += savings * interestRate;
            savings += 1000;
            Console.WriteLine($"After {i} year(s) the total savings is: {savings}");
        }
    }

    private static void Question12()
    {
        //12.	The population of Ireland is 4.8 million and growing at a rate of 20% per year.
        //Write a program to determine and display the population in 10 years time.
        //Your program should also display the number of years that the population exceeds 5 million.
        double population = 4800000;
        double growthRate = 0.2;
        int yearsToFiveMillion = 10;
        for (int i = 1; i <= 10; i++)
        {
            population = population + (population * growthRate);
            if (population > 5000000 && yearsToFiveMillion > i)
            {
                yearsToFiveMillion = i;
            }
        }
        Console.WriteLine($"In {yearsToFiveMillion} year(s) the population will reach 5 million.");
        Console.WriteLine($"After 10 years the population will be {population:F2}");
    }

    private static void Question13()
    {
        //13.	A number can also be a palindrome. For example, each of the following five-digit integers is a palindrome: 12321, 55555, 45554 and 11611.
        //Write a program that reads in a five-digit integer and determines whether it is a palindrome.
        //(Hint: Use the division and modulus operators to separate the number into its individual numbers).
        //Note - yes it would be easier to treat this as a string but that's not the point...
        Console.WriteLine("Enter a 5 digit integer");
        int possiblePalindrome = Convert.ToInt32(Console.ReadLine());
        int lastNum = possiblePalindrome % 10;
        Console.WriteLine($"Last number: {lastNum}");
        int secondLastNum = (possiblePalindrome/10) % 10;
        Console.WriteLine($"Second last number: {secondLastNum}");
        int secondNum = (possiblePalindrome/1000) % 10;
        Console.WriteLine($"Second number: {secondNum}");
        int firstNum = (possiblePalindrome/10000) % 10;
        Console.WriteLine($"First number: {firstNum}");

        if (firstNum == lastNum && secondNum == secondLastNum)
        {
            Console.WriteLine("This number is a palindrome.");
        }
        
        //TODO: how would you handle this if you didn't know how long the number was? i.e. not 5 digits...

    }

    private static void Question14()
    {
        //14.	Write a program that reads 5 sets of three nonzero integers and determines and prints if they could be the sides of a right triangle.
        int a = 5;
        int b = 12;
        int c = 13;
        Console.WriteLine($"{a}, {b}, {c} could make a right angled triangle: {CheckIfRightAngledTriangle(a, b, c)}");
    }

    private static void Question15()
    {
        //15.	Write a program that calculates and prints the average of several integers. Assume the last value read is the sentinel 9999.
        //A typical input sequence might be 10 8 11 7 9 9999 indicating that the average of all the values preceding 9999 is to be calculated.
        
    }

    private static void Question16()
    {
        //16.	One interesting application of computers is drawing graphs and bar charts (sometimes called “histograms”).
        //Write a program that reads five numbers (each between 1 and 30).
        //For each number read, your program should print a line containing that number of adjacent asterisks.
        //For example, if your program reads the number seven, it should print *******.
    }
    
    private static void Question17()
    {
        //17.	Write a program that allows a user to enter 10 numbers between 1 and 100 and displays, the total of the numbers,
        // the smallest and largest numbers entered and the average of the numbers entered.
    }
    
    private static void Question18()
    {
        //18.	Write a C# program that utilizes looping and the tab escape sequence \t to print the following table of values:
        // 
        // N 	10*N 	100*N 	1000*N
        // 1 	10 	100	 1000
        // 2	 20 	200 	2000
        // 3	30	300 	3000
        // 4 	40 	400 	4000
        // 5 	50 	500 	5000
        // 
    }
    
    private static void Question19()
    {
        //19.	Develop a C# program that will determine the gross pay for each of several employees.
        //  The company pays “straight-time” for the first 40 hours worked by each employee and pays “time-and-a-half” for all hours worked in excess of 40 hours.
        //  You are given a list of the employees of the company, the number of hours each employee worked last week and the hourly rate of each employee.
        //  Your program should input this information for each employee and should determine and display the employee's gross pay.
    }
    //Useful/reusable methods

    public static bool CheckIfRightAngledTriangle(int x, int y, int z)
    {
        if (x > y && x > z)
        {
            //x is largest side
            return (x * x == ((y * y) + (z * z)));
        }
        else if(y > x && y > z)
        {
            //y must be the largest side
            return (y * y == ((x * x) + (z * z)));
        }
        else
        {
            //z must be the largest side or two sides are equal
            return (z * z == ((x * x) + (y * y)));
        }
    }

    public static bool CheckIsogram(string word)
    {
        string foundletters = "";
        foreach (char c in word)
        {
            if (foundletters.Contains(c)) return false;
            foundletters += c;
        }
        return true;
    }
    public static bool CheckPrimeNumber(int number)
    {
        int divisor = 2;
        Console.WriteLine($"Dividing {number} by {divisor}");
        while (number % divisor != 0)
        {
            divisor++;
            if (divisor == number)
            {
                return true;
            }
        }
        return false;
    }
    public static string ReverseWord(string word)
    {
        string reversed = "";
        foreach (char c in word)
        {
            reversed = c + reversed;
        }
        return reversed;
    }
}