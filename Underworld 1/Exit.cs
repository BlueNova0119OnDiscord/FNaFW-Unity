using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public int exitX;
    public int exitY;

    void OnTriggerEnter2D(Collider2D collision)
    {
        fnafw1.saveXValue(exitX);
        fnafw1.saveYValue(exitY);
        fnafw1.newstart = true;
        SceneManager.LoadScene(scenes.Loading);
    }
}
