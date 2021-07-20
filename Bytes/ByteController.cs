using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByteController : MonoBehaviour
{
    public GameObject Selection;
    public GameObject navigateTooltip;
    
    private int GhostID = 1;
    private int HoverID = 1;

    private bool moving = false;

    void Start()
    {
        if (info.controllerinput == 1)
        {
            navigateTooltip.SetActive(true);
            MoveSelection();
        }
    }

    void Update()
    {
        if (info.controllerinput == 1)
        {
            if (Input.GetAxis("XboxDPadVertical") > 0 && moving == false)
            {
                moving = true;
                GhostID -= 7;
                if (GhostID > 0)
                {
                    HoverID = GhostID;
                }
                else
                {
                    GhostID = HoverID;
                }
                MoveSelection();
            }

            if (Input.GetAxis("XboxDPadVertical") < 0 && moving == false)
            {
                moving = true;
                GhostID += 7;
                if (GhostID < 8)
                {
                    HoverID = GhostID;
                }
                else
                {
                    GhostID = HoverID;
                }
                MoveSelection();
            }

            if (Input.GetAxis("XboxDPadHorizontal") > 0 && moving == false)
            {
                moving = true;
                GhostID += 1;
                if (GhostID < 8)
                {
                    HoverID = GhostID;
                }
                else
                {
                    GhostID = HoverID;
                }
                MoveSelection();
            }

            if (Input.GetAxis("XboxDPadHorizontal") < 0 && moving == false)
            {
                moving = true;
                GhostID -= 1;
                if (GhostID > 0)
                {
                    HoverID = GhostID;
                }
                else
                {
                    GhostID = HoverID;
                }
                MoveSelection();
            }

            if (Input.GetAxis("XboxDPadHorizontal") == 0 && Input.GetAxis("XboxDPadVertical") == 0)
            {
                moving = false;
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                SelectByte select = ByteAtlas.images[HoverID].gameObject.GetComponent("SelectByte") as SelectByte;

                select.Select();
            }
        }
    }

    void MoveSelection()
    {
        Selection.transform.localPosition = ByteAtlas.images[HoverID].transform.localPosition;
    }
}
