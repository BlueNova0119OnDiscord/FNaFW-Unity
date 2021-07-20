using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IsByteUnlocked : MonoBehaviour
{
    public int ID = 0;
    private int saveFile = 1;
    public float unlocked = 0f;

    public Material transparent;
    public Material none;

    Dictionary<int, GameObject> slots = new Dictionary<int, GameObject>();

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    public SelectionsByte selections;

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
        Image character = GetComponent<Image>(); ;

        character.material = transparent;
        fnafw1.loadByteValue(ID);

        int i = 1;
        while (i < 5)
        {
            fnafw1.loadActiveBValue(i);
            i++;
        }

        if (fnafw1.bytes[ID] == 1)
        {
            character.material = none;
            if (fnafw1.activeb[1] == ID)
            {
                checkUnlocked(1);
            }
            else if (fnafw1.activeb[2] == ID)
            {
                checkUnlocked(2);
            }
            else if (fnafw1.activeb[3] == ID)
            {
                checkUnlocked(3);
            }
            else if (fnafw1.activeb[4] == ID)
            {
                checkUnlocked(4);
            }
            else
            {
                unlocked = 0f;
            }
        }

        if (fnafw1.bytes[ID] == 1)
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

    void checkUnlocked(int bytevalue)
    {
        Image character = GetComponent<Image>(); ;
        GameObject charObject = gameObject;

        unlocked = 1f;
        //Debug.Log($"{ID} is loaded with Chip Value{chipvalue}");
        character.material = none;
        if (fnafw1.activeb[bytevalue] == ID)
        {
            //Debug.Log($"Checking Slot {chipvalue}...");

            ChipSelected Selection = slots[bytevalue].GetComponent("ChipSelected") as ChipSelected;

            RectTransform seltransform = slots[bytevalue].GetComponent<RectTransform>();
            RectTransform chartransform = charObject.GetComponent<RectTransform>();

            //seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            selections.Selected++;
}
    }
}
