using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public bool reset = false;
    public Button resetButton;

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

        resetButton.onClick.AddListener(PlsReset);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            PlsReset();
        }
    }

    void PlsReset()
    {
        int i = 1;
        while (i<9)
        {
            RectTransform stransform = slots[i].GetComponent<RectTransform>();
            RectTransform sptransform = slots[i].transform.parent.GetComponent<RectTransform>();

            stransform.localScale = sptransform.localScale;
            stransform.position = sptransform.position;

            i++;
        }

        Selected SlotSelect = slots[1].GetComponent("Selected") as Selected;

        SlotSelect.ResetSelect();
    }
}
