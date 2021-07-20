using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.parent.gameObject.layer == 2)
            collider.gameObject.GetComponent<FishMovement>().changeDirection();
    }
}
