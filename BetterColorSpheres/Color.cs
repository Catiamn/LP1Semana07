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
}