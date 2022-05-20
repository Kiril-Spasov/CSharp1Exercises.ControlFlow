using System;

namespace exercise03
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter width of image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pls enter heigth of image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine(orientation);

        }

    }
}
