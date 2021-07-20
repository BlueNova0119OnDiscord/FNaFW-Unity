using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindArea : MonoBehaviour
{
    public Sprite[] areaSprites;

    void Start()
    {
        fnafw1.loadAreaValue();
        gameObject.GetComponent<Image>().sprite = areaSprites[(int) fnafw1.area];
    }

    public void UpdateSprite()
    {
        gameObject.GetComponent<Image>().sprite = areaSprites[(int)fnafw1.area];
    }
}
