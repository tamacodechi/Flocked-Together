using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunki
{
    // Trait: Attracts other birds
    // Dislikes: Large birds
    public static bool getIsHappy(Bird bird)
    {
        if (!bird.surface)
            return false;

        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if (birdsOnSurface.Count >= 1)
        {
            var areAnyBirdsOnSurfaceLarge = false;

            foreach (var birdOnSurface in birdsOnSurface)
            {
                if (birdOnSurface != bird && birdOnSurface.size.ToString() == "large")
                {
                    areAnyBirdsOnSurfaceLarge = true;
                }
            }

            return !areAnyBirdsOnSurfaceLarge;
        }

        return false;
    }

    public static string getName()
    {
        return "Andean Cock-of-the-Rock";
    }

    public static string getDescription()
    {
        return "The Tunki, formally known as the Andean cock-of-the-rock is a striking bird renowned for its vibrant orange plumage and unique, rounded crest.\n\nNative to the cloud forests of the Andes, it's famous for its dramatic courtship displays, where males perform elaborate dances to attract mates.\n\nAs the national bird of Peru, it holds a special place in the country's culture, making it a popular choice for exotic pet enthusiasts";
    }

    public static string[] getLikes = new string[] { };
    public static string[] getDislikes = new string[] { "Large birds" };
    public static string[] getTraits = new string[] { "Attracts other birds" };
}
