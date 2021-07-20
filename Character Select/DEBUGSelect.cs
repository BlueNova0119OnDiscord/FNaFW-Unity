using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGSelect : MonoBehaviour
{
    public Text ID;
    public InputField SelectID;
    public Button Select;

    void Start()
    {
        Select.GetComponent<Button>().onClick.AddListener(Selector);
    }

    public void Selector()
    {
        fnafw1.saveSlotValue(float.Parse(ID.text), int.Parse(SelectID.text));
    }
}
