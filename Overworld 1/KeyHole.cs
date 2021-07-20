using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHole : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        fnafw1.loadKeyValue();

        if (fnafw1.key == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
