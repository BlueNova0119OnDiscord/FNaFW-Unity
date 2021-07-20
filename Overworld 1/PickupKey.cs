using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject KeyIconUI;
    public GameObject KeyIconUICont;

    void Start()
    {
        fnafw1.loadKeyValue();

        if (fnafw1.key == 1)
        {
            KeyIconUI.SetActive(true);
            KeyIconUICont.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        fnafw1.saveKeyValue(1);
        KeyIconUI.SetActive(true);
        KeyIconUICont.SetActive(true);
        gameObject.SetActive(false);
    }
}
