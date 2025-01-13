using System;

namespace VariousMethodsApp
{
    //Declares the static class StaticMethods
    public static class StaticMethods
    {
        //Establishes the Double method and passes in UserInt4. The method is static so it can function under the static class
        public static void Double(int UserInt4)
        {
            //Multiplies UserInt4 by 2 and establishes the output as the DoubleResult variable, then prints it concatenated to
            // a string and UserInt4 to show the full statement
            int DoubleResult = UserInt4 * 2;
            Console.WriteLine("When you double " + UserInt4 + ", you get " + DoubleResult);
        }

    }
}
