using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selected : MonoBehaviour
{
    public GameObject Selection;
    public bool hasSelection = false;
    public GameObject Default;
    public GameObject select;
    public GameObject Return;

    private GameObject CharObject;

    public int slotId;

    void Start()
    {
        hasSelection = true;

        CheckSave();
        Selection.GetComponent<Button>().onClick.AddListener(Select);
    }

    public void HoverEnter()
    {
        Hover HoverChar = CharObject.GetComponent("Hover") as Hover;

        HoverChar.OnHover();
    }

    public void HoverExit()
    {
        Hover HoverChar = CharObject.GetComponent("Hover") as Hover;

        HoverChar.OnExit();
    }

    void CheckSave()
    {
        IsUnlocked characterScript = Default.GetComponent("IsUnlocked") as IsUnlocked;
        //fnafw1.loadSValue(1); fnafw1.loadSValue(2); fnafw1.loadSValue(3); fnafw1.loadSValue(4); fnafw1.loadSValue(5); fnafw1.loadSValue(6); fnafw1.loadSValue(7); fnafw1.loadSValue(8);

        fnafw1.loadSlotValue(slotId);

        //Debug.Log("Checking...");
        //Debug.Log($"Slot {slotId} is loading with a value of {fnafw1.s[slotId]}.");
        if (fnafw1.slot[slotId] > 0)
        {
            hasSelection = true;
            //Debug.Log("Slot Good.");
        }

        if (fnafw1.slot[slotId] == -1)
        {
            hasSelection = false;
            //Debug.Log("Slot Bad.");
        }
        
        if (hasSelection == true)
        {
            //Debug.Log("Slot has been loaded before. Not going to defaults.");
        }

        if (hasSelection == false)
        {
            //Debug.Log("Slot has not been loaded before. Going to defaults.");

            RectTransform uitransform = Selection.GetComponent<RectTransform>();
            RectTransform defaulttransform = Default.GetComponent<RectTransform>();

            uitransform.position = defaulttransform.position;
            uitransform.localScale = defaulttransform.localScale;

            hasSelection = true;

            fnafw1.saveSlotValue(characterScript.ID, slotId);
        }
    }

    public void Select()
    {
        if (CheckSelect.reset == false)
        {
            RectTransform slcttransform = select.GetComponent<RectTransform>();
            RectTransform uitransform = Selection.GetComponent<RectTransform>();

            slcttransform.localScale = uitransform.localScale;
            slcttransform.position = uitransform.position;

            CheckSelect.selection = true;
            CheckSelect.partyNumber = slotId;
        }
    }

    public void ResetSelect()
    {
        CheckSelect.selection = true;
        CheckSelect.partyNumber = slotId;
        CheckSelect.reset = true;
    }

    public void Deselect(GameObject ObjChar)
    {
        RectTransform slcttransform = select.GetComponent<RectTransform>();
        RectTransform uitransform = Return.GetComponent<RectTransform>();

        slcttransform.localScale = uitransform.localScale;
        slcttransform.position = uitransform.position;

        CharObject = ObjChar;
    }
}
