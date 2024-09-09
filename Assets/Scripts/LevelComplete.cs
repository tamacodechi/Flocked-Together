using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelSelectCanvas;
    public AudioSource levelCompleteJingle;
    private PauseMenu pauseMenu;

    // Store the pauseMenu component so the game can be stopped when the user beats a level
    void Start()
    {
        pauseMenu = GameObject.Find("Pause Menu").GetComponent<PauseMenu>();
    }

    // Play a jingle, stop time, and render the 'Level Complete' screen
    public void completeLevel()
    {
        levelCompleteJingle.PlayOneShot(levelCompleteJingle.clip);
        Time.timeScale = 0;
        pauseMenu.isPauseAllowed = false;
        levelSelectCanvas.SetActive(true);
    }

    // Advance to Current Level + 1
    public void goToNextLevel()
    {
        pauseMenu.isPauseAllowed = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Return to 'Level Select' scene
    public void goToLevelSelect()
    {
        pauseMenu.isPauseAllowed = true;
        SceneManager.LoadScene("LevelSelect");
    }
}
