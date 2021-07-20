using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnterGlitched : MonoBehaviour
{
    public GameObject NormalCollision;
    public GameObject GlitchCollision;

    public PlayerMovement Character;

    public TMP_Text GlitchedText;
    public TMP_Text GlitchedCounter;

    private float Colliding = 0;

    void Start()
    {
        fnafw1.loadGlitchedValue();
        if (fnafw1.glitched == 1)
        {
            NormalCollision.SetActive(false);
            GlitchCollision.SetActive(true);
            Character.z = -1009;
        }
    }

    void Update()
    {
        if (Colliding > 75)
        {
            fnafw1.saveGlitchedValue(1);
            GlitchedText.text = "Unlocked";
            NormalCollision.SetActive(false);
            GlitchCollision.SetActive(true);
            Character.z = -1009;
            fnafw1.saveXValue(Character.gameObject.transform.localPosition.x);
            fnafw1.saveYValue(Character.gameObject.transform.localPosition.y);
        }
        GlitchedCounter.text = Colliding.ToString();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (fnafw1.glitched == 0 && Input.GetAxisRaw("Vertical") > 0.6)
        {
            Colliding += 1;
        }
        else
        {
            Colliding = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Colliding = 0;
    }
}
