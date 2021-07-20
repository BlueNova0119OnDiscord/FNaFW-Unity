using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGByteUnlock : MonoBehaviour
{
    public Button Unlock;
    public DEBUGByteID CharacterID;

    // Start is called before the first frame update
    void Start()
    {
        Unlock.GetComponent<Button>().onClick.AddListener(unlockID);

    }

    void unlockID()
    {
        fnafw1.saveByteValue(1, CharacterID.characterID);
    }
}
