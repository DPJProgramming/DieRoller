using System;
namespace Die_Roller {

    /// <summary>
    /// Represents a single six sided die(1-6)
    /// </summary>
    public class Die {

        /// <summary>
        /// current face up value of die
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// true if die is currently held
        /// </summary>
        public Boolean IsHeld { get; set; }

        /// <summary>
        /// rolls the die and sets the <see cref="FaceValue"/>
        /// to the new number
        /// </summary>
        /// <returns> new random number </returns>
        public byte Roll() {
            throw new NotImplementedException();
        }
    }
}


