using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChipMenu : MonoBehaviour
{
    private int Letter = 0;
    public GameObject debugMenu;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.D) && Letter == 0)
            {
                Letter = 1;
            }
            else if (Input.GetKeyDown(KeyCode.E) && Letter == 1)
            {
                Letter = 2;
            }
            else if (Input.GetKeyDown(KeyCode.B) && Letter == 2)
            {
                Letter = 3;
            }
            else if (Input.GetKeyDown(KeyCode.U) && Letter == 3)
            {
                Letter = 4;
            }
            else if (Input.GetKeyDown(KeyCode.G) && Letter == 4)
            {
                debugMenu.SetActive(true);
                Letter = 0;
            }
            else
            {
                Letter = 0;
            }
        }
    }
}
