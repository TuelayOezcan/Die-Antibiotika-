var FPSCam : Camera;
var TPCam : Camera;

private var CamSwitch = false;

function Start()
{
    FPSCam.GetComponent(Camera).enabled = true;
    TPCam.GetComponent(Camera).enabled = false;
}

function Update()
{

    if (Input.GetKeyDown(KeyCode.1))
    {
        CamSwitch = !CamSwitch;
    }

    if (Camera == true)
    {
        FPSCam.GetComponent(Camera).enabled = false;
        TPCam.GetComponent(Camera).enabled = true;
    }

    else
    {
        FPSCam.GetComponent(Camera).enabled = true;
        TPCam.GetComponent(Camera).enabled = false;
    }
}