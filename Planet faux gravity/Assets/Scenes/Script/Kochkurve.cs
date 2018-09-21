using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kochkurve : MonoBehaviour
{
    // Turlte läuft Pfad entlang
    GameObject turtle;

    // Root Transform für ein fertiges Fraktal
    GameObject root;

    // schleifenzähler
    private int i;

    // Material für ein Segment (Cube)
    public Material mat;

    // Settings für Fraktale (Segmente)
    int iterationsTiefe;
    int segmentLaenge;
    int fraktalAuswahl;

    // Anzahl an vorhanden Fraktalen
    int fraktalAnzahl = 75;

    // Liste für Root-Objekte
    List<GameObject> rootListe = new List<GameObject>();


    void Start()
    {

        Random.seed = 12;

        turtle = new GameObject("Schildi");
        turtle.transform.parent = this.transform;

        for (i = 0; i < fraktalAnzahl; i++)
        {
            // Auswürfeln der Fraktalsettings
            iterationsTiefe = (int)Random.Range(1, 2);  // 2-3
            segmentLaenge = (int)Random.Range(1, 5);   // 1-4
            fraktalAuswahl = (int)Random.Range(1, 4);  // 1-3

            turtle.transform.position = Vector3.zero;

            root = new GameObject("root");
            root.transform.parent = this.transform;

            // Fraktale erzeugen
            if (fraktalAuswahl == 1)
            {
                Koch(segmentLaenge, iterationsTiefe);
                Turn(120);
                Koch(segmentLaenge, iterationsTiefe);
                Turn(120);
                Koch(segmentLaenge, iterationsTiefe);
            }
            else if (fraktalAuswahl == 2)
            {
                Koch1(segmentLaenge, iterationsTiefe);
                Turn(120);
                Koch1(segmentLaenge, iterationsTiefe);
                Turn(120);
                Koch1(segmentLaenge, iterationsTiefe);
            }
            else
            {
                Koch2(segmentLaenge, iterationsTiefe);
                Turn(120);
                Koch2(segmentLaenge, iterationsTiefe);
                Turn(120);
                Koch2(segmentLaenge, iterationsTiefe);
            }

            Vector3 position = Random.onUnitSphere * Random.Range(10.0f, 20.0f);

            root.transform.position = position;

            root.transform.LookAt(Vector3.zero);

            rootListe.Add(root);
        }
    }

    void Turn(float angle)
    {
        turtle.transform.eulerAngles += new Vector3(0, 0, angle);
    }

    void Move(float length)
    {
        turtle.transform.Translate(length / 2, 0, 0);

        // Initialisieren des Segments
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Skalieren des Segments
        cube.transform.localScale = new Vector3(length, 0.025f, 0.025f);

        // Positionirung des Segments
        cube.transform.position = turtle.transform.position;

        // Orientierung des Semgment
        cube.transform.eulerAngles = turtle.transform.eulerAngles;

        // Material zuweisen
        cube.GetComponent<Renderer>().material = mat;

        // BoxCollider deaktivieren (keine Kollision mit Fraktalen)
        cube.GetComponent<BoxCollider>().enabled = false;

        turtle.transform.Translate(length / 2, 0, 0);

        // Jedes Segment wird als Kind der Root hinzugefügt
        cube.transform.parent = root.transform;

    }

    void Koch(float length, float n)
    {
        //Debug.Log(length + " n: " + n);
        if (n == 0)
        {
            Move(length);
        }
        else
        {
            Koch(length / 3, n - 1);
            Turn(-60);
            Koch(length / 3, n - 1);
            Turn(120);
            Koch(length / 3, n - 1);
            Turn(-60);
            Koch(length / 3, n - 1);
        }

    }

    void Koch1(float length, float n)
    {
        //Debug.Log(length + " n: " + n);
        if (n == 0)
        {
            Move(length);
        }
        else
        {
            Koch(length / 3, n - 1);
            Turn(-90);
            Koch(length / 3, n - 1);
            Turn(180);
            Koch(length / 3, n - 1);
            Turn(-90);
            Koch(length / 3, n - 1);
        }

    }

    void Koch2(float length, float n)
    {
        //Debug.Log(length + " n: " + n);
        if (n == 0)
        {
            Move(length);
        }
        else
        {
            Koch(length / 3, n - 1);
            Turn(60);
            Koch(length / 3, n - 1);
            Turn(-120);
            Koch(length / 3, n - 1);
            Turn(60);
            Koch(length / 3, n - 1);
        }

    }
    //Fraktale drehen sich 
    private void Update()
    {
        for (int i = 0; i < rootListe.Count; i++)
        {
            if (i % 2 == 0)
                rootListe[i].transform.rotation *= Quaternion.Euler(0, 0.075f, 0);
            else
                rootListe[i].transform.rotation *= Quaternion.Euler(0, -0.075f, 0);
        }
    }
}