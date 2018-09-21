using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text timeText;
    public Text hiScoreText;

    public float scoreCount;
    public float timeCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;



	// Use this for initialization
	void Start () {
		
	}
	


	// Update is called once per frame
	void Update () {


        if (scoreIncreasing)
        {
            //Addiert Score mit Punkte pro Sekunde mal Zeit pro Frame
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }

  //      timeText.text += Time.deltaTime;

        //Score wird angezeigt
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        timeText.text = "Time: " + Time.deltaTime;
        hiScoreText.text = "HighScore: " + Mathf.Round(hiScoreCount);
		
	}
}
