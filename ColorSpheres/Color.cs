using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
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
            
        }
    }
}