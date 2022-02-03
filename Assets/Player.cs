using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody myRigidbody;
    void Start()
    {
        muyRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        myRigidbody.velocity = new Vector3 (Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
