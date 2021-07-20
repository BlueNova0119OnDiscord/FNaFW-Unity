using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChip : MonoBehaviour
{
    public Button Chip;
    public float ID;

    Dictionary<int, GameObject> slots = new Dictionary<int, GameObject>();

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    public AudioSource blip;

    public Selections selections;

    void Start()
    {
        slots.Add(1, slot1);
        slots.Add(2, slot2);
        slots.Add(3, slot3);
        slots.Add(4, slot4);

        fnafw1.loadActiveValue(1);

        if (fnafw1.active[1] > 0)
        {
            CheckChipSelect.selection = true;
        }
        else
        {
            CheckChipSelect.activeNumber = 1;
        }

        Chip.onClick.AddListener(Select);
    }

    public void Select()
    {
        IsChipUnlocked CheckUnlock = Chip.GetComponent("IsChipUnlocked") as IsChipUnlocked;

        //Debug.Log($"Reset is {CheckSelect.reset}, Selection is {CheckSelect.selection}, and Party Number is {CheckSelect.partyNumber}.");

        bool Overlap = false;

        int i = 1;
        while (i < 5)
        {
            fnafw1.loadActiveValue(i);
            if (fnafw1.active[i] == ID)
                Overlap = true;
            i++;
        }

        if (CheckChipSelect.selection == false && CheckUnlock.unlocked == 1f && Overlap == false)
        {
            //print(CheckChipSelect.activeNumber);

            fnafw1.saveActiveValue(ID, CheckChipSelect.activeNumber);

            //print(CheckChipSelect.activeNumber);

            Selected Selection = slots[CheckChipSelect.activeNumber].GetComponent("Selected") as Selected;

            RectTransform seltransform = slots[CheckChipSelect.activeNumber].GetComponent<RectTransform>();
            RectTransform chartransform = Chip.GetComponent<RectTransform>();

            seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            Selected selecting = slots[CheckChipSelect.activeNumber].GetComponent("Selected") as Selected;

            blip.Play();

            selections.Selected++;

            if (CheckChipSelect.activeNumber < 4)
            {
                CheckChipSelect.activeNumber++;
            }
            else
            {
                CheckChipSelect.selection = true;
            }
        }
    }
}
