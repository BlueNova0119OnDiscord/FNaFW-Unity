using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    public int areaID;
    public GameObject debris;

    void Start()
    {
        fnafw1.loadJumpValue(areaID);

        if (fnafw1.jumps[areaID] == 1)
        {
            debris.SetActive(false);
        }
    }
}
