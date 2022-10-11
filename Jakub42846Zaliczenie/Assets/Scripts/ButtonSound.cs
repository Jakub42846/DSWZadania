using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void PlayHover()
    {
        myFx.PlayOneShot(hoverSound);
    }
    public void PlayClick()
    {
        myFx.PlayOneShot(clickSound);
    }
}
