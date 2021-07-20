using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonChip : MonoBehaviour
{
    public Button resetButton;
    public GameObject reset;
    public GameObject tooltip;

    Dictionary<int, GameObject> slots = new Dictionary<int, GameObject>();

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    public Selections selections;

    void Start()
    {
        slots.Add(1, slot1);
        slots.Add(2, slot2);
        slots.Add(3, slot3);
        slots.Add(4, slot4);

        resetButton.onClick.AddListener(PlsReset);

        if (info.controllerinput == 1)
        {
            tooltip.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            PlsReset();
        }
    }

    public void PlsReset()
    {
        int i = 1;
        while (i<5)
        {
            RectTransform stransform = slots[i].GetComponent<RectTransform>();
            RectTransform sptransform = reset.GetComponent<RectTransform>();

            stransform.localScale = sptransform.localScale;
            stransform.position = sptransform.position;

            fnafw1.saveActiveValue(-1f, i);

            i++;
        }

        ChipSelected SlotSelect = slots[1].GetComponent("ChipSelected") as ChipSelected;

        SlotSelect.ResetSelect();

        selections.Selected = 0;
    }
}
