using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoneButton : MonoBehaviour
{
    public Button doneButton;

    void Start()
    {
        doneButton.onClick.AddListener(doneFunction);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton7) && info.controllerinput == 1)
        {
            doneFunction();
        }
    }

    void doneFunction()
    {
        fnafw1.loadCineValue();
        if (fnafw1.cine == 1)
        {
            SceneManager.LoadScene(scenes.Fredbear);
        }
        else
        {
            SceneManager.LoadScene(scenes.Loading);
        }
    }
}
