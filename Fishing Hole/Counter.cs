using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    private TMP_Text counter;
    private int timer = 60;
    public bool dropping = false;

    void Start()
    {
        counter = gameObject.GetComponent<TMP_Text>();
        counter.text = timer.ToString();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timer > 0 && dropping == false)
        {
            timer -= 1;
            counter.text = timer.ToString();
            yield return new WaitForSeconds(1);
        }
        if (dropping == true)
        {
            timer = 3;
            while (timer > 0)
            {
                timer -= 1;
                yield return new WaitForSeconds(1);
            }
        }
        SceneManager.LoadScene(scenes.Loading);
    }
}
