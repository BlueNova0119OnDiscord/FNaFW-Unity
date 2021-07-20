using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartWait());
        info.saveValue("first", 1);
    }

    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(43);
        GoToTitleScreen();
    }

    void GoToTitleScreen()
    {
        SceneManager.LoadScene(scenes.IntroStatic);
    }
}
