using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kochkurve : MonoBehaviour
{
    GameObject turtle;

    void Start()
    {


        turtle = new GameObject("Schildi");
        turtle.transform.parent = this.transform;


        Koch(2, 4);
    }

    void Turn(float angle)
    {
        turtle.transform.eulerAngles += new Vector3(0, 0, angle);
    }

    void Move(float length)
    {
        turtle.transform.Translate(length / 2, 0, 0);

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(length, 0.005f, 0.005f);
        cube.transform.position = turtle.transform.position;
        cube.transform.eulerAngles = turtle.transform.eulerAngles;

        turtle.transform.Translate(length / 2, 0, 0);

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
            Turn(60);
            Koch(length / 3, n - 1);
            Turn(-120);
            Koch(length / 3, n - 1);
            Turn(60);
            Koch(length / 3, n - 1);
        }

    }
}