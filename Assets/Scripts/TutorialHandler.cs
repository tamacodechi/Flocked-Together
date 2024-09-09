using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHandler : MonoBehaviour
{
    public GameObject tutorialCanvas;

    void Start()
    {
        if (!PlayerPrefs.HasKey("hasSeenTutorial") || PlayerPrefs.GetInt("hasSeenTutorial") == 0)
        {
            PlayerPrefs.SetInt("hasSeenTutorial", 0);

            tutorialCanvas.SetActive(true);
        }
    }

    public void closeTutorial()
    {
        PlayerPrefs.SetInt("hasSeenTutorial", 1);
    }
}
