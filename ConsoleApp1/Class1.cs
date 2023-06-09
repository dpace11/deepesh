﻿

namespace ConsoleApp1;

public class DayOne
{
    /// <summary>
    /// Create a function that takes two numbers as arguments and returns their sum.
    /// </summary>
    /// <example>
    /// addition(3, 2) ➞ 5
    /// addition(-3, -6) ➞ -9
    /// </example>

    public void Sum(int firstnum, int secondnum)
    {
        var result = firstnum + secondnum;
        Console.WriteLine($"the sum of {firstnum} and {secondnum} is {result}");

    }
    /// <summary>
    /// function to change minutes to seconds
    /// </summary>
    ///<example>
    ///convert(5) ➞ 300
    ///convert(3) ➞ 180
    ///</example>
    public void ConvertToMin(int minutes)
    {
        var seconds = minutes * 60;
        Console.WriteLine($"{minutes} minutes converted into seconds is {seconds}");
    }

    /// <summary>
    /// Create a function that takes a number as an argument, increments the number by +1 and returns the result
    /// </summary>
    /// <example>
    /// Addition(0) ➞ 1
    /// Addition(9) ➞ 10

    /// </example>
    public void NextNumber(int number)
    {
        var incnum = number + 1;
        Console.WriteLine($"the next number after {number} is :{incnum}");
    }


    public void PowerCircuitCalcu(int voltage, int current)
    {
        var power = voltage * current;
        Console.WriteLine($"the power of the ciruit from voltage:{voltage} & current:{current} is {power}");
    }

    /// <summary>
    /// Create a function that takes the age in years and returns the age in days.
    /// </summary>
    /// <example>
    /// CalcAge(65) ➞ 23725
    /// CalcAge(20) ➞ 7300
    /// </example>
    public void AgeToDays(int age)

    {
        var yearlength = 365;
        var days = age * yearlength;
        Console.WriteLine($"the days of your {age} age is {days}");
    }


    /// <summary>
    /// a function that takes the base and height of a triangle and return its area.
    /// </summary>
    /// <example>
    /// triArea(3, 2) ➞ 3
    /// triArea(7, 4) ➞ 14
    /// </example>
    public void triArea(float length, float breadth)
    {
        var area = (length * breadth) / 2;
        Console.WriteLine($"area of triangle of length:{length} & breadth{breadth} is {area}");
    }

    /// <summary>
    /// There is a single operator in C#, capable of providing the remainder of a division operation. 
    /// Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.
    /// </summary>

    public void Rem(int num1, int num2)
    {
        var result = num1 % num2;
        Console.WriteLine($"remainder of {num1} & {num2} is {result}");
    }

    /// <summary>
    /// Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.
    /// </summary>
    /// <param name="num"></param>
    public void IsEqualZero(int num)
    {
        Console.Write($"is {num} equl to zero::");
        if (num == 0)
        {
            Console.WriteLine("true");
        }
        else { Console.WriteLine("false"); }
    }

    /// <summary>
    /// Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
    /// </summary>
    /// <example>
    /// lessThan100(22, 15) ➞ true
    // 22 + 15 = 37
    ///lessThan100(83, 34) ➞ false
    // 83 + 34 = 117
    /// </example>
    public void LessThanHundred(int num1, int num2)
    {
        Console.Write($"is sum of {num1} & {num2} less than 100::");
        var sum = num1 + num2;
        if (sum < 100) { Console.WriteLine("true"); }
        else { Console.WriteLine("false"); }
    }

    /// <summary>
    /// Create a function that takes two integers and checks if they are equal.
    /// </summary>
    ///<example>
    ///IsEqual(5, 6) ➞ false
    ///IsEqual(1, 1) ➞ true
    ///</example>
    public void IsEqual(int num1, int num2)
    {
        if (num1 == num2)
        {
            Console.Write($"are {num1} and {num2} equal??::");
            Console.WriteLine("true");
        }
        else { Console.WriteLine("false"); }
    }


    /// <summary>
    /// Write a function that returns the string "something" joined with a space " " and the given argument a.
    /// </summary>
    /// <example>
    /// GiveMeSomething("is better than nothing") ➞ "something is better than nothing"
    /// GiveMeSomething("Bob Jane") ➞ "something Bob Jane"
    /// </example>
    public string GiveMeSomething(string text)
    {
        return ("something " + text);
    }



    /// <summary>
    /// Create a function that reverses a boolean value
    /// </summary>
    /// <param name="n"></param>
    public bool Reverse(bool n)
    {
        if (n == true)
        {
            Console.WriteLine($"opposite of {n} is false");
            return true;
        }
        else
        {
            Console.WriteLine($"opposite of {n} is true");
            return false;
        }
    }

    public int howManyseconds(int hour)
    {
        var sec = hour * 60 * 60;
        return (sec);
    }


    /// <summary>
    ///Create a function that takes an array containing only numbers and return the first element. 
    /// </summary>
    /// <exampe>
    /// getFirstValue([1, 2, 3]) ➞ 1
    /// getFirstValue([80, 5, 100]) ➞ 80
    /// </exampe>
    public int getFirstValue(int[] num)
    {
        return (num[0]);

    }

    /// <summary>
    /// Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers
    /// </summary>
    /// <example>
    /// nextEdge(8, 10) ➞ 17
    /// nextEdge(5, 7) ➞ 11
    /// </example>
    public int nextEdge(int sideone, int sidetwo)
    {
        return ((sideone + sidetwo) - 1);
    }

    /// <summary>
    /// function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
    /// </summary>
    
    public void  MonthName(int month)
    {
        switch (month)
        {
            case 1:
                Console.WriteLine ("January");
                break;
            case 2:
                Console.WriteLine("Feburary");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Enter a valid month");
                break;
        }
    }

}