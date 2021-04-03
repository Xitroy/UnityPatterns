using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDViaVelocity : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    Vector3 velocityVector;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocityVector = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        velocityVector.x += -1;
        if (Input.GetKey(KeyCode.D))
        velocityVector.x += 1;
        if (Input.GetKey(KeyCode.W))
        velocityVector.z += 1;
        if (Input.GetKey(KeyCode.S))
        velocityVector.z += -1;
        rb.velocity = velocityVector*speed;
    }
}
