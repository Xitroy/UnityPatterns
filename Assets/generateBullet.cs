using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float nextActionTime = 0.0f;
    public float period;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
 
 void Update () {
     if (Time.time > nextActionTime ) {
        nextActionTime += period;
        GameObject bullet = (GameObject)GameObject.Instantiate(bulletPrefab, new Vector3(transform.position.x - 1, transform.position.y + 1, transform.position.z), Quaternion.identity);
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        Quaternion rotation = Quaternion.Euler(transform.rotation.eulerAngles);
        Vector3 forceDirection = rotation * Vector3.up;
        // Стрельба через силу
        rb.AddForce(forceDirection * 500);
     }

 }
}
