using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerStart : MonoBehaviour
{
    public void TirggerStart() {
      SceneManager.LoadScene("start");
    }
}
