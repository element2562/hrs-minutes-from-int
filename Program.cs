using System;

class MainClass
{
    public static string TimeConvert(int num)
    {

        // code goes here  
        /* Note: In C# the return type of a function and the 
           parameter types being passed are defined, so this return 
           call must match the return type of the function.
           You are free to modify the return type. */
        int hours = num / 60;
        // if(hours < 1)
        // {
        //     hours = 0;
        // }
        var minutes = num % 60;
        return $"{hours}:{minutes}";

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(TimeConvert(Console.ReadLine()));
    }

}
