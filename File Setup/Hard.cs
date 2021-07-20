using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hard : MonoBehaviour
{
    public Button currentSlot;
    public Animator slotAnimator;
    public GameObject otherSlot1;
    public GameObject title;

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
        StartCoroutine(GotoFrame());
    }

    IEnumerator GotoFrame()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scenes.CharacterSelect);
    }
}
