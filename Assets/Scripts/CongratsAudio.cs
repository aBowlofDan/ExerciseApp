using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratsAudio : MonoBehaviour
{
    //Audio
    public AudioClip cheerSoundEffect;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //gets the audio source component and sets the clip to chosen sound effect
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = cheerSoundEffect;

        //plays audio clip
        audioSource.Play();
        
    }
}
