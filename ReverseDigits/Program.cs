using System;

class ReverseDigits
{
    static void Main()
    {
        Console.Write("Enter an integer to reverse its digits: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = Reverse(number);
        Console.WriteLine($"The reversed number is: {reversedNumber}");
    }

    static int Reverse(int number)
    {
        int reversed = 0;
        while (number != 0)
        {
            reversed = (reversed * 10) + (number % 10);
            number /= 10;
        }
        return reversed;
    }
}
