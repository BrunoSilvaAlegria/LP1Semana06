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
        //Initialize the variables (with values from 0 to 255).
        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;
        private readonly byte _alpha;
        
        /// <summary>
        /// This is a constructor that accepts values for the color 
        /// and transparency.
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
        /// Constructor that accepts values for color, but not transparency
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

        //Getters methods for values. 
        public byte GetRed() => _red; //Gets red value
        public byte GetGreen() => _green; //Gets green value
        public byte GetBlue() => _blue; //Gets blue value
        public byte GetAlpha() => _alpha; //Gets transparency value
        
        //Gets grey value, which is the average of RGB values, and guarantees
        //that its value is within range of the RGB color values.
        public byte GetGrey() 
        {
            //Calculate the average of the RGB values.
            int sum = _red + _green + _blue;
            byte grey = (byte)(sum / 3);
            
            //The result is guaranteed to be within the byte range.
            return grey; 
        }

    }
}