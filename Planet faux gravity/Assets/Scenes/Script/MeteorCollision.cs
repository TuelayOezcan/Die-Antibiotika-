using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollision : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Löschen von Meteoren, die manchmal durch den Planeten durchfliegen
        float distance = Vector3.Distance(Vector3.zero, this.transform.position);

        if (distance < 0.5f)
            DeleteMeteor();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Virus")
        {
            //Debug.Log("Planet - PowerUp hit");
            StartCoroutine(DeleteMeteor());
        }

        // (Clone) verwenden bei einem Object(Clone)
        if (collision.gameObject.name == "PowerUp(Clone)")
        {
            //Debug.Log("Meteor - PowerUp hit");
            StartCoroutine(DeleteMeteor());
        }

        if (collision.gameObject.name == "Baum1(Clone)")
        {
            //Debug.Log("Meteor - Tree hit");
            StartCoroutine(DeleteMeteor());
        }

        if (collision.gameObject.name == "Player")
        {

            //Debug.Log("Meteor - Player hit");
            StartCoroutine(DeleteMeteor());
            FindObjectOfType<GameManager>().Endgame();

        }
    }

    // Regelt den Ablauf, wie Meteoriten gelöscht werden
    IEnumerator DeleteMeteor()
    {
        // Verschiebe Meteor ins innere des Planeten
        gameObject.transform.position = Vector3.zero;

        // Freezen aller Bewegungen (somit auch keine Collision mehr, Meteore schießen sich sonst gegenseitig aus dem Planeten heraus).
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        // Warte einige Sekunden, bis der Smoketrail verschwunden ist.
        yield return new WaitForSeconds(5.0f);

        // Löschen des Meteors
        Destroy(gameObject);
    }

  

}
