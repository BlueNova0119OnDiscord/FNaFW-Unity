using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LolbitContInst : MonoBehaviour
{
    void Start()
    {
        if (info.controllerinput != 1)
        {
            gameObject.SetActive(false);
        }
    }
}
