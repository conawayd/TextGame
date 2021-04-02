using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameAndScore : MonoBehaviour
{
    public Text name_text;
    public Text score_text;

    void Start()
    {
        name_text.text = PlayerPrefs.GetString("name");
    }

    void Update()
    {
        score_text.text = PlayerPrefs.GetFloat("score").ToString();
    }
}
