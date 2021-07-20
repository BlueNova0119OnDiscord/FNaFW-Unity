using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlankToTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartWait());
    }

    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(2);
        GoToTitleScreen();
    }

    void GoToTitleScreen()
    {
        SceneManager.LoadScene(scenes.Title);
    }
}
