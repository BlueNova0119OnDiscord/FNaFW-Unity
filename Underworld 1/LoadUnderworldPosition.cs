using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadUnderworldPosition : MonoBehaviour
{
    public Transform Character;

    void Start()
    {
        Character.position = new Vector3(fnafw1.underworldx, fnafw1.underworldy);
    }
}
