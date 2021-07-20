using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropButton : MonoBehaviour
{
    public DropPlunger plunger;
    public GameObject contIcon;

    void Start()
    {
        if (info.controllerinput == 1)
        {
            contIcon.SetActive(true);
        }

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(clicked);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton2) && info.controllerinput == 1)
        {
            clicked();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            clicked();
        }
    }

    void clicked()
    {
        plunger.Drop();
    }
}
