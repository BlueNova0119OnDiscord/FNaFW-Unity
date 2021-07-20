using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyByte : MonoBehaviour
{
    public string[] ByteName;
    public int[] Price;
    public int[] ByteID;

    public TMP_Text Name;
    public Text Cost;
    public Animator Byte;

    private bool Selected;
    public GameObject ControllerIcon;

    public AudioSource Ching;

    public Sprite HoverSprite;
    public Sprite DefaultSprite;

    public TMP_Text Tokens;

    public GameObject Sold;

    void Start()
    {
        Name.text = ByteName[(int) info.lolbit - 1];
        Cost.text = Price[(int)info.lolbit - 1].ToString();
        Byte.Play(ByteName[(int)info.lolbit - 1]);

        fnafw1.loadByteValue(ByteID[(int)info.lolbit - 1]);
        if (fnafw1.bytes[ByteID[(int)info.lolbit - 1]] == 1)
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
        fnafw1.loadByteValue(ByteID[(int)info.lolbit - 1]);
        fnafw1.loadTokensValue();
        if (fnafw1.tokens > (Price[(int)info.lolbit - 1] - 1) && fnafw1.bytes[ByteID[(int)info.lolbit - 1]] == 0)
        {
            Ching.Play();
            fnafw1.saveTokensValue((fnafw1.tokens - Price[(int)info.lolbit - 1]));
            Tokens.text = fnafw1.tokens.ToString();
            fnafw1.saveByteValue(1, ByteID[(int)info.lolbit - 1]);
            Sold.SetActive(true);
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
