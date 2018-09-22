using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gamesHasEnded = false;
    public float restartTime = 40f;

    public GameObject gameOverUI;
    public GameObject scoreUI;

    public void completeLevel()
    {
        Debug.Log("FINISH");
    }


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
