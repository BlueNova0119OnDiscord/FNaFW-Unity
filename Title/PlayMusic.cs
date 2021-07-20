using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMusic : MonoBehaviour
{
    public AudioSource Music;
    public int SceneMusic;

    public AudioClip OverworldTheme;
    public AudioClip UnderworldTheme1;
    public AudioClip FredbearTheme;
    public AudioClip EightBitTheme;
    public AudioClip GlitchedTheme;
    public AudioClip FishingTheme;

    public static bool EightBitFredbear = false;

    private int glitch = 0;

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Overworld 1")
        {
            if (fnafw1.glitched == 1 && glitch == 0)
            {
                SceneMusic = 0;
                glitch = 1;
            }
            else if (Music.clip == GlitchedTheme && fnafw1.glitched == 0)
            {
                SceneMusic = 0;
                glitch = 0;
            }

            if (SceneMusic != 1 || Music.clip != OverworldTheme && Music.clip != GlitchedTheme)
            {
                Music.clip = OverworldTheme;
                if (fnafw1.glitched == 1)
                {
                    Music.clip = GlitchedTheme;
                }
                SceneMusic = 1;
                Music.Play();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Underworld 1")
        {
            if (SceneMusic != 2 || Music.clip != UnderworldTheme1)
            {
                Music.clip = UnderworldTheme1;
                SceneMusic = 2;
                Music.Play();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Fredbear")
        {
            if (SceneMusic != 8 && EightBitFredbear == true)
            {
                Music.clip = EightBitTheme;
                SceneMusic = 8;
                Music.Play();
            }
            if (SceneMusic != 3 && SceneMusic != 8 || Music.clip != FredbearTheme && Music.clip != EightBitTheme && SceneMusic != 8)
            {
                Music.clip = FredbearTheme;
                SceneMusic = 3;
                Music.Play();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Lolbit")
        {
            if (SceneMusic != 4 || Music.clip != FredbearTheme)
            {
                Music.clip = FredbearTheme;
                SceneMusic = 4;
                Music.Play();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Mendo")
        {
            if (SceneMusic != 5 || Music.clip != FredbearTheme)
            {
                Music.clip = FredbearTheme;
                SceneMusic = 5;
                Music.Play();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Deedee")
        {
            if (SceneMusic != 6 || Music.clip != FredbearTheme)
            {
                Music.clip = FredbearTheme;
                SceneMusic = 6;
                Music.Play();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Fishing Hole")
        {
            if (SceneMusic != 7 || Music.clip != FishingTheme)
            {
                Music.clip = FishingTheme;
                SceneMusic = 7;
                Music.Play();
            }
        }
        else if (SceneMusic == 1)
        {
            SceneMusic = 0;
        }
    }

    void GetActiveScene()
    {

    }
}
