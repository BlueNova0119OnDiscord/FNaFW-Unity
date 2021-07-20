using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ByteAtlas : MonoBehaviour
{
    public static Image[] images;

    [SerializeField] Image Byte1;
    [SerializeField] Image Byte2;
    [SerializeField] Image Byte3;
    [SerializeField] Image Byte4;
    [SerializeField] Image Byte5;
    [SerializeField] Image Byte6;
    [SerializeField] Image Byte7;
    [SerializeField] Image Byte8;
    [SerializeField] Image Byte9;
    [SerializeField] Image Byte10;
    [SerializeField] Image Byte11;
    [SerializeField] Image Byte12;
    [SerializeField] Image Byte13;
    [SerializeField] Image Byte14;
    [SerializeField] Image Byte15;
    [SerializeField] Image Byte16;
    [SerializeField] Image Byte17;
    [SerializeField] Image Byte18;
    [SerializeField] Image Byte19;
    [SerializeField] Image Byte20;
    [SerializeField] Image Byte21;

    void Awake()
    {
        images = new Image[22];

        images[1] = Byte1;
        images[2] = Byte2;
        images[3] = Byte3;
        images[4] = Byte4;
        images[5] = Byte5;
        images[6] = Byte6;
        images[7] = Byte7;
        images[8] = Byte8;
        images[9] = Byte9;
        images[10] = Byte10;
        images[11] = Byte11;
        images[12] = Byte12;
        images[13] = Byte13;
        images[14] = Byte14;
        images[15] = Byte15;
        images[16] = Byte16;
        images[17] = Byte17;
        images[18] = Byte18;
        images[19] = Byte19;
        images[20] = Byte20;
        images[21] = Byte21;
    }
}
