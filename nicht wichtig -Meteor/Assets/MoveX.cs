using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     //   transform.Translate(new Vector3(0, -speed, 0 * Time.deltaTime));
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		
	}

	private void OnCollisionStay(Collision collision)
	{
        Destroy(gameObject);
	}
}
