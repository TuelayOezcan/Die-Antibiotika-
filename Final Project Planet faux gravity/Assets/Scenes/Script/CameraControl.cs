using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public float minimumValue = -5f;
    public float maximumValue = 10f;



    public enum RotationAxis
    {

        MouseX = 1,
        MouseY = 2,
    }

    public RotationAxis axes = RotationAxis.MouseX;
    public float sensHorizontal = 10f;
    public float sensVertical = 10f;

    public float _rotationX = 0;

	
	// Update is called once per frame
	void Update () {
		
        if (axes == RotationAxis.MouseX){
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);

        }

        else if (axes == RotationAxis.MouseY)
        { //
            _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
            //Befestigt die X Rotation zwischen minimalen und maximalen Wert
            _rotationX = Mathf.Clamp(_rotationX, minimumValue, maximumValue);

            //
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }



	}
}
