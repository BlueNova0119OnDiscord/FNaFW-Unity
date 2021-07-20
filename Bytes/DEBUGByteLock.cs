using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGByteLock : MonoBehaviour
{
    public Button Lock;
    public DEBUGByteID CharacterID;

    // Start is called before the first frame update
    void Start()
    {
        Lock.GetComponent<Button>().onClick.AddListener(lockID);

    }

    void lockID()
    {
        fnafw1.saveByteValue(0, CharacterID.characterID);
    }
}
