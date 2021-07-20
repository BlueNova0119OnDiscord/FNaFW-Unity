using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarChangeText : MonoBehaviour
{
    private Slider HealthBar;
    public Text text;

    void Start()
    {
        HealthBar = gameObject.GetComponent<Slider>();
    }

    public void TextChange()
    {
        text.text = HealthBar.value.ToString();
    }
}
