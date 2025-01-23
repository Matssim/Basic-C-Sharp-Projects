using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        //Creates a dictionary of possible card values 
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        //The below method accounts for the double value of Ace (1 or 11), by using the aceCount formula to determine the
        // amount of Ace's in the hand and creating the result array which can contain any combination value of two Ace's, 
        // one Ace and a non-Ace card, or two non-Ace cards after the execution of the block. The initial value of value 
        // is the sum of the hand which is placed a the 0 index of the result array. However, if there is an Ace in the 
        // hand, the aceCount value is placed a different index in the same array. So, if there are no Aces, the length of 
        // the result array is 1, which will return the array as is. Then a for loop continues where each item above 1 
        // increments the length of the array (i) and is then iterated over to have itself multiplied by 10 and added to 
        // itself (11). That is then added to the result array which is returned with the possible Ace-included hand values.
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1 ) { return result; }
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        //Creates a method to check a hand for Blackjack by calling the GetAllPossibleHandValues method and checking if the 
        // maximum value is exactly 21, then returns a boolean based on that equation
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21 ) return true;
            else return false;
        }

        //Creates a method to check if a hand is busted by calling the GetAllPossibleHandValues method and checking if the 
        // minimum value is above 21, then returns a boolean based on that equation
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true; 
            else return false;
        }

        //Creates a method that iterates over the dealers Hand, calls the GetAllPossibleHandValues on it and establishes that
        // the dealer stays on a Hand value above 16 and under 22, by returning a boolean
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        //Creates a method that takes in the dealer and players hands, calls the GetAllPossibleHandValues method to compare
        // the highest possible hands under 22 (not busted) and returns a boolean of true(player's hand is greater),
        // false(dealer's hand is greater) or null(equal), based on that equation
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
