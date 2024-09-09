using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    bool isGamePaused = false;
    public bool isPauseAllowed = true;
    public GameObject pauseMenuCanvas;

    void Awake()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!isPauseAllowed)
            return;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                isGamePaused = false;
                pauseMenuCanvas.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                isGamePaused = true;
                pauseMenuCanvas.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void restart()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName);
    }

    public void toLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void exitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
