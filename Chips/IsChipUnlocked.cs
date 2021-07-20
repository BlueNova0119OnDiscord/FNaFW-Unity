using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IsChipUnlocked : MonoBehaviour
{
    public int ID = 0;
    private int saveFile = 1;
    public float unlocked = 0f;

    public Material transparent;
    public Material none;
    public Image character;

    public GameObject charObject;

    Dictionary<int, GameObject> slots = new Dictionary<int, GameObject>();

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    public Selections selections;

    public ResetButtonChip resetButton;

    void Start()
    {
        slots.Add(1, slot1);
        slots.Add(2, slot2);
        slots.Add(3, slot3);
        slots.Add(4, slot4);

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
        character.material = transparent;

        int i = 1;
        while (i < 5)
        {
            fnafw1.loadActiveValue(i);
            i++;
        }

        fnafw1.loadChipValue(ID);

        if (fnafw1.chip[ID] == 1)
        {
            character.material = none;
            if (fnafw1.active[1] == ID)
            {
                checkUnlocked(1);
            }
            else if (fnafw1.active[2] == ID)
            {
                checkUnlocked(2);
            }
            else if (fnafw1.active[3] == ID)
            {
                checkUnlocked(3);
            }
            else if (fnafw1.active[4] == ID)
            {
                checkUnlocked(4);
            }
            else
            {
                unlocked = 0f;
            }
        }

        if (fnafw1.chip[ID] == 1)
        {
            unlocked = 1f;
            character.material = none;
            //Debug.Log($"{ID} is unlocked!");
        }
    }

    void save2()
    {

    }

    void save3()
    {

    }

    void checkUnlocked(int chipvalue)
    {
        unlocked = 1f;
        //Debug.Log($"{ID} is loaded with Chip Value{chipvalue}");
        character.material = none;
        if (fnafw1.active[chipvalue] == ID)
        {
            //Debug.Log($"Checking Slot {chipvalue}...");

            ChipSelected Selection = slots[chipvalue].GetComponent("ChipSelected") as ChipSelected;

            RectTransform seltransform = slots[chipvalue].GetComponent<RectTransform>();
            RectTransform chartransform = charObject.GetComponent<RectTransform>();

            //seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            selections.Selected++;
}
    }
}
