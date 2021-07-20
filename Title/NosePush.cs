using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class NosePush : MonoBehaviour
{
    public AudioClip honk;
    public Button nose;

    void Start()
    {
        Button btn = nose.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(HonkOnClick);
    } 

    void HonkOnClick()
    {
        StartCoroutine(HonkPls());
    }

    IEnumerator HonkPls()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
    }
}
