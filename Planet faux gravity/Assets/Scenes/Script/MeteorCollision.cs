using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollision : MonoBehaviour {

    public float speed;
    public GameObject player;
    public FauxGravityAttractor gravity;

    // Use this for initialization
    void Start () {
        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.useGravity = true;
        //rb.freezeRotation = true;
    }
	
	// Update is called once per frame
    void Update () {
       
        //transform.Translate(new Vector3(0, -speed, 0 * Time.deltaTime));
        //gravity.ApplyGravity(transform);

    }

    /*
    IEnumerator SpawnMeteor()
    {
        //Zufallspunkt auf der Sphere
        Vector3 pos = Random.onUnitSphere * 10;
        // Vector3 normale = pos;
        // Vector3 tangente = normale;
        //  Vector3.OrthoNormalize(ref normale, ref tangente);

        //Rotation
        //   Quaternion rotation = Quaternion.LookRotation(tangente, normale);
        // rotation *= Quaternion.Euler(-90, 0, 0);

        //In Gameobject casten
        GameObject meteor = (GameObject)Instantiate(meteorPrefab, pos, Quaternion.identity);
        meteor.transform.position = pos;
        // meteor.transform.parent = this.transform;


        yield return new WaitForSeconds(3f);
        StartCoroutine(SpawnMeteor());


    }*/



    private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.name == "Planet")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Player")
        {
            Application.Quit();
           
        }
	}
}
