using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseateSpoonbill
{
    // Dislikes: Chilean Flamingos
    // Trait: Attracts other birds
    public static bool getIsHappy(Bird bird)
    {
        if (!bird.surface)
            return false;

        var surface = bird.surface.GetComponent<Surface>();
        var birdsOnSurface = surface.birdsOnSurface;

        if (birdsOnSurface.Count >= 1)
        {
            var isAnyBirdFlamingo = false;

            foreach (var birdOnSurface in birdsOnSurface)
            {
                if (birdOnSurface != bird && birdOnSurface.species.ToString() == "chileanFlamingo")
                {
                    isAnyBirdFlamingo = true;
                }
            }

            return !isAnyBirdFlamingo;
        }

        return false;
    }

    public static string getName()
    {
        return "Roseate Spoonbill";
    }

    public static string getDescription()
    {
        return "The roseate spoonbill is a striking wading bird known for its bright pink feathers and unique spoon-shaped bill.\n\nFound in wetlands, lagoons, and mangroves across coastal regions of South America, particularly in countries like Brazil, Venezuela, and Argentina, it uses its wide bill to sweep through the water, catching small fish and crustaceans.\n\nThese birds stand out with their graceful wading and bold colors, adding beauty to their marshy habitats while playing an important role in keeping ecosystems balanced.";
    }

    public static string[] getLikes = new string[] { "Being alone" };
    public static string[] getDislikes = new string[] { "Chilean Flamingos" };
    public static string[] getTraits = new string[] { "Attracts other birds" };
}
