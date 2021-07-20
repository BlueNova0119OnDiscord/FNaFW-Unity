using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPosition : MonoBehaviour
{
    public Transform Character;

    void Start()
    {
        fnafw1.loadXValue();
        fnafw1.loadYValue();
        Character.position = new Vector3(fnafw1.x, fnafw1.y);
    }
}
