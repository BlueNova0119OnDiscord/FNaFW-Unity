using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueLoading : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            SceneManager.LoadScene(scenes.Overworld1);
            PlayerPrefs.SetFloat($"started", 1);
        }
    }
}
