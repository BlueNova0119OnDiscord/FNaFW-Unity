using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEBUGLock : MonoBehaviour
{
    public Button Lock;
    public DEBUGID CharacterID;

    // Start is called before the first frame update
    void Start()
    {
        Lock.GetComponent<Button>().onClick.AddListener(lockID);

    }

    void lockID()
    {
        fnafw1.saveHaveValue(0, CharacterID.characterID);
    }
}
