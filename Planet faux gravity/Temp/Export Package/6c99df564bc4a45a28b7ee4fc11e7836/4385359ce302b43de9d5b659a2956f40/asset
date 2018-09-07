
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{

    float gravityForce = -10;

    public void ApplyGravity(Transform reciever)
    {

        Rigidbody rb = reciever.GetComponent<Rigidbody>();
        Vector3 forceUp = reciever.position - transform.position;
        Vector3 dir;
        dir = gravityForce * forceUp.normalized;

        rb.AddForce(dir);
        Vector3 reciverUp = reciever.up;

        Quaternion rot = Quaternion.FromToRotation(reciverUp, forceUp) * reciever.rotation;

        reciever.rotation = rot;
    }

}