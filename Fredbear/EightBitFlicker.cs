using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EightBitFlicker : MonoBehaviour
{
    public List<Sprite> Images;
    public Image Fredbear;

    void Start()
    {
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            Fredbear.sprite = Images[Random.Range(0, 3)];
            yield return new WaitForSeconds(0.1f);
        }
    }
}
