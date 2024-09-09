using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChileanFlamingo
{
    // Likes: Small birds
    // Dislikes: Being alone
    public static bool getIsHappy(Bird bird)
    {
        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if (birdsOnSurface.Count > 1)
        {
            var areAllBirdsOnSurfaceSmall = true;

            foreach (var birdOnSurface in birdsOnSurface)
            {
                if (birdOnSurface != bird && birdOnSurface.size.ToString() != "small")
                {
                    areAllBirdsOnSurfaceSmall = false;
                }
            }

            return areAllBirdsOnSurfaceSmall;
        }

        return false;
    }

    public static string getName()
    {
        return "Chilean Flamingo";
    }

    public static string getDescription()
    {
        return "The Chilean flamingo is a beautiful bird with pink feathers, long necks, and bright orange beaks. They live in large colonies in South American wetlands, where they dance and feed on tiny shrimp and algae. Their unique beaks help them filter food from the water, and they build mud nests to raise their chicks.\n\nThese graceful birds add color to their habitats and play a key role in keeping their ecosystems healthy!";
    }

    public static string[] getLikes = new string[] { "Small Birds" };
    public static string[] getDislikes = new string[] { "Being alone" };
    public static string[] getTraits = new string[] { };
}
