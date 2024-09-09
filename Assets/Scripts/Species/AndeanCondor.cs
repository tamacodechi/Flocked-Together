using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndeanCondor
{
    // Likes: Being above other birds
    // Likes: Being alone
    public static bool getIsHappy(Bird bird)
    {
        // If the bird is not on either a branch or water, the rest of the function will be skipped
        if (!bird.surface)
            return false;

        // Otherwise store the surface that the Bird is standing on
        var surface = bird.surface.GetComponent<Surface>();

        // In this case, if our Condor is on the highest branch available (or the only one available, if that were the case)
        // and they are the only bird on it, it will return 'True', meaning it is happy
        if (
            (surface.isHighestBranch || surface.isSingleBranch)
            && surface.birdsOnSurface.Count == 1
        )
            return true;

        // Otherwise return false, meaning unhappy
        return false;
    }

    public Sprite birdSprite;

    public static string getName()
    {
        return "Andean Condor";
    }

    public static string getDescription()
    {
        return "The Andean condor is a spectacular bird known for its enormous wingspan, which can stretch up to 3 meters.\n\nFound in the Andes Mountains, it glides on thermal updrafts while searching for carrion to feed on. With its dark feathers and striking white wing tips, it stands out as one of the world's largest flying birds.\n\nThe name 'condor' comes from the Quechua word for 'vulture'.";
    }

    public static string[] getLikes = new string[] { "Being above other birds", "Being alone" };
    public static string[] getDislikes = new string[] { };
    public static string[] getTraits = new string[] { };
}
