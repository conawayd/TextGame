using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;

    void Start()
    {
        fallSpeed = fallSpeed * PlayerPrefs.GetFloat("textSpeed");
    }

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

    public void SaveFallspeed()
    {
        PlayerPrefs.SetFloat("fallSpeedSave", fallSpeed);
    }

    public void LoadFallSpeed()
    {
        //PlayerPrefs.SetFloat("textSpeed", PlayerPrefs.GetFloat("fallSpeedSave"));
        //fallSpeed = fallSpeed * PlayerPrefs.GetFloat("textSpeed");
        // Doesn't work yet?
    }
}
