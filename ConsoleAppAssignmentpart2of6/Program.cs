using System;

namespace ConsoleAppAssignmentpart2of6
{
//    CONSOLE APP PART TWO ASSIGNMENT

//   Add the following to your console app and perform these actions:


//An infinite loop.

//Save your code.

//Fix the infinite loop so that it will execute properly.

//Add comments to your code indicating how the infinite loop was fixed.
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 6)
            //while loop uses the variable in its condition to evaluate if i is less than 6. if it is 6 or more, the condition is false and the loop ends.
            //NOTE--if the curly braces are not around lines 26-29--this will result in an INFINITE loop running zero.

            {
                Console.WriteLine(i);
                i++;
            }
            //this increases increment operator (++) to increase variable by 1.
            //program will print all values 0-5.
            //This bug initally happened yesterday while doing another assignment. The exercise was to do a boolean comparison using a do while statement.
            
        }
    }
}
