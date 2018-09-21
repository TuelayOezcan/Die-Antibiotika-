
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{

    float gravityForce = -10;

    public void ApplyGravity(Transform reciever)
    {

        Rigidbody rb = reciever.GetComponent<Rigidbody>();
        //Rigidbody kraft zufügen die das ganze Objekt an den Planeten 
        //herandrückt

        //Zeigt von dem Planeten zur Transformkomponente des Resivers
        Vector3 forceUp = reciever.position - transform.position; 
        Vector3 dir;
        //egal wie groß die Kraft tatsächlich ist von forceUp, wir normalisieren 
        //sie auf eine Vectorlänge von 1 damit haben wir wirklich nur noch
        //eine Richtung für den Vector für diese Richtung und die tatsächliche
        //höhe für dieses Vectors wird durch gravityForce (-10) bestimmt.
        dir = gravityForce * forceUp.normalized;

        rb.AddForce(dir);
        //Wo zeigt aktuell seine Y-Achse hin 
        Vector3 reciverUp = reciever.up;

        //Rotation bestimmen die dafür sorgt, das er Richtig auf dem Planeten draufsteht
        Quaternion rot = Quaternion.FromToRotation(reciverUp, forceUp) * reciever.rotation;

        reciever.rotation = rot;
    }

}