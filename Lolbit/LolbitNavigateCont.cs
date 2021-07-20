using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LolbitNavigateCont : MonoBehaviour
{
    public GameObject[] Selections;
    public int currentSelection;
    private bool moved;

    void Start()
    {
        if (info.controllerinput != 1)
        {
            gameObject.GetComponent<LolbitNavigateCont>().enabled = false;
        }
        else
        {
            currentSelection = 0;
            Selections[currentSelection].GetComponent<BuyByte>().Hover();
        }
    }

    void Update()
    {
        if (Input.GetAxisRaw("XboxDPadHorizontal") > 0 && currentSelection < 2 && moved == false)
        {
            moved = true;
            Selections[0].GetComponent<BuyByte>().ExitHover();
            Selections[1].GetComponent<BuyByte>().ExitHover();
            Selections[2].GetComponent<BuyByte>().ExitHover();
            currentSelection++;
            Selections[currentSelection].GetComponent<BuyByte>().Hover();
        }
        else if (Input.GetAxisRaw("XboxDPadHorizontal") < 0 && currentSelection > 0 && moved == false)
        {
            moved = true; 
            Selections[0].GetComponent<BuyByte>().ExitHover();
            Selections[1].GetComponent<BuyByte>().ExitHover();
            Selections[2].GetComponent<BuyByte>().ExitHover();
            currentSelection -= 1;
            Selections[currentSelection].GetComponent<BuyByte>().Hover();
        }
        else if (Input.GetAxisRaw("XboxDPadHorizontal") == 0)
        {
            moved = false;
        }
    }
}
