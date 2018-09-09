using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour {
    
    public GameObject baumPrefab;

	// Use this for initialization
	void Start () {
        // Seed für Generator setzen (damit es zwar zufällig ist, aber diese einmal zufällig verteilten 
        // Bäume bei jedem Spielstart wieder an der selben Position sind).
        // https://docs.unity3d.com/530/Documentation/ScriptReference/Random-seed.html
        Random.seed = 22;

        for (int i = 0; i < 30; i++)
        {
            GameObject tmpBaum;

            //https://docs.unity3d.com/ScriptReference/Random-onUnitSphere.html
            // Zufallspunkt auf einer Einheitskugel
            Vector3 position = Random.onUnitSphere * 8f;

            Vector3 normale = position;
            Vector3 tangente = normale;
            // Normalisiert beide Vektoren und richtet Normale orthogonal an Tangente aus
            // https://docs.unity3d.com/ScriptReference/Vector3.OrthoNormalize.html
            Vector3.OrthoNormalize(ref normale, ref tangente);

            Quaternion rotation = Quaternion.LookRotation(tangente, normale);
            rotation *= Quaternion.Euler(-90, 0, 0);  // addiert -90° auf x-Achse

            tmpBaum = (GameObject)Instantiate(baumPrefab, position, rotation);

            // Baum positionieren
            //tmpBaum.transform.position = position;

            // https://forum.unity.com/threads/need-help-trying-to-populate-objects-on-a-sphere-randomly.184705
            // Baum ausrichten 


            tmpBaum.transform.parent = this.transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
