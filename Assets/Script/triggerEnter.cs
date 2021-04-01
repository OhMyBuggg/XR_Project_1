using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerEnter : MonoBehaviour
{
    public GameObject btn;
    AudioSource pigSound;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pig")
        {
            Destroy(other.gameObject);
            pigSound = GetComponent<AudioSource>();
            pigSound.Play();
            btn.SetActive(true);
        }

        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("xr_cubetest");
        }
    }
}
