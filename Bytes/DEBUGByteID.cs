using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DEBUGByteID : MonoBehaviour
{
    public int characterID = 1;

    public int maxID;
    public int minID;

    public Button upButton;
    public Button downButton;
    public Text counter;

    public bool MouseDown = false;

    public void ButtonDown(int updown)
    {
        MouseDown = true;
        if (updown == 0)
        {
            StartCoroutine(Up());
        }
        else if (updown == 1)
        {
            StartCoroutine(Down());
        }
    }

    public void ButtonUp()
    {
        MouseDown = false;
    }

    IEnumerator Up()
    {
        while (MouseDown == true)
        {
            //Debug.Log("Test");
            if (characterID != maxID)
            {
                characterID = characterID + 1;
                counter.text = characterID.ToString();
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator Down()
    {
        while (MouseDown == true)
        {
            //Debug.Log("Test");
            if (characterID != minID)
            {
                characterID = characterID - 1;
                counter.text = characterID.ToString();
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
