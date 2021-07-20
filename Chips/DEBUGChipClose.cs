using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DEBUGChipClose : MonoBehaviour
{
    public Button close;
    public GameObject debugMenu;

    void Start()
    {
        close.GetComponent<Button>().onClick.AddListener(closeMenu);
    }

    void closeMenu()
    {
        debugMenu.SetActive(false);
        SceneManager.LoadScene(scenes.Chips);
    }
}
