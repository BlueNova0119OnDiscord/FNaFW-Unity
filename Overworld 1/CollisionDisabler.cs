using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDisabler : MonoBehaviour
{
    public Collider2D[] colliders;
    int i = 1;

    void Update()
    {
        if (fnafw1.glitched == 1)
        {
            colliders[i].enabled = false;
        }
        else
        {
            colliders[i].enabled = true;
        }
        i++;
        if (i == colliders.Length)
        {
            i = 1;
        }
    }
}
