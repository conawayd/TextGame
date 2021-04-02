using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAsJSON : MonoBehaviour
{
    public void SaveAsJson()
    {
        PlayerData playerData = new PlayerData();
        playerData.wordDelay = PlayerPrefs.GetFloat("wordDelaySave");
        playerData.name = PlayerPrefs.GetString("nameSave");

        string json = JsonUtility.ToJson(playerData);
        Debug.Log(json);
    }

    class PlayerData
    {
        public float wordDelay;
        public string name;
    }
}