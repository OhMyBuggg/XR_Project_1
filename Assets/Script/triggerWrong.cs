using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWrong : MonoBehaviour
{
    AudioSource wrongSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pig")
        {
            wrongSound = GetComponent<AudioSource>();
            wrongSound.Play();
        }
    }
}
