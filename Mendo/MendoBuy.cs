using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MendoBuy : MonoBehaviour
{
    public int Price;
    public int ArmorID;

    public Sprite HoverSprite;
    public Sprite DefaultSprite;

    private bool Selected;
    public GameObject ControllerIcon;

    public AudioSource Ching;

    public TMP_Text Tokens;

    public GameObject Sold;
    public MendoEquipped Mendo;

    void Start()
    {
        fnafw1.loadArmorValue(ArmorID);
        if (fnafw1.ar[ArmorID] == 1)
        {
            Sold.SetActive(true);
        }

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Clicked);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && Selected == true && info.controllerinput == 1)
        {
            Clicked();
        }
    }

    void Clicked()
    {
        fnafw1.loadArmorValue(ArmorID);
        fnafw1.loadTokensValue();
        if (fnafw1.tokens > Price && fnafw1.ar[ArmorID] == 0)
        {
            Ching.Play();
            fnafw1.saveTokensValue((fnafw1.tokens - Price));
            Tokens.text = fnafw1.tokens.ToString();
            fnafw1.saveArmorValue(1, ArmorID);
            Sold.SetActive(true);

            Mendo.Refresh();
        }
    }

    public void Hover()
    {
        Image img = gameObject.GetComponent<Image>();

        img.sprite = HoverSprite;
        Selected = true;
        if (info.controllerinput == 1)
            ControllerIcon.SetActive(true);
    }

    public void ExitHover()
    {
        Image img = gameObject.GetComponent<Image>();

        img.sprite = DefaultSprite;
        Selected = false;
        if (info.controllerinput == 1)
            ControllerIcon.SetActive(false);
    }
}
