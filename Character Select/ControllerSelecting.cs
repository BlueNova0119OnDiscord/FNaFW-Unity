using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSelecting : MonoBehaviour
{
    public GameObject Selection;
    public GameObject Instruction;
    public GameObject Controls;
    private int GhostID = 1;
    private int HoverID = 1;

    private bool moving = false;

    public int debug = 0;

    void Start()
    {
        if (debug == 1)
        {
            info.controllerinput = 1;
        }

        if (info.controllerinput == 1)
        {
            Instruction.SetActive(true);
            Controls.SetActive(true);
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
                GhostID -= 8;
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
                GhostID += 8;
                if (GhostID < 9)
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
                if (GhostID < 9)
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
                IsUnlocked unlocked = CharacterAtlas.images[HoverID].gameObject.GetComponent("IsUnlocked") as IsUnlocked;

                int i = 1;
                while (i < 9)
                {
                    if (CheckSelect.reset == true && CheckSelect.partyNumber == i)
                    {
                        i = 8;
                    }
                    else if (fnafw1.slot[i] == unlocked.ID)
                    {
                        if (CheckSelect.reset == false)
                        {
                            Selected selected = unlocked.slots[i].GetComponent("Selected") as Selected;
                            selected.Select();
                        }

                        i = 14;
                    }
                    i++;
                }

                //print(i);

                if (i == 9)
                {
                    SelectChar select = CharacterAtlas.images[HoverID].gameObject.GetComponent("SelectChar") as SelectChar;
                    select.Select();
                }
            }
        }
    }

    public void MoveSelection()
    {
        Selection.transform.localPosition = CharacterAtlas.images[HoverID].transform.localPosition;

        Hover onHover = CharacterAtlas.images[HoverID].gameObject.GetComponent("Hover") as Hover;
        onHover.OnHover();

        if (onHover.charUnlocked.unlocked != 1)
        {
            onHover.OnExit();
        }
    }
}
