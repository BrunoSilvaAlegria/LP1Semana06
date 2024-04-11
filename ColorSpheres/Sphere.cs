using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{   
    /// <summary>
    /// Makes a sphere that has a color defined by the class Color and a certain
    /// radius. This sphere is thrown a number of times (n) defined by the user. 
    /// </summary>
    public class Sphere
    {
        private Color _color; //Color of the sphere
        private float _radius; //Radius of the sphere
        private int _n; //Number of times the sphere is thrown
    
        /// <summary>
        /// Constructor that accepts values for the color (processed by the
        /// class Color)  and radius.
        /// </summary>
        /// <param name="color">Color of the sphere</param>
        /// <param name="radius">Value of the sphere radius</param>
        public Sphere(Color color, float radius)
        {
            this._color = color;
            this._radius = radius;
            this._n = 0; //Defines the number of times to 0
        }
        
        /// <summary>
        /// "Pops" the sphere by putting its radius to 0.
        /// </summary>
        private Pop()
        { 
            radius = 0; 
        }

        /// <summary>
        /// Increments by one the number of throws, but only if the sphere isn't
        /// pierced, which means that it has a radius bigger than 0.
        /// </summary>
        private Throw()
        {
            if (radius > 0)
            {
                _n++;
            }
        }

        //Getter method that returns the number of times the sphere is thrown
        public int GetTimesThrown() => _n; 

    }
}