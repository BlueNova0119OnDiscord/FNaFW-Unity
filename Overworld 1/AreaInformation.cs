using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaInformation : MonoBehaviour
{
    public float areaValue;

    public FindArea areaUI;
    public FindArea areaUIController;

    void OnTriggerEnter2D(Collider2D collider)
    {
        fnafw1.saveAreaValue(areaValue);

        if (info.controllerinput == 1)
            areaUIController.UpdateSprite();
        else
            areaUI.UpdateSprite();
    }
}
