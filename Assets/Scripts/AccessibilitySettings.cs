using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AccessibilitySettings : MonoBehaviour
{
    public UnityEngine.UI.Slider outlineSlider;
    public UnityEngine.UI.Image outlineSliderHandle;
    public GameObject birdOutline;
    public Toggle birdOutlineToggle;
    public Toggle dyslexiaFriendlyFontToggle;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("useDyslexiaFriendlyFont"))
        {
            PlayerPrefs.SetInt("useDyslexiaFriendlyFont", 0);
        }
        else
        {
            dyslexiaFriendlyFontToggle.isOn =
                PlayerPrefs.GetInt("useDyslexiaFriendlyFont") == 1 ? true : false;
        }

        if (!PlayerPrefs.HasKey("enableBirdOutline"))
        {
            PlayerPrefs.SetInt("enableBirdOutline", 0);
            PlayerPrefs.SetFloat("birdOutlineColor", 0);

            outlineSliderHandle.color = Color.HSVToRGB(outlineSlider.value, 1, 1);
            birdOutline.GetComponent<Image>().color = outlineSliderHandle.color;
        }
        else
        {
            var isOutlineEnabled = PlayerPrefs.GetInt("enableBirdOutline");

            outlineSliderHandle.color = Color.HSVToRGB(
                PlayerPrefs.GetFloat("birdOutlineColor"),
                1,
                1
            );

            outlineSlider.value = PlayerPrefs.GetFloat("birdOutlineColor");
            birdOutline.GetComponent<Image>().color = outlineSliderHandle.color;
            birdOutlineToggle.isOn = isOutlineEnabled == 1 ? true : false;
        }

        outlineSlider.onValueChanged.AddListener(
            delegate
            {
                ValueChangeCheck();
            }
        );
    }

    public void ValueChangeCheck()
    {
        outlineSliderHandle.color = Color.HSVToRGB(outlineSlider.value, 1, 1);
        birdOutline.GetComponent<Image>().color = outlineSliderHandle.color;
        PlayerPrefs.SetFloat("birdOutlineColor", outlineSlider.value);
    }

    public void toggleBirdOutline()
    {
        PlayerPrefs.SetInt("enableBirdOutline", birdOutlineToggle.isOn ? 1 : 0);
    }

    public void toggleDyslexiaFriendlyFont()
    {
        PlayerPrefs.SetInt("useDyslexiaFriendlyFont", dyslexiaFriendlyFontToggle.isOn ? 1 : 0);

        if (dyslexiaFriendlyFontToggle.isOn)
        {
            var textComponents = Component.FindObjectsOfType<Text>(true);

            foreach (var component in textComponents)
            {
                Font dyslexiaFriendlyFont = Resources.Load("Lexend-VariableFont_wght") as Font;
                component.font = dyslexiaFriendlyFont;
            }
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
