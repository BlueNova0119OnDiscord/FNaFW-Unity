using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fredbear : MonoBehaviour
{
    public int[] x;
    public int[] y;

    public GameObject fredbear;
    public GameObject Character;

    void Start()
    {
        fnafw1.loadCineValue();
        fredbear.transform.localPosition = new Vector3(x[(int) (fnafw1.cine - 2)], y[(int) (fnafw1.cine - 2)]);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (fnafw1.glitched == 0)
        {
            fnafw1.saveXValue(Character.transform.localPosition.x);
            fnafw1.saveYValue(Character.transform.localPosition.y);
            SceneManager.LoadScene(scenes.Fredbear);
        }
    }
}
