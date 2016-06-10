using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{

    // This class extends the List<Card> generic type
    class Deck: List<Card>
    {
        //CONSTRUCTORS

        //This is the default constructor for the Deck class
        public Deck()
        {

        }

            private void _create()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit));
                }
            }

        }
        
        
        //PUBLIC METHODS




            // method Display
        public void Display()
        {
            Console.WriteLine("Current Deck");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
        }
        //end method Display

        //This method randomly shuffles a list of Card objects
        public void Shuffle()
        {
            Random random = new Random();
            //records # of cards in the deck
            int cardCount = this.Count;

            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard]; //copy current card to temp location
                int randomCard = random.Next(0, cardCount); //get a random card index
                this[currentCard] = this[randomCard]; //copy value from randomCard to currentCard
                this[randomCard] = tempCard; //copy current card to random card
            }

        } //end method Shuffle

        //method Deal, returns type [Card]
        public Card Deal()
        {
            Card returnedCard = this[0];//copy the 0th card in the stack to the returnedCard

            this.RemoveAt(0); //remove the 0th card

            return returnedCard;
        }

    }    
}
