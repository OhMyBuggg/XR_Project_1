using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeplayer : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
       //Player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = Input.GetAxis("Jump");
        Player.transform.position += new Vector3(movehorizontal, moveJump, -moveVertical);
        Player.transform.eulerAngles = new Vector3(0, 0, 0);
        //Player.AddForce(movement);
    }
}
