using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal static class GlazerApp
    {
        private static double Width { get; set; }
        private static double Height { get; set; }
        private static double WoodLength { get; set; }
        private static double GlassArea { get; set; }
        private static string WidthString { get; set; }
        private static string HeightString { get; set; }


        public static void RunExample()
        {
            // Ask for WidthString Value
            Console.WriteLine("Please enter the width: ");
            WidthString = Console.ReadLine();

            // Ask for HidthString Value
            Console.WriteLine("Please enter the height: ");
            HeightString = Console.ReadLine();


            // Parse into respective values
            Width = double.Parse(WidthString);

            Height = double.Parse(HeightString);


            // Do Calculations
            WoodLength = 2 * (Width + Height) * 3.25;

            GlassArea = 2 * (Width * Height);


            // Display to user
            Console.WriteLine($"The length of the wood is {WoodLength} feet");
            Console.WriteLine($"The area of the glass is {GlassArea} square metres");
        }
    }
}
