using System;
namespace Exercise9
{
    /// <summary>
    /// A playing card
    /// </summary>

    public class Card
    {
        #region Fields

        string rank;
        string suit;
        bool faceUp;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a card with the given rank and suit
        /// </summary>
        /// <param name="rank">the rank</param>
        /// <param name="rank">the suit</param>

        public Card(string rank, string suit) 
        {
            this.rank = rank;
            this.suit = suit;
            this.faceUp = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the card rank
        /// </summary>

        public string Rank {

            get { return this.rank; }
        }

        /// <summary>
        /// Gets the card suit
        /// </summary>

        public string Suit {

            get { return this.suit; }
        }

        /// <summary>
        /// Gets weather or not the card is face up
        /// </summary>

        public bool FaceUp {

            get { return this.faceUp; }
        }

        #endregion

        #region

        /// <summary>
        /// Flips the card over
        /// </summary>

        public void FlipOver() {

            this.faceUp = !this.faceUp;

        }

        #endregion

    }
}
