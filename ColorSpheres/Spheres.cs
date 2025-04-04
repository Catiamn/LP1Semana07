namespace ColorSpheres
{
public class Sphere

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

}