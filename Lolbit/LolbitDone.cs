using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LolbitDone : MonoBehaviour
{
    public GameObject ControllerIcon;

    void Start()
    {
        if (info.controllerinput == 1)
        {
            ControllerIcon.SetActive(true);
        }
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Clicked);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton7) && info.controllerinput == 1)
        {
            Clicked();
        }
    }

    void Clicked()
    {
        SceneManager.LoadScene(scenes.Bytes);
    }
}
