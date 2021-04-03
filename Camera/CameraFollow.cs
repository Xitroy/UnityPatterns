using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    private Vector3 delta;

    // Start is called before the first frame update
    void Start()
    {
        delta = transform.position - followTarget.position;
        print(delta);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = followTarget.position + delta;
    }
}
