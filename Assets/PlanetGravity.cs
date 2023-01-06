using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{

    public GameObject objAttract;
    public bool orbit = false;
    public float G = 1f;
    private bool collided = false;

    private void Start()
    {
        if (orbit)
            Orbit();
    }

    private void FixedUpdate()
    {

        if (objAttract == null)
            return;

        if (collided)
            return;

        /* 
         * Newton's Law of Gravitation
         * F = Gm1m2 / r2
         * Newton's law of gravitation tells us that the magnitude of the gravitational 
         * force acting on each body is proportional to both m1 and m2 and inversely 
         * proportional to the square of the distance r between them.
         * Reference: https://www.nagwa.com/en/explainers/765154391754/
         */

        float objAttractMass = objAttract.GetComponent<Rigidbody>().mass;
        float planetMass = GetComponent<Rigidbody>().mass;
        float distance = Vector3.Distance(gameObject.transform.position, objAttract.transform.position);
        float force = G * (objAttractMass * planetMass) / (distance * distance);

        // Calculate direction
        Vector3 direction = transform.position - objAttract.transform.position;

        // Apply force
        objAttract.GetComponent<Rigidbody>().AddForce(direction.normalized * force);

        // Print direction
        // Debug.DrawRay(objAttract.transform.position, direction, Color.red);
        // Print velocity
        // Debug.DrawRay(objAttract.transform.position, objAttract.GetComponent<Rigidbody>().velocity, Color.blue);

    }

    private void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }

    void Orbit()
    {

        /*
         * Orbital Speed Equation
         * An object’s orbital speed, v, is given by the equation v = ?GM / r.
         * Where G is the universal gravitational constant, m is the mass of the
         * large object at the center of the orbit, and r is the orbital radius.  
         * Reference: https://www.nagwa.com/en/explainers/142168516704/
         */

        float planetMass = GetComponent<Rigidbody>().mass;
        float distance = Vector3.Distance(objAttract.transform.position, transform.position);
        objAttract.transform.LookAt(transform);
        Vector3 velocity = objAttract.transform.right * Mathf.Sqrt(G * planetMass / distance);
        objAttract.GetComponent<Rigidbody>().velocity = velocity;

    }

}
