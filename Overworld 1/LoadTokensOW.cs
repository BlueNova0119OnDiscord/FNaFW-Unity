using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadTokensOW : MonoBehaviour
{
    void Start()
    {
        fnafw1.loadTokensValue();
        Text text = gameObject.GetComponent<Text>();
        text.text = fnafw1.tokens.ToString();
    }
}
