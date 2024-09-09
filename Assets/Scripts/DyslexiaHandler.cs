using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DyslexiaHandler : MonoBehaviour
{
    private static DyslexiaHandler instance = null;

    // The object is made non-destructible so it persists between scenes,
    // this way it will always continue to update every Text component it finds
    // with the dyslexia friendly font
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
        Destroy(this.gameObject);
    }

    // When a new scene is loaded, every text component is iterated through and its default font is replaced.
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (PlayerPrefs.GetInt("useDyslexiaFriendlyFont") == 1)
        {
            var textComponents = Component.FindObjectsOfType<Text>(true);

            foreach (var component in textComponents)
            {
                Font dyslexiaFriendlyFont = Resources.Load("Lexend-VariableFont_wght") as Font;
                component.font = dyslexiaFriendlyFont;
            }
        }
    }
}
