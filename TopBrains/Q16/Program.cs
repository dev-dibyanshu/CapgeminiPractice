using System;
using System.Diagnostics;

public class Solution{
    static long sumOfDigits(long n){
        long sum  =0;

        while(n>0){
            long d = n %10;
            n = n/10;
            sum += d;
        }
        return sum;
    }

    static bool IsPrime(long n)
    {
        if (n < 2)
            return false;

        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static bool isLucky(long x){
        if (IsPrime(x)){
            return false;
        }
        long sum = sumOfDigits(x);
        long squareSum = sumOfDigits(x * x);

        return squareSum == sum * sum;
    }

    public static void Main(){
        string[] input = Console.ReadLine().Split();
        long m = long.Parse(input[0]);
        long n = long.Parse(input[1]);
        long count = 0;

        for (long i = m; i <= n; i++)
        {
            if (isLucky(i))
                count++;
        }

        Console.WriteLine(count);
    }
}