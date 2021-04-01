using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeHunt : MonoBehaviour
{
    public float delay_time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextSentence", delay_time);
    }

    public void NextSentence()
    {
        SceneManager.LoadScene("pigrun");
    }
}
