using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{

    public FauxGravityAttractor gravity;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        //useGravity deaktivieren, weil ich ja die Gravitationskraft selber erzeugen
        rb.useGravity = false;
        //Rotation einfriehren schließlich mache ich das ja auch in der ApplyGravity Funktion 
        rb.freezeRotation = true;

    }

    //FixedUpdate wird von der Physikangen gesteuert und immer in den gleihen Abständen 
    //aufgerufen wird im gegensatz zum Update das Framebasiert funktuniert und weil ich eine
    //ApplyGravity Funtion eine Physikalische Kraft im Rigidbody hinzufüge. Dadurch habe ich keine
    //Probleme wenn sich die Framlänge mal ändern sollte.
    void FixedUpdate()
    {
        //Rufe die ApplyGravity Funktion auf und geben unser eigenes Transform dieser Funktion 
        gravity.ApplyGravity(transform);

    }
}