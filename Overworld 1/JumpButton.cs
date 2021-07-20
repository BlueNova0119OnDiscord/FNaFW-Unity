using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    public Transform Character;
    public Button Jump;
    public AudioSource warp;

    public int whichJump = 1;
    public float x;
    public float y;

    void Start()
    {
        fnafw1.loadJumpValue(whichJump);

        if (whichJump == 1)
        {
            fnafw1.saveJumpValue(1, 1);
        }

        CheckUnlock();
        Jump.onClick.AddListener(doJump);
    }

    void CheckUnlock()
    {
        //print(fnafw1.jumps[whichJump]);
        if (fnafw1.jumps[whichJump] != 1)
        {
            Jump.gameObject.SetActive(false);
        }
    }

    private void doJump()
    {
        if (fnafw1.glitched == 0)
        {
            Character.position = new Vector3(x, y);
            warp.Play();
        }
    }
}
