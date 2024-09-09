using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeastSandpiper
{
    // Likes: Being on water
    // Dislikes: Being alone
    public static bool getIsHappy(Bird bird)
    {
        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if (surface.surfaceType.ToString() == "water" && birdsOnSurface.Count > 1)
        {
            return true;
        }

        return false;
    }

    public static string getName()
    {
        return "Least Sandpiper";
    }

    public static string getDescription()
    {
        return "The least sandpiper is a small, agile shorebird known for its delicate size and subtle brown and white plumage.\n\nFound along the coastlines and mudflats of South America, it migrates between its breeding grounds in the northern parts of the continent and its wintering habitats further south.\n\nThis tiny bird is an expert forager, using its slender bill to probe the sand for tiny invertebrates.";
    }

    public static string[] getLikes = new string[] { "Being on water" };
    public static string[] getDislikes = new string[] { "Being alone" };
    public static string[] getTraits = new string[] { };
}
