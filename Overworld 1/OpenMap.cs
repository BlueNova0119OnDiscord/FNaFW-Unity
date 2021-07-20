using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour
{
    public GameObject Minimap;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab) && info.controllerinput == 0)
        {
            Minimap.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.JoystickButton6) && info.controllerinput == 1)
        {
            Minimap.SetActive(true);
        }
        else
        {
            Minimap.SetActive(false);
        }
    }
}
