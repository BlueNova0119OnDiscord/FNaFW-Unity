using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectByte : MonoBehaviour
{
    public Button Byte;

    Dictionary<int, GameObject> slots = new Dictionary<int, GameObject>();

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    public AudioSource blip;

    public SelectionsByte selections;

    void Start()
    {
        slots.Add(1, slot1);
        slots.Add(2, slot2);
        slots.Add(3, slot3);
        slots.Add(4, slot4);

        fnafw1.loadActiveBValue(1);

        if (fnafw1.activeb[1] > 0)
        {
            CheckByteSelect.selection = true;
        }
        else
        {
            CheckByteSelect.activeNumber = 1;
        }

        Byte.onClick.AddListener(Select);
    }

    public void Select()
    {
        IsByteUnlocked CheckUnlock = Byte.GetComponent("IsByteUnlocked") as IsByteUnlocked;
        float ID = CheckUnlock.ID;

        //Debug.Log($"Reset is {CheckSelect.reset}, Selection is {CheckSelect.selection}, and Party Number is {CheckSelect.partyNumber}.");

        bool Overlap = false;

        int i = 1;
        while (i < 5)
        {
            fnafw1.loadActiveBValue(i);
            if (fnafw1.activeb[i] == ID)
                Overlap = true;
            i++;
        }

        if (CheckByteSelect.selection == false && CheckUnlock.unlocked == 1f && Overlap == false)
        {
            //print(CheckByteSelect.selection);
            //print(CheckChipSelect.activeNumber);

            fnafw1.saveActiveBValue(ID, CheckByteSelect.activeNumber);

            //print(CheckByteSelect.activeNumber);

            ByteSelected Selection = slots[CheckByteSelect.activeNumber].GetComponent("ByteSelected") as ByteSelected;

            RectTransform seltransform = slots[CheckByteSelect.activeNumber].GetComponent<RectTransform>();
            RectTransform chartransform = Byte.GetComponent<RectTransform>();

            seltransform.localScale = chartransform.localScale;
            seltransform.position = chartransform.position;

            blip.Play();

            selections.Selected++;

            if (CheckByteSelect.activeNumber < 4)
            {
                CheckByteSelect.activeNumber++;
            }
            else
            {
                CheckByteSelect.selection = true;
                //print(CheckByteSelect.selection);
            }
        }
    }
}
