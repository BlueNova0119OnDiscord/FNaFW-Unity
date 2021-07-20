using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTokenChests : MonoBehaviour
{
    public Transform[] SpawnLocs;
    public GameObject tokenChest;
    public GameObject goldChest;

    void Start()
    {
        int Do = Random.Range(0,30);
        if (Do < 16)
        {

            int affectedLocs = Random.Range(0, 5);
            int i = 1;

            while (i < affectedLocs + 1)
            {
                int random = Random.Range(1, SpawnLocs.Length);

                float x = SpawnLocs[random].position.x;
                float y = SpawnLocs[random].position.y;

                int chestChance = Random.Range(1, 20);
                if (chestChance == 10)
                    Instantiate(goldChest, new Vector3(x, y), Quaternion.identity);
                else
                    Instantiate(tokenChest, new Vector3(x, y), Quaternion.identity);

                i++;
            }
        }
    }
}
