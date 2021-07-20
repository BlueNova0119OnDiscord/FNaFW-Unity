using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonDeedee : MonoBehaviour
{
    public Sprite HoverSprite;
    public LoadTokens TokensText;

    public GameObject ControllerIcon;

    public AudioSource Ching;

    private bool Pressed;

    void Start()
    {
        if (info.controllerinput == 1)
        {
            Hover();
        }

        Button btn = gameObject.GetComponent<Button>();

        btn.onClick.AddListener(Clicked);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && info.controllerinput == 1)
        {
            Clicked();
        }
    }

    void Clicked()
    {
        if (Pressed == false)
        {
            fnafw1.loadTokensValue();
            if (fnafw1.tokens > 9)
            {
                Ching.Play();
                Pressed = true;
                TokensText.Buy();
                fnafw1.saveTokensValue((fnafw1.tokens -= 10));
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scenes.Fishing);
    }

    public void Hover()
    {
        Image img = gameObject.GetComponent<Image>();

        img.sprite = HoverSprite;
        if (info.controllerinput == 1)
            ControllerIcon.SetActive(true);
    }
}
