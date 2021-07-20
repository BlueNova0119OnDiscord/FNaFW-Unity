using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophies : MonoBehaviour
{
    public GameObject owl;
    public GameObject scott;
    public GameObject chipper;
    public GameObject fredbear;
    public GameObject fan;
    public GameObject pearl;
    public GameObject gone;
    public GameObject child;
    public GameObject rainbow;

    void Start()
    {
        if (info.beatgame1 == 1f)
        {
            owl.SetActive(true);
        }
        else
        {
            owl.SetActive(false);
        }

        if (info.beatgame2 == 1f)
        {
            scott.SetActive(true);
        }
        else
        {
            scott.SetActive(false);
        }

        if (info.beatgame3 == 1f)
        {
            chipper.SetActive(true);
        }
        else
        {
            chipper.SetActive(false);
        }

        if (info.beatgame6 == 1f)
        {
            fredbear.SetActive(true);
        }
        else
        {
            fredbear.SetActive(false);
        }

        if (info.all == 1f)
        {
            fan.SetActive(true);
        }
        else
        {
            fan.SetActive(false);
        }

        if (info.gotpearl == 1f)
        {
            pearl.SetActive(true);
        }
        else
        {
            pearl.SetActive(false);
        }

        if (info.beatgame4 == 1f)
        {
            gone.SetActive(true);
        }
        else
        {
            gone.SetActive(false);
        }

        if (info.beatgame5 == 1f)
        {
            child.SetActive(true);
        }
        else
        {
            child.SetActive(false);
        }

        if (info.beatgame7 == 1f)
        {
            rainbow.SetActive(true);
        }
        else
        {
            rainbow.SetActive(false);
        }
    }
}
