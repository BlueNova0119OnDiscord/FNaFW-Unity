using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotPress : MonoBehaviour
{
    public Button currentSlot;
    public GameObject data;
    public Animator slotAnimator;
    public GameObject otherSlot1;
    public GameObject otherSlot2;
    public GameObject currentFrame;
    public GameObject title;

    public GameObject nextFrame;

    public FileSetupControllerInput ControllerInput;

    void Start()
    {
        currentSlot.onClick.AddListener(Pressed);
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

        slotAnimator.SetTrigger("SlotPressed");
        otherSlot1.SetActive(false);
        otherSlot2.SetActive(false);
        data.SetActive(false);
        title.SetActive(false);
        StartCoroutine(GotoFrame());
    }

    IEnumerator GotoFrame()
    {
        yield return new WaitForSeconds(0.3f);
        currentFrame.SetActive(false);
        nextFrame.SetActive(true);

        FileSetupControllerInput.on = 2;
        FileSetupControllerInput.selected = 2;
        FileSetupControllerInput.max = 2;

        fnafw1.loadStartedValue();

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
