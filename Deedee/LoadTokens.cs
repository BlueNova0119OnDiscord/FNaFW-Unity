using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadTokens : MonoBehaviour
{
    void Start()
    {
        fnafw1.loadTokensValue();
        TMP_Text text = gameObject.GetComponent<TMP_Text>();

        text.text = fnafw1.tokens.ToString();
    }

    public void Buy()
    {
        TMP_Text text = gameObject.GetComponent<TMP_Text>();
        text.text = (fnafw1.tokens - 10).ToString();
    }
}
