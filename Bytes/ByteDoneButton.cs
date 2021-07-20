using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ByteDoneButton : MonoBehaviour
{
    public Button doneButton;
    public GameObject tooltip;

    void Start()
    {
        doneButton.onClick.AddListener(doneFunction);

        if (info.controllerinput == 1)
        {
            tooltip.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            doneFunction();
        }
    }

    void doneFunction()
    {
        SceneManager.LoadScene(scenes.Loading);
    }
}
