using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(clip);
        }
    }
}
