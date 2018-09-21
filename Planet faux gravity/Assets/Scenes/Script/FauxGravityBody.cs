using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{

    public FauxGravityAttractor gravity;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.freezeRotation = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gravity.ApplyGravity(transform);

    }
}