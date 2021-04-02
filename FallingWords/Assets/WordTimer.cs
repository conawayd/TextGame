using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;

    public float wordDelay;
    private float nextWordTime = 0f;

    private void Start()
    {
        wordDelay = PlayerPrefs.GetFloat("wordDelay");
        PlayerPrefs.SetFloat("score", wordDelay);
    }

    private void Update()
    {
        if (Time.time >= nextWordTime)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
            PlayerPrefs.SetFloat("score", wordDelay);
        }
    }

    public void SaveWordDelay()
    {
        PlayerPrefs.SetFloat("wordDelaySave", wordDelay);
        Debug.Log(PlayerPrefs.GetFloat("wordDelaySave"));
    }

    public void LoadWordDelay()
    {
        PlayerPrefs.SetFloat("wordDelay", PlayerPrefs.GetFloat("wordDelaySave"));
        wordDelay = PlayerPrefs.GetFloat("wordDelay");
        PlayerPrefs.SetFloat("score", wordDelay);
        Debug.Log(PlayerPrefs.GetFloat("wordDelay"));
    }
}
