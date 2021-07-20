using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BytesButton : MonoBehaviour
{
    public Button bytesButton;
    public Transform Character;

    void Start()
    {
        bytesButton.onClick.AddListener(doneFunction);
    }

    void Update()
    {
        if (Input.GetAxis("XboxDPadHorizontal") > 0 && info.controllerinput == 1)
        {
            doneFunction();
        }
    }

    void doneFunction()
    {
        fnafw1.saveXValue(Character.transform.localPosition.x);
        fnafw1.saveYValue(Character.transform.localPosition.y);
        fnafw1.newstart = true;
        SceneManager.LoadScene(scenes.Bytes);
    }
}
