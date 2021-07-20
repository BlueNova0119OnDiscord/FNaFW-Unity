using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGChipLock : MonoBehaviour
{
    public Button Lock;
    public DEBUGChipID CharacterID;

    // Start is called before the first frame update
    void Start()
    {
        Lock.GetComponent<Button>().onClick.AddListener(lockID);

    }

    void lockID()
    {
        fnafw1.saveChipValue(0, CharacterID.characterID);
    }
}
