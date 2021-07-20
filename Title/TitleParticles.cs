using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleParticles : MonoBehaviour
{
    public UIParticleSystem UIParticle;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        UIParticle.Play();
    }
}
