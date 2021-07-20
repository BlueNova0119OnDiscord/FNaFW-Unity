using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerSupport : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            info.controllerinput = 1;
            SceneManager.LoadScene(scenes.FileSetup);
        }
    }
}
