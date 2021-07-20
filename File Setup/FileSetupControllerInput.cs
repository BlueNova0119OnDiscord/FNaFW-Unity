using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileSetupControllerInput : MonoBehaviour
{
    public static int selected = 3;

    public static int min = 3;
    public static int max = 3;

    public static int on = 1;

    int changing;

    public GameObject Controls;

    public Animator Slot1;
    public Animator Slot2;
    public Animator Slot3;

    public Animator New;
    public Animator Continue;

    public Animator Yes;
    public Animator No;

    public Animator Adventure;
    public Animator FixedParty;

    public Animator Normal;
    public Animator Hard;

    void Start()
    {
        if (info.controllerinput == 1)
        {
            Slot1.SetBool("Selected", true);
            Controls.SetActive(true);
        }
    }

    void Update()
    {
        if (info.controllerinput == 1)
        {
            if (Input.GetAxis("XboxDPadVertical") == 1 || Input.GetAxis("Vertical") > 0.3)
            {
                if (changing == 0)
                {
                    Selection(1);
                }
                changing = 1;
            }
            else if (Input.GetAxis("XboxDPadVertical") == -1 || Input.GetAxis("Vertical") < -0.3)
            {
                if (changing == 0)
                {
                    Selection(0);
                }
                changing = 1;
            }
            else
            {
                changing = 0;
            }
        }
    }

    public void Selection(int change)
    {
        if (info.controllerinput == 1)
        {
            if (change == 1 && selected != max)
            {
                selected += 1;
            }
            else if (change == 0 && selected != min)
            {
                selected -= 1;
            }

            if (on == 1)
            {
                if (selected == 3)
                {
                    Slot1.SetBool("Selected", true);
                }
                else
                {
                    Slot1.SetBool("Selected", false);
                }

                if (selected == 2)
                {
                    Slot2.SetBool("Selected", true);
                }
                else
                {
                    Slot2.SetBool("Selected", false);
                }

                if (selected == 1)
                {
                    Slot3.SetBool("Selected", true);
                }
                else
                {
                    Slot3.SetBool("Selected", false);
                }
            }

            if (on == 2)
            {
                if (selected == 2)
                {
                    New.SetBool("Selected", true);
                }
                else
                {
                    New.SetBool("Selected", false);
                }

                if (selected == 1)
                {
                    Continue.SetBool("Selected", true);
                }
                else
                {
                    Continue.SetBool("Selected", false);
                }
            }

            if (on == 3)
            {
                if (selected == 2)
                {
                    Yes.SetBool("Selected", true);
                }
                else
                {
                    Yes.SetBool("Selected", false);
                }

                if (selected == 1)
                {
                    No.SetBool("Selected", true);
                }
                else
                {
                    No.SetBool("Selected", false);
                }
            }

            if (on == 4)
            {
                if (selected == 2)
                {
                    Adventure.SetBool("Selected", true);
                }
                else
                {
                    Adventure.SetBool("Selected", false);
                }

                if (selected == 1)
                {
                    FixedParty.SetBool("Selected", true);
                }
                else
                {
                    FixedParty.SetBool("Selected", false);
                }
            }

            if (on == 5)
            {
                if (selected == 2)
                {
                    Normal.SetBool("Selected", true);
                }
                else
                {
                    Normal.SetBool("Selected", false);
                }

                if (selected == 1)
                {
                    Hard.SetBool("Selected", true);
                }
                else
                {
                    Hard.SetBool("Selected", false);
                }
            }
        }
    }
}
