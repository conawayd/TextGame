using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"lay", "pig", "era", "hiccup", "academy", "dirty",
    "curve", "overcharge", "boy", "ambiguous", "road", "cupboard", "breed", "budget", "victory"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
