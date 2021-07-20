using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlitchedObject : MonoBehaviour
{
    public int World = 1;
    [SerializeField] SpriteRenderer SpriteColor;

    public float x;
    public float y;

    void Start()
    {
        StartCoroutine(Flicker());
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (World == 1 && fnafw1.glitched == 0)
        {
            fnafw1.saveUnderworldXValue(x);
            fnafw1.saveUnderworldYValue(y);
            print($"x {fnafw1.underworldx}, y {fnafw1.underworldy}");
            SceneManager.LoadScene(scenes.Underworld1);
        }
        else if (World == 3 && fnafw1.glitched == 0)
        {
            print($"Woosh Woosh Woosh Teleport to World {World + 1}.");
        }
        else if (World == 4 && fnafw1.glitched == 0)
        {
            print($"Woosh Woosh Woosh Teleport to World {World + 1}.");
        }
        else if (World == 5 && fnafw1.glitched == 0)
        {
            print($"Woosh Woosh Woosh Teleport to World {World + 1}.");
        }
        else if (World == 6 && fnafw1.glitched == 0)
        {
            print($"Woosh Woosh Woosh Teleport to World 4 for Key.");
        }
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.05f);
            float random = Random.Range(0, 6);
            float random2 = Random.Range(0, 10);
            SpriteColor.color = new Color(1, 1, 1, ((random * 20) + 50) / 255);
            if (random2 == 5)
            {
                SpriteColor.color = new Color(1, 1, 1, (200 + 50) / 255);
            }
        }
    }
}
