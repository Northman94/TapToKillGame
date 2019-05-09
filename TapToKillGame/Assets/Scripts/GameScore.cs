using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour 
{
    private static Text scoreText;
    private static int scoreNumb = 0;

    //private bool w;



	void Start () 
    {
        scoreText = GetComponent<Text>();
        UpdateScore();
	}

    public static void AddScore(int newScoreValue)
    {
        scoreNumb += newScoreValue;
        UpdateScore();
    }

    public static void UpdateScore () 
    {
        scoreText.text = "Score" + scoreNumb;
	}
}
