using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {

    }

    private void FixedUpdate()
    {

        if (player == null)
            return;

        // F = Gm1m2/r2
        // where F is the force due to gravity, between two masses (m1 and m2),
        // which are a distance r apart; G is the gravitational constant.

        float playerMass = player.GetComponent<Rigidbody>().mass; 
        float planetMass = GetComponent<Rigidbody>().mass;
        float distance = Vector3.Distance(transform.position, player.transform.position);
        float gConstant = 10f;
        float force = gConstant * (playerMass * planetMass) / (distance * distance);

        // Calculate
        Vector3 direction = gameObject.transform.position - player.transform.position;               
        Debug.DrawRay(player.transform.position, direction);
        direction.Normalize();

        // Move
        player.transform.position += direction * force * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
