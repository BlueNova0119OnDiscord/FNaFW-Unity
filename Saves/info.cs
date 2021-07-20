using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    public static float first = 0;

    public static float beatgame1 = 0;
    public static float beatgame2 = 0;
    public static float beatgame3 = 0;
    public static float beatgame4 = 0;
    public static float beatgame5 = 0;
    public static float beatgame6 = 0;
    public static float beatgame7 = 0;
    public static float gotpearl = 0;
    public static float all = 0;

    public static float hour1 = 0;
    public static float hour2 = 0;
    public static float hour3 = 0;

    public static float diff1 = 0;
    public static float diff2 = 0;
    public static float diff3 = 0;

    public static float mode1 = 0;
    public static float mode2 = 0;
    public static float mode3 = 0;

    public static float controllerinput = 0;

    public static float lolbit = 1;

    public static float pendingtokens = 0;

    void Start()
    {
        first = PlayerPrefs.GetFloat("first", 0f);
        gotpearl = PlayerPrefs.GetFloat("gotpearl", 0f);
    }

    public static void saveValue(string name, float save)
    {
        first = save;
        PlayerPrefs.SetFloat(name, save);
        //Debug.Log($"Saved {name} with a value of {first.ToString()}.");
    }

    public static void savePearlValue(float save)
    {
        gotpearl = save;
        PlayerPrefs.SetFloat("gotpearl", 1);
    }
}
