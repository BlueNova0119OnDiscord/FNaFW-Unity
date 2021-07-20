using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockJump : MonoBehaviour
{
    public float[] SpawnX;
    public float[] SpawnY;
    public Transform Character;

    void Start()
    {
        fnafw1.loadClockValue();
        if (fnafw1.clock > 0)
        {
            gameObject.transform.localPosition = new Vector3(SpawnX[(int) (fnafw1.clock - 1)], SpawnY[(int) (fnafw1.clock - 1)], 325.61f);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (fnafw1.glitched == 0)
        {
            fnafw1.saveXValue(Character.localPosition.x);
            fnafw1.saveYValue(Character.localPosition.y);
            SceneManager.LoadScene(scenes.Clock);
        }
    }
}
