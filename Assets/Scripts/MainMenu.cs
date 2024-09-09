using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public void goToBirdtionary()
    {
        SceneManager.LoadScene("Birdtionary");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
