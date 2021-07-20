using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGChipUnlock : MonoBehaviour
{
    public Button Unlock;
    public DEBUGChipID CharacterID;

    // Start is called before the first frame update
    void Start()
    {
        Unlock.GetComponent<Button>().onClick.AddListener(unlockID);

    }

    void unlockID()
    {
        fnafw1.saveChipValue(1, CharacterID.characterID);
    }
}
