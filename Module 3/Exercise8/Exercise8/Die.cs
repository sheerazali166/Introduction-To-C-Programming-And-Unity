using System;
namespace Exercise8
{
    /// <summary>
    /// A die
    /// </summary>

    public class Die
    {
        #region Fields;

        int topSide;
        int numSides;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for six-sided die
        /// </summary>

        public Die(): this(6)
        {
        }


        /// <summary>
        /// Constructor for a die with the given number of sided
        /// </summary>
        /// <param name="numSides">the number of sides</param>

        public Die(int numSides) {

            this.numSides = numSides;
            topSide = 1;
        }

        #endregion

        #region Properties


        /// <summary>
        /// Gets the current top side of the die
        /// </summary>

        public int TopSide {

            get { return this.topSide; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Rolls the die
        /// </summary>
        
        public void Roll() {

           // topSide = 
        }

        #endregion
    }
}