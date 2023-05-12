using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource robotVoice;

    void Start()
    {
        robotVoice = GetComponent<AudioSource>();
    }

    public void VoiceStartTalking()
    {
        robotVoice.Play();
    }
}
