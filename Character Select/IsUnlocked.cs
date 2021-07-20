using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IsUnlocked : MonoBehaviour
{
    public int ID = 0;
    private int saveFile = 1;
    public float unlocked = 0f;

    public Material transparent;
    public Material none;
    public Image character;

    public GameObject charObject;

    public GameObject[] slots;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;

    void Start()
    {
        slots = new GameObject[9];

        slots[1] = slot1;
        slots[2] = slot2;
        slots[3] = slot3;
        slots[4] = slot4;
        slots[5] = slot5;
        slots[6] = slot6;
        slots[7] = slot7;
        slots[8] = slot8;

        if (saveFile == 1)
        {
            save1();
        }
        else if (saveFile == 2)
        {
            //save2();
        }
        else if (saveFile == 3)
        {
            //save3();
        }
    }

    void save1()
    {
        if (ID <= 8)
        {
            fnafw1.saveHaveValue(1f, ID);
        }

        character.material = transparent;
        fnafw1.loadHaveValue(ID);

        int i = 1;
        while (i < 9)
        {
            fnafw1.loadSlotValue(i);
            i++;
        }

        if (fnafw1.have[ID] == 1)
        {
            character.material = none;
            if (fnafw1.slot[1] == ID)
            {
                checkUnlocked(1);
            }
            else if (fnafw1.slot[2] == ID)
            {
                checkUnlocked(2);
            }
            else if (fnafw1.slot[3] == ID)
            {
                checkUnlocked(3);
            }
            else if (fnafw1.slot[4] == ID)
            {
                checkUnlocked(4);
            }
            else if (fnafw1.slot[5] == ID)
            {
                checkUnlocked(5);
            }
            else if (fnafw1.slot[6] == ID)
            {
                checkUnlocked(6);
            }
            else if (fnafw1.slot[7] == ID)
            {
                checkUnlocked(7);
            }
            else if (fnafw1.slot[8] == ID)
            {
                checkUnlocked(8);
            }
        }
        else
        {
            unlocked = 0f;
            //Debug.Log($"{ID} is locked!");
        }

        if (fnafw1.have[ID] == 1)
        {
            unlocked = 1f;
            //Debug.Log($"{ID} is unlocked!");
        }
    }

    void save2()
    {
        if (ID <= 8)
        {
            fnafw1.saveHaveValue(1f, ID);
        }

        if (fnafw1.have[ID] == 1)
        {
            unlocked = 1f;
            //Debug.Log($"{ID} is unlocked!");
        }
    }

    void save3()
    {
        if (ID <= 8)
        {
            fnafw1.saveHaveValue(1f, ID);
        }

        if (fnafw1.have[ID] == 1)
        {
            unlocked = 1f;
           // Debug.Log($"{ID} is unlocked!");
        }
    }

    void checkUnlocked(int svalue)
    {
        unlocked = 1f;
        //Debug.Log($"{ID} is unlocked!");
        character.material = none;
        if (fnafw1.slot[svalue] == ID)
        {
            //Debug.Log($"Checking Slot {svalue}...");

            Selected Selection = slots[svalue].GetComponent("Selected") as Selected;

            RectTransform seltransform = slots[svalue].GetComponent<RectTransform>();
            RectTransform chartransform = charObject.GetComponent<RectTransform>();

            seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            Selected SlotSelect = slots[svalue].GetComponent("Selected") as Selected;
            SlotSelect.Deselect(charObject);
        }
    }
}
