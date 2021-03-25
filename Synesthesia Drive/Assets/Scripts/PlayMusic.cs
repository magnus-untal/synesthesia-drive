using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
       Invoke("playAudio", 4.0f); 
    }

    void playAudio()
    {
        myAudio.Play();
    }
}
