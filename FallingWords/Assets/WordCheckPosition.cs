using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordCheckPosition : MonoBehaviour
{
    public GameObject wordObject;

    void Update()
    {
        if (wordObject.transform.position.y < -5)
        {
            SceneManager.LoadScene(2);
        }
    }
}
