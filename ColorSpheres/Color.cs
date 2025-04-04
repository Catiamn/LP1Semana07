namespace ColorSpheres
{
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

            public byte Grey => (byte)((Red + Green + Blue) / 3);
        }
            
}