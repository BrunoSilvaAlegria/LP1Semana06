using System;

namespace ColorSpheres
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instance of the color green
            Color green = new Color(0, 255, 0, 150);
            //Instance of a green sphere
            Sphere sphere_green = new Sphere(green, 10f);

            //Instance of the color blue
            Color blue = new Color(0, 0, 255); // Alpha is set to 255 by default
            //Instance of a blue sphere
            Sphere sphere_blue = new Sphere(blue, 6f);

            //Instance of the color blue
            Color red = new Color(255, 0, 0, 60); // Alpha is set to 255 by default
            //Instance of a blue sphere
            Sphere sphere_red = new Sphere(red, 18f);

            //Thrown of the spheres
            sphere_green.Throw(); //1
            sphere_blue.Throw(); //1
            sphere_red.Throw(); //1

            sphere_red.Pop(); //Pops the red sphere
            sphere_blue.Pop(); //Pops the green sphere

            //Throwing the green sphere five times
            sphere_green.Throw(); //2
            sphere_green.Throw(); //3
            sphere_green.Throw(); //4
            sphere_green.Throw(); //5
            sphere_green.Throw(); //6

            //Throwing the blue and red two more times
            sphere_blue.Throw();
            sphere_red.Throw();

            // Print times thrown
            Console.WriteLine(sphere_green.GetTimesThrown());
            Console.WriteLine(sphere_blue.GetTimesThrown());
            Console.WriteLine(sphere_red.GetTimesThrown());

            //No more actions should be done by the popped spheres do to Pop()
            //making it unusable
            

            //Results should shown:
            //Sphere was popped ---> Blue sphere was popped
            //Sphere was popped ---> Red sphere was popped
            //6 ---> Number of times the green sphere was thrown
            //1 ---> Number of times the blue sphere was thrown
            //1 ---> Number of times the red sphere was thrown
          
            //The number of other spheres isn't shown due to them being popped
        }
    }
}
