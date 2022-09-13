using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal static class GlazerApp
    {
        private static string WidthString { get; set; }
        private static string HeightString { get; set; }
        private static double Width => double.Parse(WidthString);
        private static double Height => double.Parse(HeightString);
        private static double WoodLength => 2 * (Width + Height) * 3.25;
        private static double GlassArea => 2 * (Width * Height); 


        public static void RunExample()
        {
            // Ask for WidthString Value
            Console.WriteLine("Please enter the width: ");
            WidthString = Console.ReadLine();

            // Ask for HeightString Value
            Console.WriteLine("Please enter the height: ");
            HeightString = Console.ReadLine();

            // Display to user
            Console.WriteLine($"The length of the wood is {WoodLength} feet");
            Console.WriteLine($"The area of the glass is {GlassArea} square metres");
        }
    }
}
