using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] schauer; 
    public Vector3 spawnValues; //Vektorenwert in der Umgebung,
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randMeteor;

	// Use this for initialization
	void Start () {

        StartCoroutine(waitSpawner());

	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop) //true forever
        {
            randMeteor = Random.Range(0, 2);

            //die neue spawn position wird berechnet mit einem neuen Vektor. Random Werte der spawnvalue Variable werden in spawnPosition gespeichert
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),1,Random.Range(-spawnValues.z, spawnValues.z));


            Instantiate(schauer[randMeteor], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
