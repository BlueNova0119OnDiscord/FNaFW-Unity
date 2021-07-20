using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipChest : MonoBehaviour
{
    public int chipID = 1;
    public GameObject chipObtained;
    public string animationName;
    public AudioSource soundEffect;

    public PlayerMovement Character;
    public Sprite playerIdleSprite;

    void Start()
    {
        fnafw1.loadChipValue(chipID);
        if (fnafw1.chip[chipID] == 1)
        {
            gameObject.SetActive(false);
        }
        //print(fnafw1.chip[chipID]);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (fnafw1.glitched == 0)
        {
            StartCoroutine(onCollide());
        }
    }

    IEnumerator onCollide()
    {
        float i = Character.moveSpeed;
        SpriteRenderer image = gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
        BoxCollider2D collider = gameObject.GetComponent("BoxCollider2D") as BoxCollider2D;
        Animator animator = chipObtained.GetComponent("Animator") as Animator;
        chipObtained.SetActive(true);
        animator.Play(animationName);
        soundEffect.Play();
        fnafw1.saveChipValue(1, chipID);
        image.enabled = false;
        collider.enabled = false;
        Character.moveSpeed = 0;
        Animator animator1 = Character.gameObject.GetComponent("Animator") as Animator;
        animator1.enabled = false;
        SpriteRenderer CharSprite = Character.gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
        CharSprite.sprite = playerIdleSprite;
        yield return new WaitForSeconds(2.5f);
        chipObtained.SetActive(false);
        gameObject.SetActive(false);
        animator1.enabled = true;
        Character.moveSpeed = i;
    }
}
