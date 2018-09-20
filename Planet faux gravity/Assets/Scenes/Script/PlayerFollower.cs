using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour {

    public GameObject followObject;
    public float speed = 0.125f;
    public Vector3 offset;
    public Transform target;
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = smoothPosition;

        transform.LookAt(target);


       /* float interpolation = speed * Time.deltaTime;
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, followObject.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, followObject.transform.position.x, interpolation);
        position.z = Mathf.Lerp(this.transform.position.z, followObject.transform.position.z, interpolation);

        this.transform.position = position;

        //Object looks at what its following
       // transform.LookAt(target);
     //  transform.Translate(Vector3.forward * 5 * Time.deltaTime);*/



	}
}
