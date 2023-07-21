using System;

public class program
{

    public static string Reverse(int number)
    {
        int reverse = 0;
        int original = number;

        for (int i=0; number > 0; number /= 10)
        {
            i= i * 10 + number % 10;
            reverse = i;
        }

        return reverse.ToString() + original.ToString();
    }

    public static void Main()
    {
        int num;
        Console.Write( "Please Enter a number : ");
        num = Convert.ToInt32(Console.ReadLine());
        string result = Reverse(num);
        Console.Write("The reverse and append of number is : "+result);
    }

}
