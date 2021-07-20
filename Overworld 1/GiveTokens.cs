using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveTokens : MonoBehaviour
{
    public Text Tokens;
    public Text TokensCont;
    private bool counting = false;
    public AudioSource Blip;

    void Update()
    {
        if (counting == false && info.pendingtokens > 0)
        {
            StartCoroutine(Count());
        }
    }

    IEnumerator Count()
    {
        counting = true;
        int currentValue;
        fnafw1.loadTokensValue();
        currentValue = (int)fnafw1.tokens;
        int oldValue = (int)fnafw1.tokens;

        fnafw1.saveTokensValue(fnafw1.tokens + info.pendingtokens);

        while (currentValue != (oldValue + info.pendingtokens))
        {
            Tokens.text = currentValue.ToString();
            TokensCont.text = currentValue.ToString();
            Blip.Play();
            currentValue++;
            yield return new WaitForSeconds(0.025f);
        }

        Tokens.text = currentValue.ToString();
        TokensCont.text = currentValue.ToString();
        Blip.Play();
        info.pendingtokens = 0;
        counting = false;
    }
}
