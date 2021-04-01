using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTalk : MonoBehaviour
{
    public GameObject talkUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
            talkUI.SetActive(true);
        }
    }
}
