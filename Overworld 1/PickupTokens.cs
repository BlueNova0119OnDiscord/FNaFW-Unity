using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupTokens : MonoBehaviour
{
    public Text Tokens;
    public Text TokensCont;
    public int Value;
    public AudioSource Bling;

    void OnTriggerEnter2D(Collider2D collider)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Bling.Play();
        info.pendingtokens = info.pendingtokens + Value;
        if (info.pendingtokens == 0)
            Destroy(gameObject);
    }
}
