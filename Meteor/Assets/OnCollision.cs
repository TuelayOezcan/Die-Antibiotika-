using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

    //Gibt auf der Konsole aus, wann Kollision anfängt

	void OnCollisionEnter(Collision collision)
	{
        Debug.Log("Enter called");
	}

    //

	void OnCollisionStay(Collision collision)
	{
        Debug.Log("Stay occuring");
	}

    //

	void OnCollisionExit(Collision collision)
	{
        Debug.Log("Exit called");
	}

}
