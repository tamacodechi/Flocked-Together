using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toucan
{
    // Likes: Being next to ONE other bird
    // Dislikes: Being too high up
    public static bool getIsHappy(Bird bird)
    {
        if (!bird.surface)
            return false;

        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if ((!surface.isHighestBranch || surface.isSingleBranch) && birdsOnSurface.Count == 2)
            return true;

        return false;
    }

    public static string getName()
    {
        return "Plate-billed Mountain Toucan";
    }

    public static string getDescription()
    {
        return "This toucan is a plate-billed mountain toucan. It is a colorful bird found in the cloud forests of the Andes.\n\nIt has a striking yellow chest, bright blue belly, and a unique beak with a bold yellow plate near the top. This toucan loves eating fruit and helps spread seeds through the forest.\n\nWith its loud calls and eye-catching appearance, it's both beautiful and important for the health of its mountain habitat!";
    }

    public static string[] getLikes = new string[] { "Being next to one other bird" };
    public static string[] getDislikes = new string[] { "Being too high up" };
    public static string[] getTraits = new string[] { };
}
