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
        
        // The main method is the entry point for all C# programs
        public static void Main() {
            StackOverflow();
        }

        
        // Will force a stack overflow
        public static void StackOverflow() {
            StackOverflow();           
        }
        
        
    }

}
