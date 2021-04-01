using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showEnd : MonoBehaviour
{
    public GameObject endScreen;
    public float delay_time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextSentence", delay_time);
    }

    public void NextSentence()
    {
        endScreen.SetActive(true);
    }
}
