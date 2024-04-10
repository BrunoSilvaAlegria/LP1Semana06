using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    /// <summary>
    /// This class defines the color of a sphere by combining the RGB values and
    /// its transparency, which is Alpha.
    /// </summary>
    public class Color
    {
        //Initialize the variables (with values from 0 to 255)
        private byte _red;
        private byte _green;
        private byte _blue;
        private byte _alpha;
        
        /// <summary>
        /// Constructor that accepts values for the color and transparency.
        /// </summary>
        /// <param name="red">Value of red</param>
        /// <param name="green">Value of green</param>
        /// <param name="blue">Value of blue </param>
        /// <param name="alpha">Value of transparency</param>
        public Color (byte red, byte green, byte blue, byte alpha)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = alpha;
        }

        /// <summary>
        /// Constructor that accepts values for the color, but not transparency
        /// because it is already set to 255.
        /// </summary>
        /// <param name="red">Value of red</param>
        /// <param name="green">Value of green</param>
        /// <param name="blue">Value of blue </param>
        public Color (byte red, byte green, byte blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = 255;
        }

        //Getters methods for values 
        public byte GetRed() => _red; //Gets red value
        public byte GetGreen() => _green; //Gets green value
        public byte GetBlue() => _blue; //Gets blue value
        public byte GetAlpha() => _alpha; //Gets transparency value
        public byte GetGrey() //Gets grey value
        {
            byte grey = (_red + _green + _blue) / 3;
            if (grey > 0 && grey < 255) return grey;
        }
    }
}