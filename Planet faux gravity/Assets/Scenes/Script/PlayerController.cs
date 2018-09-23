using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
     * Tülays Skript
     * Ergaenzungen von Bella, um Schwierigkeitsgrad zu erhoehen
     */

    public float speed = 8;
    float jumpPower = 300;
    bool isJumping = false;
    Rigidbody rb;

    //Ergaenzung: Zeit, bis die Geschwindigkeit erhoeht wird
    public float waitTime = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();


        //Ergaenzung: Einmaliger Aufruf in der Start-Methode
        StartCoroutine(SpeedUp());

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

    }

   
    //Ergaenzung: Alle 10 Sekunden wird die Geschwindigkeit erhoeht
    //Rekursive Methode
    IEnumerator SpeedUp(){
        yield return new WaitForSeconds(waitTime);
        speed += 0.1f;
        //Methode ruft sich selbst noch einmal auf, rekursiv
        StartCoroutine(SpeedUp());
    }

}
