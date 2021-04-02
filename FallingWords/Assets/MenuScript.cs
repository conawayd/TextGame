using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public InputField inputField_name;
    public Slider textSpeed_slider;

    void Start()
    {
        PlayerPrefs.SetString("name", "");
        PlayerPrefs.SetFloat("textSpeed", 1);
        PlayerPrefs.SetFloat("wordDelay", 1.5f);
    }

    public void SetName()
    {
        PlayerPrefs.SetString("name", inputField_name.text);
    }

    public void SetTextSpeed()
    {
        PlayerPrefs.SetFloat("textSpeed", textSpeed_slider.value);
    }
}
