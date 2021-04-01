using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeWord : MonoBehaviour
{
    public GameObject word;
    public float delay_time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextSentence", delay_time);
    }

    public void NextSentence()
    {
        gameObject.SetActive(false);
        word.SetActive(true);
    }
}
