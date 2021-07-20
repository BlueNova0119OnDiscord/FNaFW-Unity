using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChipsButton : MonoBehaviour
{
    public Button chipsButton;
    public Transform Character;

    void Start()
    {
        chipsButton.onClick.AddListener(doneFunction);
    }

    void Update()
    {
        if (Input.GetAxis("XboxDPadVertical") < 0 && info.controllerinput == 1)
        {
            doneFunction();
        }
    }

    void doneFunction()
    {
        fnafw1.saveXValue(Character.transform.localPosition.x);
        fnafw1.saveYValue(Character.transform.localPosition.y);
        fnafw1.newstart = true;
        SceneManager.LoadScene(scenes.Chips);
    }
}
