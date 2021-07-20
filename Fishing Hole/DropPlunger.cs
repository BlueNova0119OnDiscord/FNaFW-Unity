using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropPlunger : MonoBehaviour
{
    private GameObject plunger;
    public FishMovement[] fish;
    public CharacterMovementFishing character;
    public Counter counter;
    public float Speed;

    public AudioSource Bling;
    public AudioSource Pop;

    private Rigidbody2D myBody;
    private bool dropping = true;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        plunger = gameObject;
    }

    public void Drop()
    {
        counter.dropping = true;
        character.moveSpeed = 0f;
        myBody.velocity = new Vector2(myBody.velocity.x, -1f * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.parent.gameObject.layer == 2 && dropping == true)
        {
            info.pendingtokens = info.pendingtokens + collider.gameObject.GetComponent<FishMovement>().Value;
            dropping = false;
            myBody.velocity = new Vector2(myBody.velocity.x, 0);
            Bling.Play();
            int i = 0;
            while (i < fish.Length)
            {
                fish[i].Speed = 0f;
                i++;
            }
            if (collider.gameObject.GetComponent<FishMovement>().Value == 100)
            {
                fnafw1.loadPearlsValue();
                fnafw1.savePearlsValue(fnafw1.pearls + 1);
                if (fnafw1.pearls > 4)
                {
                    info.savePearlValue(1);
                }
            }
        }
        else if (collider.name == "Floor" && dropping == true)
        {
            dropping = false;
            myBody.velocity = new Vector2(myBody.velocity.x, 0);
            Pop.Play();
            int i = 0;
            while (i < fish.Length)
            {
                fish[i].Speed = 0f;
                i++;
            }
        }
    }
}
