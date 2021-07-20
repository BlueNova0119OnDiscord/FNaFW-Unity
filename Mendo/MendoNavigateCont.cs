using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MendoNavigateCont : MonoBehaviour
{
    public GameObject[] Selections;
    public int currentSelection;
    private bool moved;

    void Start()
    {
        if (info.controllerinput != 1)
        {
            gameObject.GetComponent<MendoNavigateCont>().enabled = false;
        }
        else
        {
            currentSelection = 0;
            Selections[currentSelection].GetComponent<MendoBuy>().Hover();
        }
    }

    void Update()
    {
        if (Input.GetAxisRaw("XboxDPadHorizontal") > 0 && currentSelection < 2 && moved == false)
        {
            moved = true;
            Selections[0].GetComponent<MendoBuy>().ExitHover();
            Selections[1].GetComponent<MendoBuy>().ExitHover();
            Selections[2].GetComponent<MendoBuy>().ExitHover();
            currentSelection++;
            Selections[currentSelection].GetComponent<MendoBuy>().Hover();
        }
        else if (Input.GetAxisRaw("XboxDPadHorizontal") < 0 && currentSelection > 0 && moved == false)
        {
            moved = true;
            Selections[0].GetComponent<MendoBuy>().ExitHover();
            Selections[1].GetComponent<MendoBuy>().ExitHover();
            Selections[2].GetComponent<MendoBuy>().ExitHover();
            currentSelection -= 1;
            Selections[currentSelection].GetComponent<MendoBuy>().Hover();
        }
        else if (Input.GetAxisRaw("XboxDPadHorizontal") == 0)
        {
            moved = false;
        }
    }
}
