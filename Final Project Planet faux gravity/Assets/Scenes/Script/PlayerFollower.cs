using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{

    // Folge dem Spieler
    public GameObject followObject;

    // Random Offset
    private Vector3 offset;

    // Meteor Prefab
    public GameObject meteorPrefab;

    // Spawn interval
    private float SpawnTime = 1.0f;

    // Use this for initialization
    void Start()
    {
        // Einamliger Aufruf der Coroutine
        StartCoroutine(SpawnMeteor());
    }

    // Erzeugt Meteore
    IEnumerator SpawnMeteor()
    {
        // Zufallspunkt auf der Sphere
        Vector3 pos = followObject.transform.position * Random.Range(5.0f, 10.0f);

        // Meteor instanziieren
        GameObject meteor = (GameObject)Instantiate(meteorPrefab, pos, Quaternion.identity);
        meteor.transform.parent = this.transform;

        // Alle 3 sec ein Meteor
        yield return new WaitForSeconds(SpawnTime);

        // Loop SpawnMeteor Coroutine
        StartCoroutine(SpawnMeteor());
    }


    // Update is called once per frame
    void Update()
    {

    }
}
