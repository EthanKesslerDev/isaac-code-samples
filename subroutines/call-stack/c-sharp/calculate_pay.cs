/*
Isaac Computer Science
Usage licensed under the Open Government Licence v3.0
Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if neccesary)
4. Compile the program
5. Run the program
*/

using System;

namespace IsaacCodeSamples    
{
    
    class CallStack
    {
        
        // Simple program to demonstrate the use of call stacks
        static void Main() {            
            Console.WriteLine("Enter hours worked ");
            string hoursInput = Console.ReadLine();
            int hoursFloat = Convert.ToInt32(num1_input);
            Console.WriteLine("Enter hourly rate ");

            string rateInput = Console.ReadLine();
            int rateFloat = Convert.ToInt32(num2_input);
            int pay = CalculatePay(hoursFloat, rateFloat);
            Console.WriteLine(pay);            
        }
        

        // A simple pay calculation program
        static float CalculatePay(float h, float r) {
            float pay = h * r;
            return pay;
        }
        
        
    }
}

