using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGUnlock : MonoBehaviour
{
    public Button Unlock;
    public DEBUGID CharacterID;

    // Start is called before the first frame update
    void Start()
    {
        Unlock.GetComponent<Button>().onClick.AddListener(unlockID);

    }

    void unlockID()
    {
        fnafw1.saveHaveValue(1, CharacterID.characterID);
    }
}
