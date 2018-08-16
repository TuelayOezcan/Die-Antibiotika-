using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillen_bewegen : MonoBehaviour {

    public float moveSpeed;

    //public float speed;
    
	void Start ()
    {
        moveSpeed = 1f;     
	}
	
	
	void Update ()
    {
        
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical"));

        /*
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
        */
    }
}


