using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public Transform Character;
    public RectTransform MapPlayer;
    
    void Start()
    {

    }

    void Update()
    {
        //MapPlayer.position.Set((Character.position.x/10) + 200, (Character.position.y/10) + 50, MapPlayer.position.z);
        MapPlayer.position = new Vector3(((Character.position.x / 12.25f) + 545), ((Character.position.y / 12.25f) + 491));
        //MapPlayer.position = new Vector3(640, 360);
        //print((Character.transform.position.x / 10) + 200);
    }
}
