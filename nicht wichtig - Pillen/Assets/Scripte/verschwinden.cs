using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verschwinden : MonoBehaviour {

    //Hierbei wird das erste mal 5 Sekunden gewartet und dann wird es jeden Frame ausgeführt


    IEnumerator Test()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("Done!");
    }

    void Update ()
    {
        StartCoroutine(Test());
    }

}
