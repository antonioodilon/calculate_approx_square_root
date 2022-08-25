using System;
using System.Collections.Generic;

// Main()
Console.WriteLine(calcApproxSqroot(4));
Console.WriteLine(calcApproxSqroot(16));
Console.WriteLine(calcApproxSqroot(25));
Console.WriteLine(calcApproxSqroot(41));

// Functions:
decimal calcApproxSqroot(int number)
{
    decimal result = 0M;

    for (int i = 0; i <= number; ++i)
    {
        if ((i * i) == number)
        {
            result = (decimal)i;
            return result;
        }
    }

    number *= 1000000;
    for (int j = 0; j <= number; ++j)
    {
        if (j * j > number)
        {
            result = ((decimal)(j - 1))/1000;
            return result;
        }
    }

    return result;
}