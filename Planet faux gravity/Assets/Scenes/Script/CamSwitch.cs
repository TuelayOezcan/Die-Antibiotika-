using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Camera FPSCam;
    public Camera TPCam;

    public bool CameraSwitch = false;

    // Use this for initialization
    void Start()
    {
        FPSCam = (Camera)GameObject.FindGameObjectWithTag("FPSCam").GetComponent("Camera");
        Debug.Log(FPSCam.transform.position);
        Debug.Log("test");
        TPCam = (Camera)GameObject.FindGameObjectWithTag("TPCam").GetComponent("Camera");

        // Initial ist FPSCam aktiv.
        FPSCam.gameObject.SetActive(true);
        TPCam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("pressed button");
            CameraSwitch = !CameraSwitch;
        }

        if (CameraSwitch)
        {
            FPSCam.gameObject.SetActive(false);
            TPCam.gameObject.SetActive(true);
        }

        if (!CameraSwitch)
        {
            FPSCam.gameObject.SetActive(true);
            TPCam.gameObject.SetActive(false);
        }
    }
}