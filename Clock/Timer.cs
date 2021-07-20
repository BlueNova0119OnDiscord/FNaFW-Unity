using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private int Time = 11;
    private Text TextTime;

    public bool Done;

    void Start()
    {
        TextTime = gameObject.GetComponent<Text>();

        StartCoroutine(countDown());
    }

    IEnumerator countDown()
    {
        while (Time > 0)
        {
            Time -= 1;
            TextTime.text = Time.ToString();
            yield return new WaitForSeconds(1);
        }
        if (Done == true)
        {
            fnafw1.saveClockValue((fnafw1.clock += 1));
        }
        else
        {
            fnafw1.saveClockValue(0);
        }
        SceneManager.LoadScene(scenes.Loading);
    }
}
