using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparklingVioletear
{
    // Trait: Noisy
    // Dislikes: Being near other birds
    public static bool getIsHappy(Bird bird)
    {
        if (!bird.surface)
            return false;

        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if (birdsOnSurface.Count == 1)
            return true;

        return false;
    }

    public static string getName()
    {
        return "Sparkling Violetear";
    }

    public static string getDescription()
    {
        return "The sparkling violetear is a dazzling hummingbird found in the Andes, known for its vibrant green and blue feathers that shimmer in the sunlight.\n\nWith a long, curved bill, it feeds on nectar from flowers and can often be seen fiercely defending its territory. These energetic birds are amazing fliers, zipping through the air and hovering with ease.\n\nTheir name comes from the striking violet patches on their ears, making them as flashy as they are fast!";
    }

    public static string[] getLikes = new string[] { };
    public static string[] getDislikes = new string[] { "Being near other birds" };
    public static string[] getTraits = new string[] { "Noisy" };
}
