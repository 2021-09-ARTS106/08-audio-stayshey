using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class playeraudio : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioSource audioS;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }

        if(other.CompareTag("EnemyTrigger"))
        {

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
    }
}
