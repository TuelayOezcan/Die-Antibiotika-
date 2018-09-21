using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : MonoBehaviour {

    public GameObject pickupEffekt;
    public float duration = 4f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /* Wenn der Player das Speed Power up trifft*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));

        }
    }

    IEnumerator Pickup(Collider player)
    {
        //Cooler Effekt anwenden
        Instantiate(pickupEffekt, transform.position, transform.rotation);

        //Effekt auf den Player anwenden
        PlayerController playerSpeed = player.GetComponent<PlayerController>();
        playerSpeed.speed -= 10f;
       
        //Disable graphics
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        ScoreManager playerScore = GetComponent<ScoreManager>();
        playerScore.scoreCount += 10f;


        //Warte x Zeit
        yield return new WaitForSeconds(duration);

        //Effekt rueckgaengig machen
        playerSpeed.speed += 10f;

        //Object loeschen
        Destroy(gameObject);
        Debug.Log("Power up picked up!");

    }
}
