using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDown : MonoBehaviour {

    public GameObject pickupEffekt;
    public float duration = 4f;


	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }
    /*

    void SetTrue ()
    {
        GetComponent<Collider>().isTrigger = true;
    }
*/
  
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));

        }
    }

    IEnumerator Pickup(Collider player)
    {
        //Coolen Effekt anwenden
        Instantiate(pickupEffekt, transform.position, transform.rotation);


        //Disable graphics
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
       

        //Random Effekt auf den Player anwenden
        int randomNumber = Random.Range(0, 3);
        if (randomNumber==0)
        {
            Debug.Log("Möglichkeit EINS");
            GameObject.Find("PowerUp").transform.GetChild(1).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            GameObject.Find("PowerUp").transform.GetChild(1).gameObject.SetActive(true);

            PlayerController playerSpeedlower = player.GetComponent<PlayerController>();
            playerSpeedlower.speed -= 10f;

            //Warte x Zeit
            yield return new WaitForSeconds(duration);
            //Effekt rueckgaengig machen
            playerSpeedlower.speed += 10f;
        }

        else if(randomNumber==1)
        {
            Debug.Log("Möglichkeit ZWEI");
            GameObject.Find("PowerUp").transform.GetChild(0).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            GameObject.Find("PowerUp").transform.GetChild(0).gameObject.SetActive(false);

            PlayerController playerSpeedhigher = player.GetComponent<PlayerController>();
            playerSpeedhigher.speed += 10f;
           

            yield return new WaitForSeconds(duration);
            //Effekt rueckgaengig machen
            playerSpeedhigher.speed -= 10f;
        }

        else if(randomNumber==2)
        {
            Debug.Log("Möglichkeit DREI");
            GameObject.Find("PowerUp").transform.GetChild(2).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            GameObject.Find("PowerUp").transform.GetChild(2).gameObject.SetActive(false);
        }



        //     ScoreManager playerScore = GetComponent<ScoreManager>();
        //       playerScore.scoreCount += 10f;

        //Object loeschen
        Destroy(gameObject);
        Debug.Log("Power up picked up!");

    }


}
