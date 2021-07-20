using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginButtonClicked : MonoBehaviour
{
    public Button signIn;
    public GameJolt.Demo.Load.LoadTest doLoad;

    void Start()
    {
        signIn.onClick.AddListener(Clicked);
    }

    public void Clicked()
    {
        Image signInImage = signIn.GetComponent("Image") as Image;

        if (doLoad.LoggedIn == 1)
        {
            doLoad.SignOutButtonClicked();
        }
        else if (doLoad.LoggedIn == 0)
        {
            doLoad.SignInButtonClicked();
        }
    }
}
