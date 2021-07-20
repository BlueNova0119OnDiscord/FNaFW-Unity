using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Erase : MonoBehaviour
{
    public Button currentSlot;
    public Animator slotAnimator;
    public GameObject otherSlot1;
    public GameObject currentFrame;
    public GameObject title;

    public GameObject nextFrame;

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
        otherSlot1.SetActive(false);
        title.SetActive(false);
        fnafw1.resetSave();
        StartCoroutine(GotoFrame());
    }

    IEnumerator GotoFrame()
    {
        yield return new WaitForSeconds(0.3f);
        currentFrame.SetActive(false);
        nextFrame.SetActive(true);

        FileSetupControllerInput.on = 4;
        FileSetupControllerInput.selected = 2;
        FileSetupControllerInput.min = 2;

        ControllerInput.Selection(2);
    }
}
