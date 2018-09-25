using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Das Youtube Video: 
 * von Brackeys wurde genutzt. Letzter Zugriff: 
*/


public class GameManager : MonoBehaviour {

    //setzt gameHasEnded auf false by default
    bool gamesHasEnded = false;
    // Die Zeit, die gewartet wird, bis das Spiel restartet wird
    public float restartTime = 4f;

    //UI Variablen
    public GameObject gameOverUI;
    public GameObject scoreUI;

    //Methode, um das Spiel enden zu lassen
    //GameOver Text wird angezeigt
    //Die ScoreUI wird nicht mehr angezeigt
    public void Endgame()
    {

        if (gamesHasEnded == false)
        {
            gamesHasEnded = true;
            Debug.Log("GAME OVER");
            gameOverUI.SetActive(true);
            scoreUI.SetActive(false);

            //Restart game
            Invoke("Restart", restartTime);
        }

    }

    void Restart()
    {
        //Mit dem SceneManager die Szene namens SampleScene laden
        //GetActiveScene() nicht notwendig, da nur eine Szene vorhanden ist
        SceneManager.LoadScene("SampleScene");

    }



}
