using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{

    // Global Prefab
    public GameObject meteorPrefab;

    // Spawn interval
    public float SpawnTime;

    // Use this for initialization
    void Start()
    {

        // Einamliger Aufruf der Coroutine
        StartCoroutine(SpawnMeteor());
    }

    // Erzeugt Meteore
    IEnumerator SpawnMeteor()
    {
        for (int i = 0; i < 15; i++)
        {
            // Zufallspunkt auf der Sphere
            Vector3 pos = Random.onUnitSphere * Random.Range(30.0f, 60.0f);

            // Meteor instanziieren
            GameObject meteor = (GameObject)Instantiate(meteorPrefab, pos, Quaternion.identity);
            meteor.transform.parent = this.transform;
        }

        // Alle 3 sec ein Meteor
        yield return new WaitForSeconds(SpawnTime);

        // Loop SpawnMeteor Coroutine
        StartCoroutine(SpawnMeteor());
    }

    // Update is called once per frame
    void Update()
    {

        // Gravitation handled by faux gravity
    }
}


/*float SphericalDistance(Vector3 position1, Vector3 position2)
{
    return Mathf.Acos(Vector3.Dot(position1, position2));
}*/