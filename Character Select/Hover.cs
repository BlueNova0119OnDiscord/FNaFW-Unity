using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    public IsUnlocked charUnlocked;

    public string Name = "Freddy";
    public string idleAnim = "FreddyIdle";
    public int level = 1;
    public int next = 200;
    public string attack1 = "Mic Toss";
    public string attack2 = "Mic Toss";
    public string attack3 = "Mic Toss";

    public GameObject info;

    public Text nameText;
    public Animator animImage;
    public Text levelText;
    public Text nextText;
    public Animator att1Image;
    public Animator att2Image;
    public Animator att3Image;

    public void OnHover()
    {
        if (charUnlocked.unlocked == 1f)
        {
            info.SetActive(true);

            nameText.text = Name;
            animImage.Play(idleAnim, 0);
            levelText.text = level.ToString();
            nextText.text = next.ToString();
            att1Image.Play(attack1, 0);
            att2Image.Play(attack2, 0);
            att3Image.Play(attack3, 0);
        }
    }

    public void OnExit()
    {
        info.SetActive(false);
    }
}
