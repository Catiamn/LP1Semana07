using System;

namespace BetterColorSpheres
{
    public class Program
    {
        
        //Print :C
        public static void Main()
        {
            const byte MaxRed = 255, MaxGreen = 255, MaxBlue = 255;
            const byte NoColor = 0;
            
            //red (255,0,0) green (0,255,0) blue (0,0,255)
            Color redColor = new Color(MaxRed, NoColor, NoColor);
            Color greenColor = new Color(NoColor, MaxGreen, NoColor);
            Color blueColor = new Color(NoColor, NoColor, MaxBlue);
            
            //3 esferas (cor, raio)
            Sphere sphere1 = new Sphere(redColor, 10);
            Sphere sphere3 = new Sphere(greenColor, 12);
            Sphere sphere2 = new Sphere(blueColor, 15);
            //atirar (throw) da primeira 3 vezes
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            //pop da segunda
            sphere2.Pop();
            //atirar (throw) da terceira 1 vez
            sphere3.Throw();


            //actual print 
            Console.WriteLine("Esfera 1:");
            Console.WriteLine($"Cor: ({sphere1.Color.Red}, {sphere1.Color.Green}, {sphere1.Color.Blue})");
            Console.WriteLine($"Raio: {sphere1.Radius}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Tom de Cinza: {sphere1.Color.Grey}");
            Console.WriteLine();

            Console.WriteLine("Esfera 2:");
            Console.WriteLine($"Cor: ({sphere2.Color.Red}, {sphere2.Color.Green}, {sphere2.Color.Blue})");
            Console.WriteLine($"Raio: {sphere2.Radius}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere2.GetTimesThrown()}");
            Console.WriteLine($"Tom de Cinza: {sphere2.Color.Grey}");
            Console.WriteLine();

            Console.WriteLine("Esfera 3:");
            Console.WriteLine($"Cor: ({sphere3.Color.Red}, {sphere3.Color.Green}, {sphere3.Color.Blue})");
            Console.WriteLine($"Raio: {sphere3.Radius}");
            Console.WriteLine($"Número de vezes que foi atirada: {sphere3.GetTimesThrown()}");
            Console.WriteLine($"Tom de Cinza: {sphere3.Color.Grey}");
        }
    }
}
