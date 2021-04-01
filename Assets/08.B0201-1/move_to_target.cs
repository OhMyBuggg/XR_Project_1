using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_to_target : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target; 
    public float moveSpeed = 300.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.transform.position;
        Vector3 selfPos = this.transform.position;
        Vector3 dir = targetPos-selfPos;
        this.transform.forward = 10*dir;

        dir.Normalize();
        this.transform.position = this.transform.position +　dir*moveSpeed*Time.deltaTime;        
    }
}
