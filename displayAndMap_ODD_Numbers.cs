class displayOddNumbers
{
    /*
        Author: Joshua D. Thomas, Wilmington University

        This program sets an Upper Bound, and performs a conditional operation
        on ALL ODD NUMBERS BETWEEN 0 and [upperBound], depending on
        whether the number is Divisible By Three, or Divisible By Five, or Neither,
        and also ODD and Not Even, and LESS THAN [upperBound].

        Exit Condition: Upper Bound reached.
    */

    public static void Main()
    {
        int upperBound = 1000;//The programmer can set the Upper Bound.
        //
        int placeHolder = 0;//Default value
        int remainder = 0;//Default value
        //
        bool isDivisibleByThree = false;//Default value
        bool isDivisibleByFive = false;//Default value

        for (int i = 0; i <= upperBound; i++)
        {
            placeHolder = 2 * i + 1;//Find the Odd Number using Mathematics

            remainder = placeHolder % 3;
            if (remainder == 0)
            {
                // Is the Odd Number divisible by THREE?
                isDivisibleByThree = true;
            }

            remainder = placeHolder % 5;
            if (remainder == 0)
            {
                // Is the Odd Number divisible by FIVE?
                isDivisibleByFive = true;
            }

            if (isDivisibleByThree && isDivisibleByFive)
            {
                // Is the Odd Number divisible by THREE AND FIVE?
                // Is the Odd Number LESS THAN [upperBound]?
                if (placeHolder <= upperBound)
                {
                    System.Console.WriteLine(placeHolder + ":" + placeHolder * -10);
                }
            }
            else if (isDivisibleByThree)
            {
                // Is the Odd Number divisible by THREE and not FIVE?
                // Is the Odd Number LESS THAN [upperBound]?
                if (placeHolder <= upperBound)
                {
                    System.Console.WriteLine(placeHolder + ":" + placeHolder * -1);
                }
            }
            else if (isDivisibleByFive)
            {
                // Is the Odd Number divisible by FIVE and not THREE?
                // Is the Odd Number LESS THAN [upperBound]?
                if (placeHolder <= upperBound)
                {
                    System.Console.WriteLine(placeHolder + ":" + placeHolder * 10);
                }
            }
            else
            {
                // Is the Odd Number divisible by NEITHER THREE NOR FIVE?
                // Is the Odd Number LESS THAN [upperBound]?
                if (placeHolder <= upperBound)
                {
                    System.Console.WriteLine(placeHolder + ":" + placeHolder);
                }
            }

            isDivisibleByThree = resetFlag(); // Reset Flags
            isDivisibleByFive = resetFlag(); // Reset Flags
        }
    }

    private static bool resetFlag() // Return FALSE to reset the Flags in Main().
    {
        // RETURN Statement
        return false;
    }
}