using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saving : MonoBehaviour
{
    public Button saveButton;
    public GameObject Character;
    public Animator animator;

    void Start()
    {
        saveButton.onClick.AddListener(Save);
    }

    void Update()
    {
        if (info.controllerinput == 1)
        {
            if (Input.GetAxis("XboxDPadVertical") > 0)
            {
                Save();
            }
        }
    }

    void Save()
    {
        fnafw1.saveXValue(Character.transform.localPosition.x);
        fnafw1.saveYValue(Character.transform.localPosition.y);
        StartCoroutine(animate());
    }

    IEnumerator animate()
    {
        animator.SetBool("Saving", true);
        yield return new WaitForSeconds(0.6f);
        animator.SetBool("Saving", false);
    }
}
