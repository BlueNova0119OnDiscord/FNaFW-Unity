using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutTitle : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        StartCoroutine(StartWait());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FadeToTitleScreen();
        }
    }

    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(3);
        FadeToTitleScreen();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scenes.Load2);
    }

    public void FadeToTitleScreen()
    {
        animator.SetTrigger("FadeOutTitle");
    }
}
