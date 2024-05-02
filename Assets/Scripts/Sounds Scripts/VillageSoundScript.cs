using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageSoundScript : MonoBehaviour
{
    public AudioSource MusicBackground;

    private void Start()
    {
        MusicBackground.Play();
    }
}
