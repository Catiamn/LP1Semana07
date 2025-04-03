using System;

namespace ColorSpheres
{
    public class Program
    {
        //Set Colors
        public class Color
        {
            private byte red;
            private byte green;
            private byte blue;
            
            public byte Red
            {
                get { return red; }
                set { red = value; }
            }

            public byte Green
            {
                get { return green; }
                set { green = value; }
            }

            public byte Blue
            {
                get { return blue; }
                set { blue = value; }
            }

            public Color(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
        }

        private class Sphere
        {
            private Color color;
            private int radius;
            private int throwTimes;

            //Information about the Sphere
            public Sphere(Color color, int radius)
            {
                this.color = color;
                this.radius = radius;
                this.throwTimes = 0;
            }

            //Call the colors and return it
            public Color GetColor()
            {
                return color;
            }

            public int GetRadius()
            {
                return radius;
            }

            public void Pop()
            {
                radius = 0;
            }

            public void Throw()
            {
                if (radius > 0)
                {
                    throwTimes++;
                }
            }

            public int GetTimesThrown()
            {
                return throwTimes;
            }
    
        }
        public static void Main()
        {
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255);
            Color greenColor = new Color(0, 255, 0);

            Sphere sphere1 = new Sphere(redColor, 10);
            Sphere sphere2 = new Sphere(blueColor, 15);
            Sphere sphere3 = new Sphere(greenColor, 12);

            // Throw 3 times sphere 1
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();

            // Pop sphere2
            sphere2.Pop();

            //Try to Throw it even thought its popped
            sphere2.Throw();

            // Print about the spheres (color, radius and how many times it was thrown)
            Console.WriteLine("Esfera 1:");
            Console.WriteLine($"Cor: ({sphere1.GetColor().Red}, {sphere1.GetColor().Green}, {sphere1.GetColor().Blue})");
            Console.WriteLine($"Raio: {sphere1.GetRadius()}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere1.GetTimesThrown()}");
            Console.WriteLine();

            Console.WriteLine("Esfera 2:");
            Console.WriteLine($"Cor: ({sphere2.GetColor().Red}, {sphere2.GetColor().Green}, {sphere2.GetColor().Blue})");
            Console.WriteLine($"Raio: {sphere2.GetRadius()}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere2.GetTimesThrown()}");
        }

    }
}
