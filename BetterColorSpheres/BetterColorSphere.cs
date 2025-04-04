namespace BetterColorSpheres
{
    public class Color
    {
    
        //Propriedades!
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }


        //Construtor
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;    
            Blue = blue;
        }

        //readonly (read only)
        public byte Grey => (byte)((Red + Green + Blue) / 3);
    }


    public class Sphere
            {
            public Color Color { get; } 
            public int Radius { get; private set; } 
            private int ThrowTimes;

            //Propriedades da Sphere
             public Sphere(Color color, int radius)
            {
                Color = color;
                Radius = radius;
                ThrowTimes = 0;
            }

            public void Pop()
            {
                Radius = 0;
            }

            public void Throw()
            {
                if (Radius > 0)
                {
                    ThrowTimes++;
                }
            }

            public int GetTimesThrown() => ThrowTimes;
            }

}
