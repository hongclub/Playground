using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace Playground
{
    public static class NullOperators
    {
       
        public static void questionMarkAndSemiColon()
        {
            // ??
        }


        /// <summary>
        /// Method to use singleQuestionMarkwithValue()
        /// behavior: if the card has value, it should return the CardNumber after ?
        /// </summary>
        public static void singleQuestionMarkwithValue()
        {
            Card card = new Card() { CardNumber = "1234" };
            string result = card?.CardNumber;

            Console.WriteLine(result);
        }

        /// <summary>
        /// Method to use singleQuestionMarkwithValue()
        /// behavior: if the card is null, then it won't return CardNumber after ?
        /// </summary>
        public static void singleQuestionMarkwithoutValue()
        {
            Card card = null;
            string result = card?.CardNumber;

            Console.WriteLine(result);
        }

        public static void doubleQuestionMark()
        {
            // ?? 
        }
    }

    
}
