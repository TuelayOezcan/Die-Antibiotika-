using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
     * Tülays Code
     */

    public float speed = 10;
    float jumpPower = 300;
    bool isJumping = false;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
            isJumping = true;
    }

    void FixedUpdate()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        rb.MovePosition(rb.position + transform.TransformDirection(dir) * speed * Time.deltaTime);

        if (isJumping)
        {
            rb.AddForce(transform.up * jumpPower);
            isJumping = false;
        }

        /*Ergänzung von Bella, um Schwierigkeitsgrad nach und nach zu erhoehen.
        */
        Invoke("SpeedUp", 10f);

    }

    //Geschwindigkeit erhoehen
    void SpeedUp(){
        speed += (float) 0.01;
    }

}
