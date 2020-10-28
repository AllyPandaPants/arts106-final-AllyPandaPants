using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip splashsound;
    public AudioSource audioS;
    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot auxInSnapshot;
    public AudioMixerSnapshot pubSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashsound);
        }
        if (other.CompareTag("TensionZone"))
        {
            auxInSnapshot.TransitionTo(0.5f);
        }
        if (other.CompareTag("IdleZone"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
        if(other.CompareTag("Pub"))
        {
            pubSnapshot.TransitionTo(0.5f);
        }
    }
}
