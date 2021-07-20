using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerJump : MonoBehaviour
{
    public Transform Character;
    public AudioSource warp;
    public Image jumpImg;

    public int onJump = 1;

    public static float[] x;
    public static float[] y;

    public static Sprite[] Jump;

    public Sprite Jump1;
    public Sprite Jump2;
    public Sprite Jump3;
    public Sprite Jump4;
    public Sprite Jump5;
    public Sprite Jump6;

    public float x1;
    public float x2;
    public float x3;
    public float x4;
    public float x5;
    public float x6;

    public float y1;
    public float y2;
    public float y3;
    public float y4;
    public float y5;
    public float y6;
    
    void Start()
    {
        Jump = new Sprite[7];
        x = new float[7];
        y = new float[7];

        Jump[1] = Jump1;
        Jump[2] = Jump2;
        Jump[3] = Jump3;
        Jump[4] = Jump4;
        Jump[5] = Jump5;
        Jump[6] = Jump6;

        x[1] = x1;
        x[2] = x2;
        x[3] = x3;
        x[4] = x4;
        x[5] = x5;
        x[6] = x6;

        y[1] = y1;
        y[2] = y2;
        y[3] = y3;
        y[4] = y4;
        y[5] = y5;
        y[6] = y6;

        int loop = 1;
        while (loop < 7)
        {
            fnafw1.loadJumpValue(loop);
            loop++;
        }

        if (fnafw1.jumps[1] == 0)
        {
            fnafw1.saveJumpValue(1, 1);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            changeJump(true);
        }
        else if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            changeJump(false);
        }
        else if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            if (fnafw1.glitched == 0)
            {
                doJump();
            }
        }
    }

    private void changeJump(bool up)
    {
        if (up == true)
        {
            if (onJump < 6)
            {
                onJump += 1;
            }
        }
        else
        {
            if (onJump > 0)
            {
                onJump -= 1;
                //print(onJump);
            }
        }

        int i = onJump;
        if (up == true)
        {
            while (i < 7)
            {
                if (fnafw1.jumps[i] == 0)
                {
                    i++;
                    if (i > 6)
                    {
                        i = 1;
                    }
                }
                else if (fnafw1.jumps[i] == 1)
                {
                    break;
                }
            }
        }
        else if (up == false)
        {
            if (i == 0)
            {
                i = 6;
                while (i > 1)
                {
                    if (fnafw1.jumps[i] == 0)
                    {
                        i -= 1;
                    }
                    else if (fnafw1.jumps[i] == 1)
                    {
                        break;
                    }
                }
            }
            else
            {
                while (i > 0)
                {
                    if (fnafw1.jumps[i] == 0)
                    {
                        i -= 1;
                    }
                    else if (fnafw1.jumps[i] == 1)
                    {
                        break;
                    }
                }
            }
        }

        onJump = i;

        if (onJump < 1)
        {
            onJump = 1;
        }
        if (onJump > 6)
        {
            onJump = 6;
        }

        jumpImg.sprite = Jump[onJump];
    }

    private void doJump()
    {
        Character.position = new Vector3(x[onJump], y[onJump]);
        warp.Play();
    }
}
