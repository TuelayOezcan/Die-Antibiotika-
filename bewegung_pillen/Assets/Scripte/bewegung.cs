using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bewegung : MonoBehaviour {

    public Transform startMarker;
    public Transform endMarker;

    public float speed = 1.0f;
    private float startTime;
    private float journeyLength; 

    //public Transform targetTransform; //Zielposition 
    //public float interpolationTime = 0.0f; //Argument um Objekt zu bewegen, startet bei 0 -> lerp
    //public float delay = 2.0f; //parameter delay, Vektor Source interpoliert zu Vektor Target in 2 Sek

    //private Vector3 sourcePosition; //von welcher Position wir ausgehen
    //private Vector3 targetPosition; //zu welcher Position wir hin wollen

    void Start ()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

        //wird gespeichert sobald Spiel gestartet wird (Source und Target)
        //sourcePosition = transform.position; //lokale Transformtaion
        //targetPosition = targetTransform.position;
	}
	

	void Update ()
    {
        float distCovered = (Time.time - startTime) + speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);

        //MAGIE
        //interpolationTime += Time.deltaTime;
        //var newPos = Vector3.Lerp(sourcePosition, targetPosition, interpolationTime / delay); //neue Position
        //transform.position = newPos; //Objekt wo Script angeschlossen ist, dessen Position zuweisen zur neuen Position
      
    }
}

