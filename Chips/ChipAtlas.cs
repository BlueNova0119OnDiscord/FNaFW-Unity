using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChipAtlas : MonoBehaviour
{
    public static Image[] images;

    [SerializeField] Image Chip1;
    [SerializeField] Image Chip2;
    [SerializeField] Image Chip3;
    [SerializeField] Image Chip4;
    [SerializeField] Image Chip5;
    [SerializeField] Image Chip6;
    [SerializeField] Image Chip7;
    [SerializeField] Image Chip8;
    [SerializeField] Image Chip9;
    [SerializeField] Image Chip10;
    [SerializeField] Image Chip11;
    [SerializeField] Image Chip12;
    [SerializeField] Image Chip13;
    [SerializeField] Image Chip14;
    [SerializeField] Image Chip15;
    [SerializeField] Image Chip16;
    [SerializeField] Image Chip17;
    [SerializeField] Image Chip18;
    [SerializeField] Image Chip19;
    [SerializeField] Image Chip20;
    [SerializeField] Image Chip21;

    void Awake()
    {
        images = new Image[22];

        images[1] = Chip1;
        images[2] = Chip2;
        images[3] = Chip3;
        images[4] = Chip4;
        images[5] = Chip5;
        images[6] = Chip6;
        images[7] = Chip7;
        images[8] = Chip8;
        images[9] = Chip9;
        images[10] = Chip10;
        images[11] = Chip11;
        images[12] = Chip12;
        images[13] = Chip13;
        images[14] = Chip14;
        images[15] = Chip15;
        images[16] = Chip16;
        images[17] = Chip17;
        images[18] = Chip18;
        images[19] = Chip19;
        images[20] = Chip20;
        images[21] = Chip21;
    }
}
