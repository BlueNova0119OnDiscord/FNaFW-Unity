using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPress : MonoBehaviour
{
    public Button currentSlot;
    public Animator slotAnimator;
    public GameObject otherSlot;
    public GameObject currentFrame;
    public GameObject nextFrame;
    public Animator doNotErase;
    public GameObject erase;
    public GameObject eraseTitle;

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

        slotAnimator.SetTrigger("SlotPressed");
        otherSlot.SetActive(false);
        StartCoroutine(GotoFrame());
    }

    IEnumerator GotoFrame()
    {
        yield return new WaitForSeconds(0.3f);
        currentFrame.SetActive(false);
        nextFrame.SetActive(true);
        erase.SetActive(true);
        eraseTitle.SetActive(true);

        FileSetupControllerInput.on = 3;
        FileSetupControllerInput.selected = 2;
        FileSetupControllerInput.min = 1;

        ControllerInput.Selection(2);
    }
}
