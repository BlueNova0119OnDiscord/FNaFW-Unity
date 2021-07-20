using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selections : MonoBehaviour
{
    public int Selected = 0;

    public Animator Slot1;
    public Animator Slot2;
    public Animator Slot3;
    public Animator Slot4;

    void Update()
    {
        if (Selected > 0)
        {
            Slot1.Play("CheckboxChecked");
            if(Selected > 1)
            {
                Slot2.Play("CheckboxChecked");
                if (Selected > 2)
                {
                    Slot3.Play("CheckboxChecked");
                    if (Selected > 3)
                    {
                        Slot4.Play("CheckboxChecked");
                    }
                }
            }
        }
        else
        {
            Slot1.Play("CheckboxEmpty");
            Slot2.Play("CheckboxEmpty");
            Slot3.Play("CheckboxEmpty");
            Slot4.Play("CheckboxEmpty");
        }
    }
}
