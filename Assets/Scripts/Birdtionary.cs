using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Birdtionary : MonoBehaviour
{
    public GameObject birdtionaryGrid;
    public GameObject birdtionaryEntry;
    public GameObject likesDislikesTraitsPrefab;
    public Transform likesDislikesTraitsContainer;
    public Image birdImage;
    public Text birdNameText;
    public Text birdDescriptionText;

    // Opens the page of the Birdtionary of a given species,
    // and fills the fields with its information (Name, Description, Likes/Dislikes/Traits and their picture)
    public void openBirdEntry(string species)
    {
        switch (species)
        {
            case "Andean Condor":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Andean Condor");
                birdNameText.text = AndeanCondor.getName();
                birdDescriptionText.text = AndeanCondor.getDescription();

                renderLikesDislikesAndTraits(
                    AndeanCondor.getLikes,
                    AndeanCondor.getDislikes,
                    AndeanCondor.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Blue-footed Booby":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Blue-Footed Booby");
                birdNameText.text = BlueFootedBooby.getName();
                birdDescriptionText.text = BlueFootedBooby.getDescription();

                renderLikesDislikesAndTraits(
                    BlueFootedBooby.getLikes,
                    BlueFootedBooby.getDislikes,
                    BlueFootedBooby.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Chilean Flamingo":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Chilean Flamingo");
                birdNameText.text = ChileanFlamingo.getName();
                birdDescriptionText.text = ChileanFlamingo.getDescription();

                renderLikesDislikesAndTraits(
                    ChileanFlamingo.getLikes,
                    ChileanFlamingo.getDislikes,
                    ChileanFlamingo.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Least Sandpiper":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Least Sandpiper");
                birdNameText.text = LeastSandpiper.getName();
                birdDescriptionText.text = LeastSandpiper.getDescription();

                renderLikesDislikesAndTraits(
                    LeastSandpiper.getLikes,
                    LeastSandpiper.getDislikes,
                    LeastSandpiper.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Roseate Spoonbill":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Roseate Spoonbill");
                birdNameText.text = RoseateSpoonbill.getName();
                birdDescriptionText.text = RoseateSpoonbill.getDescription();

                renderLikesDislikesAndTraits(
                    RoseateSpoonbill.getLikes,
                    RoseateSpoonbill.getDislikes,
                    RoseateSpoonbill.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Scissor Bird":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Scissor Bird");
                birdNameText.text = ScissorBird.getName();
                birdDescriptionText.text = ScissorBird.getDescription();

                renderLikesDislikesAndTraits(
                    ScissorBird.getLikes,
                    ScissorBird.getDislikes,
                    ScissorBird.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Sparkling Violetear":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Sparkled Violetear");
                birdNameText.text = SparklingVioletear.getName();
                birdDescriptionText.text = SparklingVioletear.getDescription();

                renderLikesDislikesAndTraits(
                    SparklingVioletear.getLikes,
                    SparklingVioletear.getDislikes,
                    SparklingVioletear.getTraits
                );

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Toucan":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Toucan");
                birdNameText.text = Toucan.getName();
                birdDescriptionText.text = Toucan.getDescription();

                renderLikesDislikesAndTraits(Toucan.getLikes, Toucan.getDislikes, Toucan.getTraits);

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
            case "Tunki":
                birdImage.sprite = Resources.Load<Sprite>("Birds/Tunki");
                birdNameText.text = Tunki.getName();
                birdDescriptionText.text = Tunki.getDescription();

                renderLikesDislikesAndTraits(Tunki.getLikes, Tunki.getDislikes, Tunki.getTraits);

                birdtionaryGrid.SetActive(false);
                birdtionaryEntry.SetActive(true);
                break;
        }
    }

    // Instantiates a 'likesDislikesTraits' prefab one after the other in a vertical list
    // so the user can easily see the species gameplay-relevant information (i.e: If a bird likes to have a branch all for themselves)
    public void renderLikesDislikesAndTraits(string[] likes, string[] dislikes, string[] traits)
    {
        foreach (var like in likes)
        {
            var likesPrefab = Instantiate(likesDislikesTraitsPrefab, likesDislikesTraitsContainer);

            likesPrefab.GetComponentInChildren<Text>().text = like;
            likesPrefab.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("UI/Likes");
        }

        foreach (var dislike in dislikes)
        {
            var likesPrefab = Instantiate(likesDislikesTraitsPrefab, likesDislikesTraitsContainer);

            likesPrefab.GetComponentInChildren<Text>().text = dislike;
            likesPrefab.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(
                "UI/Dislikes"
            );
        }

        foreach (var trait in traits)
        {
            var likesPrefab = Instantiate(likesDislikesTraitsPrefab, likesDislikesTraitsContainer);

            likesPrefab.GetComponentInChildren<Text>().text = trait;
            likesPrefab.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(
                "UI/Traits"
            );
        }
    }

    //  Exit the extended-information page and return to the Birdtionary list
    public void returnToBirdtionaryList()
    {
        foreach (Transform child in likesDislikesTraitsContainer.transform)
        {
            Destroy(child.gameObject);
        }

        birdtionaryGrid.SetActive(true);
        birdtionaryEntry.SetActive(false);
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
