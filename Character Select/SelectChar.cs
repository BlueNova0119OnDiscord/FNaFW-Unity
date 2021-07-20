using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChar : MonoBehaviour
{
    public Button Char;
    public float ID;

    Dictionary<int, GameObject> slots = new Dictionary<int, GameObject>();

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
        slots.Add(1, slot1);
        slots.Add(2, slot2);
        slots.Add(3, slot3);
        slots.Add(4, slot4);
        slots.Add(5, slot5);
        slots.Add(6, slot6);
        slots.Add(7, slot7);
        slots.Add(8, slot8);

        Char.onClick.AddListener(Select);
    }

    public void Select()
    {
        IsUnlocked CheckUnlock = Char.GetComponent("IsUnlocked") as IsUnlocked;

        //Debug.Log($"Reset is {CheckSelect.reset}, Selection is {CheckSelect.selection}, and Party Number is {CheckSelect.partyNumber}.");

        if (CheckSelect.selection == true && CheckUnlock.unlocked == 1f && CheckSelect.reset == false)
        {
            fnafw1.saveSlotValue(ID, CheckSelect.partyNumber);

            Selected Selection = slots[CheckSelect.partyNumber].GetComponent("Selected") as Selected;

            RectTransform seltransform = slots[CheckSelect.partyNumber].GetComponent<RectTransform>();
            RectTransform chartransform = Char.GetComponent<RectTransform>();

            seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            CheckSelect.selection = false;

            Selected selecting = slots[CheckSelect.partyNumber].GetComponent("Selected") as Selected;

            selecting.Deselect(Char.gameObject);
        }

        if (CheckSelect.selection == true && CheckUnlock.unlocked == 1f && CheckSelect.reset == true)
        {
            fnafw1.saveSlotValue(ID, CheckSelect.partyNumber);

            Selected Selection = slots[CheckSelect.partyNumber].GetComponent("Selected") as Selected;

            RectTransform seltransform = slots[CheckSelect.partyNumber].GetComponent<RectTransform>();
            RectTransform chartransform = Char.GetComponent<RectTransform>();

            seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            Selected selecting = slots[CheckSelect.partyNumber].GetComponent("Selected") as Selected;

            selecting.Deselect(Char.gameObject);

            if (CheckSelect.partyNumber < 8)
            {
                CheckSelect.partyNumber++;
            }
            else
            {
                CheckSelect.selection = false;
                CheckSelect.reset = false;
            }
        }
    }
}
