using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public Button currentSlot;
    public Animator slotAnimator;
    public GameObject otherSlot;

    void Start()
    {
        Button btn = currentSlot.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Pressed);

        fnafw1.loadStartedValue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && slotAnimator.GetBool("Selected") == true)
        {
            Pressed();
        }

        if (fnafw1.started == 1 && slotAnimator.GetBool("On") == false)
        {
            slotAnimator.SetBool("On", true);
        }
    }

    void Pressed()
    {
        slotAnimator.SetTrigger("SlotPressed");
        otherSlot.SetActive(false);
        StartCoroutine(GotoFrame());
    }

    IEnumerator GotoFrame()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(scenes.CharacterSelect);
    }

}
