using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;
    public Text timeText;
    private float startTime;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;

    public float meter;
    public float position1;
    public float position2;





	// Use this for initialization
    void Start () {

        startTime = Time.time;

	
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }


	}
	


	// Update is called once per frame
	void Update () {
        //  meter = meter.SphericalDistance(position1, position2);

        //Berechnet Zeit - StartZeit
        //Ein Timer wird in dem Spiel angezeigt
        float t = Time.time - startTime;
        float minutes = ((int)t / 60);
        float seconds = (t % 60);
        timeText.text = minutes + " : " + Mathf.Round(seconds);

        if (scoreIncreasing)
        {
            //Addiert Score mit Punkte pro Sekunde mal Zeit pro Frame
            scoreCount += pointsPerSecond * Time.deltaTime;
           
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

  //      timeText.text += Time.deltaTime;

        //Score wird angezeigt
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "HighScore: " + Mathf.Round(hiScoreCount);
		
	}

    public float SphericalDistance(Vector3 position1, Vector3 position2)
{
    return Mathf.Acos(Vector3.Dot(position1, position2));
}

}


