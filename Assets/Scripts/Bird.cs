using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public enum Species
    {
        scissorBird,
        toucan,
        andeanCondor,
        chileanFlamingo,
        blueFootedBooby,
        sparklingVioletEar,
        tunki,
        roseateSpoonbill,
        leastSandpiper
    }

    public enum Size
    {
        small,
        medium,
        large,
    }

    [SerializeField]
    public Species species;
    public Size size;
    public GameObject surface;
    public GameObject outline;
    public bool isHappy;
    public bool isNoisy;
    private bool isLevelComplete = false;

    // On start, check if the user has enabled the Bird Outline setting
    void Start()
    {
        var renderBirdOutline = PlayerPrefs.GetInt("enableBirdOutline");

        if (renderBirdOutline == 1)
        {
            outline.GetComponent<Image>().color = Color.HSVToRGB(
                PlayerPrefs.GetFloat("birdOutlineColor"),
                1,
                1
            );
            outline.SetActive(true);
        }
    }

    // Check every frame that all your birds are happy
    void Update()
    {
        checkAreAllHappy();
    }

    // If a bird collides with a branch or water, check if their happiness conditions
    // are fulfilled
    void OnCollisionStay2D(Collision2D collision)
    {
        var collisionTag = collision.gameObject.tag;

        if (collisionTag == "Branch" || collisionTag == "Water")
        {
            this.surface = collision.gameObject;
            this.isHappy = this.checkIsHappy();
        }
    }

    // If a bird leaves their branch or water, reset their standing surface to None
    void OnCollisionExit2D(Collision2D collision)
    {
        var collisionTag = collision.gameObject.tag;

        if (collisionTag == "Branch" || collisionTag == "Water")
        {
            this.surface = null;
        }
    }

    // Call the 'getIsHappy' function of the corresponding bird specie
    bool checkIsHappy()
    {
        switch (this.species)
        {
            case Species.scissorBird:
                return ScissorBird.getIsHappy(this);
            case Species.toucan:
                return Toucan.getIsHappy(this);
            case Species.andeanCondor:
                return AndeanCondor.getIsHappy(this);
            case Species.chileanFlamingo:
                return ChileanFlamingo.getIsHappy(this);
            case Species.blueFootedBooby:
                return BlueFootedBooby.getIsHappy(this);
            case Species.sparklingVioletEar:
                return SparklingVioletear.getIsHappy(this);
            case Species.tunki:
                return Tunki.getIsHappy(this);
            case Species.roseateSpoonbill:
                return RoseateSpoonbill.getIsHappy(this);
            case Species.leastSandpiper:
                return LeastSandpiper.getIsHappy(this);
        }

        return false;
    }

    // Iterate through each bird, if their 'isHappy' flag is true, the level is considered complete
    void checkAreAllHappy()
    {
        if (!isLevelComplete)
        {
            GameObject[] birds = GameObject.FindGameObjectsWithTag("Bird");
            var areAllHappy = true;

            foreach (var bird in birds)
            {
                var birdComponent = bird.GetComponent<Bird>();

                if (!birdComponent.isHappy)
                    areAllHappy = false;
            }

            if (areAllHappy)
            {
                GameObject.Find("Level Complete").GetComponent<LevelComplete>().completeLevel();
                isLevelComplete = true;
            }
        }
    }
}
