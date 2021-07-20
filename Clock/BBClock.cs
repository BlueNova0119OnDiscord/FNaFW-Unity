using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBClock : MonoBehaviour
{
    public Collider2D box;
    public Timer timer;

    private Collider2D BB;

    void Start()
    {
        BB = gameObject.GetComponent("Collider2D") as Collider2D;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (BB.IsTouching(box) && timer.Done == false)
        {
            timer.Done = true;
        }

        if (timer.Done == false)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, (transform.localPosition.y + 0.3f), 84.81337f);
        }
    }
}
