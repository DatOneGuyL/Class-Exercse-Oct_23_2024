using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;

internal class Program
{
    static void ex1() //Exercise 1: odd or even number
    {
        Console.Write("Input a number: ");
        int n1 = int.Parse(Console.ReadLine());
        if (n1 % 2 == 0)
        {
            Console.WriteLine($"{n1} is an even number");
        }
        if (n1 % 2 != 0)
        {
            Console.WriteLine($"{n1} is an odd number");
        }
    }

    static void ex2() //Exercise 2: find the largest of three number
    {
        //User input three numbers seperated by spaces to be split into an array for processing 
        Console.WriteLine("Enter numbers seperated by spaces: ");
        string n2 = Console.ReadLine();
        string[] n2Array = n2.Split(' '); //split string into array
        int[] intarray = Array.ConvertAll(n2Array, int.Parse); //convert string array to integer

        //finding the largest number 
        int placeholder = 0;
        for (int i = 1; i < intarray.Length; i++)
        {
            if (intarray[i] > intarray[i - 1])
            {
                placeholder = intarray[i];
            }
            else
            {
                placeholder = intarray[i - 1];
            }
        }
        Console.WriteLine($"The largest number is {placeholder}");

    }

    static void ex3() //determine the quadrant
    {
        Console.Write("Input x value: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input y value: ");
        int y = int.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("The coordinate point (0,0) lies at the origin point");
        }

        if (x > 0)
        {
            if (y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant");
            }
        }

        if (x < 0)
        {
            if (y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant");
            }
        }
    }

    static void ex4() //check if equilateral, isosceles or scalene triangle
    {
        //User input three numbers seperated by spaces to be split into an array for processing 
        Console.Write("Enter the triangle's angle or sides seperated by spaces: ");
        string n4 = Console.ReadLine();
        string[] n4Array = n4.Split(' '); //split string into array
        int[] intarray = Array.ConvertAll(n4Array, int.Parse); //convert string array to integer

        //condition to determine triangle
        int count = 0;
        for (int i = 1; i < intarray.Length; i++)
        {
            if (intarray[0] == intarray[i])
            {
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("The triangle is Scalene");
        }
        if (count == 1)
        {
            Console.WriteLine("The triangle is Isosceles");
        }
        if (count == 2)
        {
            Console.WriteLine("The triangle is Equilateral");
        }

    }

    static void ex5() //input 10 numbers and give average and sum 
    {
        //User input three numbers seperated by spaces to be split into an array for processing 
        Console.Write("Enter numbers seperated by spaces: ");
        string n5 = Console.ReadLine();
        string[] n5Array = n5.Split(' '); //split string into array
        int[] intarray = Array.ConvertAll(n5Array, int.Parse); //convert string array to integer

        float sum = 0;
        for (int i = 0; i < intarray.Length; i++)
        {
            sum += intarray[i];
        }

        Console.WriteLine($"The average of the ten numbers is {sum / intarray.Length}, the sum of the ten numbers is {sum}");
    }

    static void ex6() //display the multiplication table of a given integer
    {
        Console.Write("Input an integer: ");
        int n6 = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{n6} x {i} = {n6 * i}");
        }
    }

    static void ex7() //program to display a pattern like triangles with a number
    {
        Console.Write("Enter an integer: ");
        int n7 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n7; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j}");
            }
            Console.WriteLine(" ");
        }
    }

    static void ex8() //harmonic series 
    {
        Console.Write("Enter n terms: ");
        int n8 = int.Parse(Console.ReadLine());

        //display and sum
        double sum = 1;
        Console.Write("1");
        for (int i = 1; i <= n8; i++)
        {
            Console.Write($" + 1/{i}");
            double temp = 1 / i;
            sum += temp;
        }
        Console.Write($" = {sum}");
    }

    static void ex9() //find perfect number within a given number range 
    {
        Console.Write("Input range start: ");
        int n9start = int.Parse(Console.ReadLine());
        Console.Write("Input range end: ");
        int n9end = int.Parse(Console.ReadLine());

        List<int> perfnum = new List<int>(); //declare dynamic list 
        for (int i = n9start; i <= n9end; i++)
        { //value i go from start value to end value
            float sum = 0;
            for (int j = 1; j < i; j++) //test if number is perfect
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }
            if (sum == i)
            {
                perfnum.Add(i); //add perfect number to list 
            }
        }
        Console.WriteLine("The perfect numbers in the range are ");
        foreach (int num in perfnum)
        {
            Console.Write($"{num}, "); //print out list 
        }
    }

    static void ex10()
    {
        Console.Write("Enter a number: ");
        int n10 = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 2; i < n10; i++)
        {
            if (n10 % i == 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine($"{n10} is a prime number");
        }
    }

    static int Main()
    {
        ex10();
        return 0;
    }
}
