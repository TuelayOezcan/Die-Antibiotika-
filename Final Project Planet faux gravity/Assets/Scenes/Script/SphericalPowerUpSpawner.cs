using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalPowerUpSpawner : MonoBehaviour {

    public GameObject speedPowerUpPrefab;
    //public GameObject defensePowerUpPrefab;
  //  public GameObject meteorPowerUpPrefab;
	// Use this for initialization
	void Start () {


//Schleife fuer Speed Poweup
        for (int i = 0; i < 15; i++)
        {
            //Zufallspunkt auf der Sphere
            Vector3 pos = Random.onUnitSphere * 8.2f;
            Vector3 normale = pos;
            Vector3 tangente = normale;
            Vector3.OrthoNormalize(ref normale, ref tangente);
            //Rotation
            Quaternion rotation = Quaternion.LookRotation(tangente, normale);
            // rotation *= Quaternion.Euler(-90, 0, 0);
            //In Gameobject casten
            GameObject powerUPOne = (GameObject)Instantiate(speedPowerUpPrefab, pos, rotation);
            powerUPOne.transform.parent = this.transform;
            // meteor.transform.parent = this.transform;
        }
        /*
        //Schleife fuer Meteor
        for (int i = 0; i < 1; i++)
        {
            Vector3 pos = Random.onUnitSphere * 8.5f;
            Vector3 normale = pos;
            Vector3 tangente = normale;
            Vector3.OrthoNormalize(ref normale, ref tangente);
            //Rotation
            Quaternion rotation = Quaternion.LookRotation(tangente, normale);
            GameObject powerUPThree = (GameObject)Instantiate(meteorPowerUpPrefab, pos, rotation);
        }
        */
    }

    // Update is called once per frame
    void Update () {
		
	}

}
