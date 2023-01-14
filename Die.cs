using System;
namespace DieRoller {

    /// <summary>
    /// Represents a single six sided die(1-6)
    /// </summary>
    public class Die {

        /// <summary>
        /// object constructor
        /// </summary>
        public Die() {
            Roll();
        }

        /// <summary>
        /// current face up value of die
        /// </summary>
        public byte FaceValue { get; private set; }

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

            if (!IsHeld) {

				//generate random number 
				//cast newValue as byte because random returnss and integer 
				Random random = new Random();
				byte newValue = (byte)random.Next(1, 7);

				FaceValue = newValue;
			}
			return FaceValue;
        }
    }
}


