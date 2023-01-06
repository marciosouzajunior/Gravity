using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z) * 10;
        transform.GetComponent<Rigidbody>().AddForce(movement);
    }
}
