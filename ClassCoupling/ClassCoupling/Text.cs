using System;

namespace ClassCoupling
{
    // Derives from presenation objects
    // note in C# a class can only have one parent
    public class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to: " + url);
        }
    }

}
