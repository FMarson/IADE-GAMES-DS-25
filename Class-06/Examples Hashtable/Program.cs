using System;
using System.Collections;
using System.IO; 
using System.Text;

class HastableExample {
    enum Color {
        Red,
        Green,
        Blue,
        Yellow,
        Orange
    }
    enum Size {
        Small,
        Medium,
        Large
    }

    static public void Main()
    {
        Hashtable htSize, htColors;

        htColors = new Hashtable();
        htSize = new Hashtable();

        htColors.Add(Color.Red, "The color of fire");
        htColors.Add(Color.Green, "The color of grass");
        htColors.Add(Color.Blue, "The color of the sky");

        htSize.Add(Size.Small, "A small size");
        htSize.Add(Size.Medium, "A medium size");
        htSize.Add(Size.Large, "A large size");

        foreach (Color color in htColors.Keys)
        {
            Console.WriteLine("{0}: {1}", color, htColors[color]);
        }

        Console.WriteLine("Number of colors: " + htColors.Count);
        htColors.Remove(Color.Red);
        Console.WriteLine("Number of colors after removing red: " + htColors.Count);
        htColors.Clear();
        Console.WriteLine("Number of colors after clearing: " + htColors.Count);
        
    }
}