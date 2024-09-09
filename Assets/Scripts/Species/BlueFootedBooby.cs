using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFootedBooby
{
    // Likes: Being next to ONE other bird
    // Likes: A clear sky above him to do “sky pointing”
    public static bool getIsHappy(Bird bird)
    {
        if (!bird.surface)
            return false;

        var surface = bird.surface.GetComponent<Surface>();

        if (surface.birdsOnSurface.Count == 2)
            return true;

        return false;
    }

    public static string getName()
    {
        return "Blue-footed Booby";
    }

    public static string getDescription()
    {
        return "The blue-footed booby is a distinctive seabird famous for its bright blue feet and striking appearance.\n\nFound along the coasts of the Galápagos Islands and parts of the western coast of South America, it is known for its impressive courtship dance, where it shows off its vibrant feet to attract a mate.\n\nThis bird is a skilled diver, plunging into the ocean to catch fish with precision.";
    }

    public static string[] getLikes = new string[]
    {
        "Being next to one other bird",
        "A clear sky above him"
    };
    public static string[] getDislikes = new string[] { };
    public static string[] getTraits = new string[] { };
}
