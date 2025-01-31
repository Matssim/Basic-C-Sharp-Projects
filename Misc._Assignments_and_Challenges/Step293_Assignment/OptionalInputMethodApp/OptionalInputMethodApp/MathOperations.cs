
namespace OptionalInputMethodApp
{
    public class MathOperations
    {
        //Establishes the "AddToFive()" method as: public, to make to as it accessible accross the namespace; static, as it is  
        // not an object of MathOperations, but a method; and with an integer return type. The Userint variable is passed in
        public static int AddToFive(int UserInt1, int UserInt2)
        {
            //Adds Userint to 5 and establishes the result as an integer variable that is returned from the method
            int additionResult = UserInt1 + UserInt2 + 5;
            return additionResult;
        }
    }
}
