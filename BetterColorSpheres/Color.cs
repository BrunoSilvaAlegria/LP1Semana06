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
        private readonly byte _red, _green, _blue, _alpha;

        //A constant that sets the default alpha to 255.
        private const byte _alphaDef = 255; 
//============================================================================//        
        /// <summary>
        /// This is a constructor that accepts values for RGB color 
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
            this._alpha = _alphaDef;
        }
//============================================================================//
        //Getters methods for values. 
        public byte Red { get; } //Gets red value
        public byte Green { get; }  //Gets green value
        public byte Blue { get; }  //Gets blue value
        public byte Alpha { get; }  //Gets transparency value
//============================================================================//    
                                            
//Gets grey value, which is the average of RGB values, and guarantees that its
//value is within range of the RGB color values.

        public byte GetGrey() => (byte)((_red + _blue + _green) / 3);
        //Calculate the average of the RGB values.
        //The result is guaranteed to be within the byte range.
    }
}