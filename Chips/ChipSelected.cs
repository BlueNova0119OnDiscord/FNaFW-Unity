using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChipSelected : MonoBehaviour
{
    public GameObject Selection;
    public bool hasSelection = false;

    private GameObject CharObject;

    public int slotId;

    void Start()
    {
        hasSelection = true;

        CheckSave();
    }

    public void HoverEnter()
    {
        HoverChip HoverChar = CharObject.GetComponent("HoverChip") as HoverChip;

        HoverChar.OnHover();
    }

    public void HoverExit()
    {
        HoverChip HoverChar = CharObject.GetComponent("HoverChip") as HoverChip;

        HoverChar.OnExit();
    }

    void CheckSave()
    {
        //fnafw1.loadSValue(1); fnafw1.loadSValue(2); fnafw1.loadSValue(3); fnafw1.loadSValue(4); fnafw1.loadSValue(5); fnafw1.loadSValue(6); fnafw1.loadSValue(7); fnafw1.loadSValue(8);

        fnafw1.loadActiveValue(slotId);

        //Debug.Log("Checking...");
        //Debug.Log($"Slot {slotId} is loading with a value of {fnafw1.s[slotId]}.");
        if (fnafw1.active[slotId] > 0)
        {
            hasSelection = true;
            //Debug.Log("Slot Good.");
        }

        if (fnafw1.active[slotId] == -1)
        {
            hasSelection = false;
            //Debug.Log("Slot Bad.");
        }
    }

    public void ResetSelect()
    {
        CheckChipSelect.selection = false;
        CheckChipSelect.activeNumber = slotId;
    }
}
