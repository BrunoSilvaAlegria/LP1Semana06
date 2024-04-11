using System;

namespace ColorSpheres
{
    /// <summary>
    /// Prints out the spheres and their color and transparency by using the
    /// Sphere and Color classes, respectively.
    /// </summary>
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

            //Instance of the color red
            Color red = new Color(255, 0, 0, 60);
            //Instance of a red sphere
            Sphere sphere_red = new Sphere(red, 18f);

            //Instance of color1
            Color color1 = new Color(100, 56, 84, 10);
            //Instance of a color1 sphere
            Sphere sphere_color1 = new Sphere(color1, 25f);

            //Thrown of the spheres
            sphere_green.Throw(); //1
            sphere_blue.Throw(); //1
            sphere_red.Throw(); //1
            sphere_color1.Throw(); //1

            sphere_green.Pop(); //Pops the green sphere
            sphere_blue.Pop(); //Pops the blue sphere

            //Throwing the green and color 1 spheres five more times
            sphere_green.Throw(); //2
            sphere_green.Throw(); //3
            sphere_green.Throw(); //4
            sphere_green.Throw(); //5
            sphere_green.Throw(); //6

            sphere_color1.Throw(); //2
            sphere_color1.Throw(); //3
            sphere_color1.Throw(); //4
            sphere_color1.Throw(); //5
            sphere_color1.Throw(); //6

            //Throwing the blue and red two more times
            sphere_blue.Throw();
            sphere_red.Throw();

            //Print times thrown
            Console.WriteLine($"Green sphere:{sphere_green.GetTimesThrown}");
            Console.WriteLine($"Blue sphere:{sphere_blue.GetTimesThrown}");
            Console.WriteLine($"Red sphere:{sphere_red.GetTimesThrown}");
            Console.WriteLine($"Color1 sphere:{sphere_color1.GetTimesThrown}");

            //No more actions should be done by the popped spheres will be 
            //counted do to Pop(), making them unusable
            

            //Results should shown:
            //Green sphere:1
            //Blue sphere:1
            //Red sphere:2
            //Color1 sphere:6
        }
    }
}