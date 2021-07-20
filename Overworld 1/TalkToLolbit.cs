using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TalkToLolbit : MonoBehaviour
{
    public GameObject Character;
    private bool Drain;
    private int Draining = 5;
    public int LolbitNumber;

    void Awake()
    {
        Drain = true;
    }

    void Update()
    {
        if (Drain == true && Draining > 0)
        {
            Draining -= 1;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (Draining == 0)
        {
            fnafw1.saveXValue(Character.transform.localPosition.x);
            fnafw1.saveYValue(Character.transform.localPosition.y);

            info.lolbit = LolbitNumber;

            SceneManager.LoadScene(scenes.Lolbit);
        }
        else
        {
            Drain = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (Draining > 0)
        {
            Drain = true;
        }
    }
}
