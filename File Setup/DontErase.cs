using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontErase : MonoBehaviour
{
    public Button currentSlot;
    public Animator slotAnimator;
    public GameObject otherSlot1;
    public GameObject currentFrame;
    public GameObject title;
    public GameObject nextFrame;
    public Animator newGame;
    public GameObject letsContinue;

    public FileSetupControllerInput ControllerInput;

    void Start()
    {
        Button btn = currentSlot.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Pressed);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && slotAnimator.GetBool("Selected") == true)
        {
            Pressed();
        }
    }

    void Pressed()
    {
        FileSetupControllerInput.on = 0;

        slotAnimator.SetTrigger("ButtonPressed");
        newGame.gameObject.SetActive(false);
        newGame.gameObject.SetActive(true);
        otherSlot1.SetActive(false);
        title.SetActive(false);
        StartCoroutine(GotoFrame());
    }

    IEnumerator GotoFrame()
    {
        yield return new WaitForSeconds(0.3f);
        currentFrame.SetActive(false);
        nextFrame.SetActive(true);
        letsContinue.SetActive(true);

        FileSetupControllerInput.on = 2;
        FileSetupControllerInput.selected = 2;

        if (fnafw1.started == 1)
        {
            FileSetupControllerInput.min = 1;
        }
        else
        {
            FileSetupControllerInput.min = 2;
        }

        ControllerInput.Selection(2);
    }
}
