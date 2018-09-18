using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bewegung : MonoBehaviour
{

    private Vector3 startMarker;
    private Vector3 endMarker;

    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;

    //public float delay = 5.0f;
    private float yieldTimeMin = 2.0f;
    private float yieldTimeMax = 5.0f;


    private int rand;

    //public Transform targetTransform; //Zielposition 
    //public float interpolationTime = 0.0f; //Argument um Objekt zu bewegen, startet bei 0 -> lerp
    //public float delay = 2.0f; //parameter delay, Vektor Source interpoliert zu Vektor Target in 2 Sek

    //private Vector3 sourcePosition; //von welcher Position wir ausgehen
    //private Vector3 targetPosition; //zu welcher Position wir hin wollen

    //nach Zeitablauf wird zerstört
    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax)); 
        Destroy(gameObject);
    }

    void Start()
    {
        StartCoroutine(WaitAndDestroy());

        startMarker = Vector3.zero;
        endMarker = Vector3.zero;

        rand = Random.Range(0, 2);
        startTime = Time.time;
        startMarker = this.transform.position + new Vector3(-3f, 0f, 0f);
        endMarker = this.transform.position + new Vector3(3f, 0f, 0f);
        journeyLength = Vector3.Distance(startMarker, endMarker);

        //wird gespeichert sobald Spiel gestartet wird (Source und Target)
        //sourcePosition = transform.position; //lokale Transformtaion
        //targetPosition = targetTransform.position;
    }


    void Update()
    {

        float distCovered = (Time.time - startTime) + speed;
        float fracJourney = distCovered / journeyLength;

        if(rand == 0)
            transform.position = Vector3.Lerp(startMarker, endMarker, fracJourney);
        
        if(rand == 1)
            transform.position = Vector3.Lerp(endMarker, startMarker, fracJourney);

        //MAGIE
        //interpolationTime += Time.deltaTime;
        //var newPos = Vector3.Lerp(sourcePosition, targetPosition, interpolationTime / delay); //neue Position
        //transform.position = newPos; //Objekt wo Script angeschlossen ist, dessen Position zuweisen zur neuen Position

    }
}





