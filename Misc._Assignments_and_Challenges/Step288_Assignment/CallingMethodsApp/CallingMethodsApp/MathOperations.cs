
namespace CallingMethodsApp
{
    //Establishes "MathOperations" as a public class, which makes it accessible accross the namespace
    public class MathOperations
    {
        //Establishes the "AddToFive()" method as: public, to make to as it accessible accross the namespace; static, as it is  
        // not an object of MathOperations, but a method; and with an integer return type. The Userint variable is passed in
        public static int AddToFive(int Userint)
        {
            //Adds Userint to 5 and establishes the result as an integer variable that is returned from the method
            int additionResult = Userint + 5;
            return additionResult;
        }
        //Establishes the "MultiplyByFive()" method as: public, to make to as it accessible accross the namespace; static, as it is  
        // not an object of MathOperations, but a method; and with an integer return type. The Userint variable is passed in
        public static int MultiplyByFive(int Userint)
        {
            //Multiplies Userint by 5 and establishes the result as an integer variable that is returned from the method
            int multiplicationResult = Userint * 5;
            return multiplicationResult;
        }
        //Establishes the "DivideByTwo()" method as: public, to make to as it accessible accross the namespace; static, as it is  
        // not an object of MathOperations, but a method; and with an integer return type. The Userint variable is passed in
        public static int DivideByTwo(int Userint)
        {
            //Divides Userint by 2 and establishes the result as an integer variable that is returned from the method
            int divisionResult = Userint / 2;
            return divisionResult;
        }
    }
}
