using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalPowerUpSpawner : MonoBehaviour {

    public GameObject powerUpPrefab;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < 25; i++)
        {
            //Zufallspunkt auf der Sphere
            Vector3 pos = Random.onUnitSphere * 8.5f;
            Vector3 normale = pos;
            Vector3 tangente = normale;
            Vector3.OrthoNormalize(ref normale, ref tangente);

            //Rotation
            Quaternion rotation = Quaternion.LookRotation(tangente, normale);
            // rotation *= Quaternion.Euler(-90, 0, 0);

            //In Gameobject casten
            GameObject powerUP = (GameObject)Instantiate(powerUpPrefab, pos, rotation);
            //powerUP.transform.position = pos;
            // meteor.transform.parent = this.transform;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
