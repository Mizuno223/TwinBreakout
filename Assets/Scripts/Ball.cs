using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public float minSpeed = 5f;
    public float maxSpeed = 5f;
    Rigidbody myRigidbody;
    Transform myTransform;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3 (speed, speed, 0f);
        myTransform = transform;
    }

    void Update()
    {
        Vector3 velocity = myRigidbody.velocity;
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        myRigidbody.velocity = velocity.normalized * clampedSpeed;
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 playerPos = collision.transform.position;
            Vector3 ballPos = myTransform.position;
            Vector3 direction = (ballPos - playerPos).normalized;
            float speed = myRigidbody.velocity.magnitude;
            myRigidbody.velocity = direction * speed;
        } 
    }
}
