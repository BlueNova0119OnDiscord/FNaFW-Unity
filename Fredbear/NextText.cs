using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextText : MonoBehaviour
{
    public GameObject arrow;
    public GameObject box;
    public GameObject nextArrow;
    public Text text;
    public Button done;

    public GameObject background;
    public GameObject fredbear;
    public GameObject bitfred;

    public Animator Spinning;
    public GameObject buttonStart;

    private bool Progressing = false;
    public TextAtlas textAtlas;

    private int CurrentAtlas = 1;
    private int CurrentText = 0;
    private int MaxText = 100;

    void Start()
    {
        CheckCine();
        //print(fnafw1.cine);
        StartCoroutine(ProgressText());
        if (info.controllerinput == 1)
        {
            buttonStart.SetActive(true);
        }
        PlayMusic.EightBitFredbear = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Progressing == false && CurrentText < (MaxText + 1) && bitfred.activeInHierarchy == false)
        {
            StartCoroutine(ProgressText());
        }

        if (info.controllerinput == 1)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0) && Progressing == false && CurrentText < (MaxText + 1) && bitfred.activeInHierarchy == false)
            {
                StartCoroutine(ProgressText());
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton7) && done.gameObject.activeInHierarchy == true)
            {
                Done();
            }
        }
    }

    private void CheckCine()
    {
        fnafw1.loadCineValue();
        CurrentAtlas = (int) fnafw1.cine;
        //print(textAtlas.Dialogues[CurrentAtlas].Capacity);
        MaxText = (textAtlas.Dialogues[CurrentAtlas].Capacity - 1);
    }

    IEnumerator ProgressText()
    {
        if (CurrentText == MaxText)
        {
            StartCoroutine(FinalText());
        }
        else
        {
            Progressing = true;

            arrow.SetActive(false);
            box.SetActive(false);
            nextArrow.SetActive(false);
            text.gameObject.SetActive(false);

            box.SetActive(true);
            yield return new WaitForSeconds(0.28f);
            arrow.SetActive(true);
            text.gameObject.SetActive(true);

            text.text = textAtlas.Dialogues[CurrentAtlas][CurrentText];
            CurrentText++;

            yield return new WaitForSeconds(1.6f);
            nextArrow.SetActive(true);
            if (info.controllerinput == 1)
            {
                Spinning.SetBool("Controller", true);
            }

            Progressing = false;
        }
    }

    IEnumerator FinalText()
    {
        CurrentText++;

        arrow.SetActive(false);
        box.SetActive(false);
        nextArrow.SetActive(false);
        text.gameObject.SetActive(false);

        box.SetActive(true);
        yield return new WaitForSeconds(0.28f);
        arrow.SetActive(true);
        text.gameObject.SetActive(true);
        done.gameObject.SetActive(true);
        done.onClick.AddListener(Done);

        text.text = textAtlas.Dialogues[CurrentAtlas][CurrentText - 1];

        yield return new WaitForSeconds(7);
        StartCoroutine(EightBit());
    }

    private void Done()
    {
        fnafw1.saveCineValue((fnafw1.cine + 1));
        SceneManager.LoadScene(scenes.Loading);
    }

    IEnumerator EightBit()
    {
        PlayMusic.EightBitFredbear = true;
        MaxText = textAtlas.ClockDialogues[CurrentAtlas].Capacity;
        CurrentText = 0;
        background.SetActive(false);
        fredbear.SetActive(false);
        bitfred.SetActive(true);

        while (CurrentText != MaxText)
        {
            arrow.SetActive(false);
            box.SetActive(false);
            nextArrow.SetActive(false);
            text.gameObject.SetActive(false);
            done.gameObject.SetActive(false);

            box.SetActive(true);
            yield return new WaitForSeconds(0.28f);
            arrow.SetActive(true);
            text.gameObject.SetActive(true);

            text.text = textAtlas.ClockDialogues[CurrentAtlas][CurrentText];
            CurrentText++;

            yield return new WaitForSeconds(6.6f);
        }

        fnafw1.saveCineValue((fnafw1.cine + 1));
        SceneManager.LoadScene(scenes.Loading);
    }
}
