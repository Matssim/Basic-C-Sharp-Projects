using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //Creates a struct for cards with the attributes of the enums Suit and Face as defined below
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        //Creates a method that makes it easier to call a string to describe a given card instance
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs, 
        Diamonds, 
        Hearts, 
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six, 
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King, 
        Ace
    }
}
