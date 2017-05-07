using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        private string face;// A,  2,3......King
        private string suit; // diamon, heart, club, spade

        //Countructuroe
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        //return the face adding up and the suite
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
