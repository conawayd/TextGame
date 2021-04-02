using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;
    private bool isPaused = false;

    public void Pause()
    {
        menu.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Unpause()
    {
        menu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }

    public void SaveName()
    {
        PlayerPrefs.SetString("nameSave", PlayerPrefs.GetString("name"));
    }

    public void LoadName()
    {
        PlayerPrefs.SetString("name", PlayerPrefs.GetString("nameSave"));
        SceneManager.LoadScene(1);
    }
}
