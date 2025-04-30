using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool fadeout = false;

    public float TimeToFade;

    // Update is called once per frame
    void Update()
    {
        if(fadeout == true)
        {
            if(canvasGroup.alpha >=0)
            {
                canvasGroup.alpha -= TimeToFade * Time.deltaTime;
                if (canvasGroup.alpha == 0)
                {
                    fadeout = false;
                }
            }
        }
    }

    public void FadeOut()
    {
        fadeout = true;
    }
}
