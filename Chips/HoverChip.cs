using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverChip : MonoBehaviour
{
    public IsChipUnlocked charUnlocked;

    public string Description = "Start battle with a temporary defence boost.";

    public GameObject info;

    public Text descText;

    public void OnHover()
    {
        if (charUnlocked.unlocked == 1f)
        {
            info.SetActive(true);

            descText.text = Description;
        }
    }

    public void OnExit()
    {
        info.SetActive(false);
    }
}
