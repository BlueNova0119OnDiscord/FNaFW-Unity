using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementFishing : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 lastMove;
    public Transform plunger;

    public float changex;
    public float changey;

    private Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

        Vector3 plungepos = plunger.position;
        plungepos = new Vector3(transform.position.x - changex, transform.position.y + changey);
        plunger.position = plungepos;
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;

        Vector3 plungepos = plunger.position;
        plungepos = new Vector3(pos.x - changex, plunger.position.y);
        plunger.position = plungepos;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            myBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myBody.velocity.y);
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myBody.velocity = new Vector2(0f, myBody.velocity.y);
        }
    }
}
