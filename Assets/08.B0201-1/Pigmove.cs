using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigmove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    void Start()
    {
        gameObject.transform.localRotation = Quaternion.Euler (new Vector3(-4.509f, 86.0f, -10.0f));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = gameObject.transform.localPosition;
        Vector3 Rot = gameObject.transform.localRotation.eulerAngles;
        System.Random r = new System.Random();
        float num = r.Next(0, 3);//隨機生成一個5位整數
        Debug.Log(num);
        if(Pos.x > 50){
            speed = -0.3f;
            gameObject.transform.localRotation = Quaternion.Euler (new Vector3(Rot.x, -94.0f, 10.0f));
        }
        else if(Pos.x < -50)
        {
            speed = 0.3f;
            gameObject.transform.localRotation = Quaternion.Euler (new Vector3(Rot.x, 86.0f, -10.0f));
        }
        gameObject.transform.localPosition = new Vector3(Pos.x + speed*num, Pos.y, Pos.z);
    }
}
