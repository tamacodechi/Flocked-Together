using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Surface : MonoBehaviour
{
    public enum SurfaceType
    {
        branch,
        water,
    }

    public SurfaceType surfaceType;
    public bool isHighestBranch = false;
    public bool isSingleBranch = false;
    public List<Bird> birdsOnSurface;

    // If a bird touches a surface (A branch or water), it will be added to our 'birdsOnSurface' list,
    // this will allow to count how many birds are there in a given surface, and access their properties if needed
    // (i.e: check if any of the birds present are small sized)
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            birdsOnSurface.Add(collision.gameObject.GetComponent<Bird>());
        }
    }

    // If a bird leaves the surface, remove it from the list
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            birdsOnSurface.Remove(collision.gameObject.GetComponent<Bird>());
        }
    }
}
