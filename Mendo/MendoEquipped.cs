using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MendoEquipped : MonoBehaviour
{
    public Image Icon;
    public TMP_Text Stats;

    public Sprite Titanium;
    public Sprite Steel;
    public Sprite Reinforced;

    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        fnafw1.loadArmorValue(1);
        fnafw1.loadArmorValue(2);
        fnafw1.loadArmorValue(3);

        if (fnafw1.ar[3] == 1)
        {
            Icon.sprite = Titanium;
            Stats.text = "Def +100";
        }
        else if(fnafw1.ar[2] == 1)
        {
            Icon.sprite = Steel;
            Stats.text = "Def +20";
        }
        else if(fnafw1.ar[1] == 1)
        {
            Icon.sprite = Reinforced;
            Stats.text = "Def +10";
        }
    }
}
