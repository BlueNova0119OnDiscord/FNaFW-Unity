using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    public GameObject UI;
    public GameObject ContUI;

    void Start()
    {
        if (info.controllerinput == 0)
        {
            UI.SetActive(true);
        }
        else if (info.controllerinput == 1)
        {
            ContUI.SetActive(true);
        }

        fnafw1.saveStartedValue(1);
    }
}
