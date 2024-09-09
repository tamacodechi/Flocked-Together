using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorBird
{
    // Likes: Being up high
    // Dislikes: Noisy birds
    public static bool getIsHappy(Bird bird)
    {
        if (!bird.surface)
            return false;

        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if (surface.isHighestBranch || surface.isSingleBranch)
        {
            var anyBirdIsNoisy = false;

            foreach (var birdOnSurface in birdsOnSurface)
            {
                if (birdOnSurface != bird && birdOnSurface.isNoisy)
                {
                    anyBirdIsNoisy = true;
                }
            }

            return !anyBirdIsNoisy;
        }

        return false;
    }

    public static string getName()
    {
        return "Fork-tailed flycatcher";
    }

    public static string getDescription()
    {
        return "The fork-tailed flycatcher is a sleek bird known for its long, forked tail and sharp aerial skills. Found across Central and South America in grasslands and open fields, it catches insects mid-flight, darting through the air with incredible precision.\n\nIts long tail helps with balance and agility, making it a master of the skies. Interestingly, its name comes from that distinct forked tail, which is usually longer than the bird's body.\n\nIn Spanish they are called the 'tijereta sabanera' meaning the 'scissors of the savanna'!";
    }

    public static string[] getLikes = new string[] { "Being up high" };
    public static string[] getDislikes = new string[] { "Noisy birds" };
    public static string[] getTraits = new string[] { };
}
