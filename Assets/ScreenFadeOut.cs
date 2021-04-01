using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScreenFadeOut : MonoBehaviour
{
    public float faderSpeed = 1.5f;
    Image image;
    bool sceneStart = true;
    bool sceneEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneStart)
        {
            StartScene();
        }
        
    }
    void StartScene(){
        FadeToClear();
        if(image.color.a<0.1f)
        {
            sceneStart = false;
        }
    }
    void FadeToClear(){
        image.color = Color.Lerp(image.color,Color.clear,faderSpeed);
    }
}
