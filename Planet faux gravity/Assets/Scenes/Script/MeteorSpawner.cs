using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

    public GameObject meteorPrefab;
    private Vector3 pos;
    private GameObject meteor;
    private Quaternion rotation;
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnMeteor());
	}
	
    IEnumerator SpawnMeteor()
    {
        //Zufallspunkt auf der Sphere
        pos = Random.onUnitSphere * 17;
        Vector3 normale = pos;
        Vector3 tangente = normale;
        Vector3.OrthoNormalize(ref normale, ref tangente);

        //Rotation
        rotation = Quaternion.LookRotation(tangente, normale);
       // rotation *= Quaternion.Euler(-90, 0, 0);

        //In Gameobject casten
        meteor = (GameObject) Instantiate(meteorPrefab,pos,Quaternion.identity);
        meteor.transform.position = pos;
       // meteor.transform.parent = this.transform;


        yield return new WaitForSeconds(3f);
        StartCoroutine(SpawnMeteor());


                       }


	// Update is called once per frame
	void Update () {
        Vector3 dir = rotation.eulerAngles;
        meteor.transform.position += (dir * 0.1f);
	}
}
