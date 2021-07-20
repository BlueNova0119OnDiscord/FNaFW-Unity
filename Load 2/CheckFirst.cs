using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckFirst : MonoBehaviour
{
    void Start()
    {
        if (info.first == 1f)
        {
            SceneManager.LoadScene(scenes.Title);
        }
        else
        {
            SceneManager.LoadScene(scenes.IntroCutscene);
        }
    }
}
