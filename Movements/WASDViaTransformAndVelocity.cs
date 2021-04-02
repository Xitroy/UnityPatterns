using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDViaTransformAndVelocity : MonoBehaviour
{
    public float speed;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    void Update () 
    {
        if (Input.GetKey ("w")) {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey ("s")) {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey ("d")) {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey ("a")) {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
