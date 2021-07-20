using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldJumpButton : MonoBehaviour
{
    public int warpID;
    public Animator warpAnimator;
    public GameObject UIButton;
    public GameObject debris;
    public AudioSource switchSound;

    void Start()
    {
        fnafw1.loadJumpValue(warpID);

        if (fnafw1.jumps[warpID] == 1)
        {
            warpAnimator.SetBool("ButtonDown", true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (fnafw1.jumps[warpID] != 1 && fnafw1.glitched == 0)
        {
            switchSound.Play();
            fnafw1.saveJumpValue(1, warpID);
            warpAnimator.SetBool("ButtonDown", true);
            UIButton.SetActive(true);
            debris.SetActive(false);
        }
    }
}
