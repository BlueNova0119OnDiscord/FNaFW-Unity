using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public int Value;
    public float Speed;
    private float Direction;

    public Vector2 lastMove;
    private Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        Speed = ((75 + Random.Range(25, 75)) * 1.25f);
        Direction = Random.Range(1, 3);
        if (Direction == 1)
        {
            if (Value != 100)
                gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, 90f, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
            Direction = -1f;
        }
        else
        {
            if (Value != 100)
                gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, 0f, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
            Direction = 1f;
        }
    }

    void Update()
    {
        myBody.velocity = new Vector2(Direction * Speed, myBody.velocity.y);
        lastMove = new Vector2(Direction, 0f);
    }

    public void changeDirection()
    {

        if (Direction == 1)
        {
            if (Value != 100)
                gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, 90f, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
            Direction = -1f;
        }
        else
        {
            if (Value != 100)
                gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, 0f, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
            Direction = 1f;
        }
    }
}
