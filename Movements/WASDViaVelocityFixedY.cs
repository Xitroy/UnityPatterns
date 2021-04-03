using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDViaVelocityFixedY : MonoBehaviour
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
        velocityVector = new Vector3(0, rb.velocity.y, 0);
        if (Input.GetKey(KeyCode.A))
        velocityVector.x += -speed;
        if (Input.GetKey(KeyCode.D))
        velocityVector.x += speed;
        if (Input.GetKey(KeyCode.W))
        velocityVector.z += speed;
        if (Input.GetKey(KeyCode.S))
        velocityVector.z += -speed;
        rb.velocity = velocityVector;
    }
}
