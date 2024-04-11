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
        private readonly Color _color; //Color of the sphere. Can be readonly
        
        //Radius of the sphere. Cannot be readonly to do Pop() changing it.
        private float _radius; 
        
        //Number of times the sphere is thrown. 
        private int _n; //Cannot be readonly to do Throw() changing it.

        //A constant that sets the default number of throws to 0.
        private const int _nDef = 0;
    
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
            this._n = _nDef; //Defines the number of times to 0.
        }
        
        /// <summary>
        /// "Pops" the sphere by putting its radius to 0.
        /// </summary>
        public void Pop()
        { 
            _radius = 0; 
        }

        /// <summary>
        /// Increments by one the number of throws, but only if the sphere isn't
        /// pierced, which means that it has a radius bigger than 0.
        /// </summary>
        public void Throw()
        {
            if (_radius > 0)
            {
                _n++;
            }
            else
            {   
                Console.WriteLine("Sphere was popped");
            }
        }

        //Getter method that returns the number of times the sphere was thrown
        public int GetTimesThrown() => _n; 

    }
}