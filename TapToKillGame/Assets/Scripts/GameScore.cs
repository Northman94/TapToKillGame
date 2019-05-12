using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour 
{
    private static Text scoreText;
    private static int scoreNumb = 0;

    private Scene scene;

    void Start () 
    {
        scoreText = GetComponent<Text>();
        scene = SceneManager.GetActiveScene();
        UpdateScore();
	}

    public static void AddScore(int newScoreValue)
    {
        scoreNumb += newScoreValue;
        UpdateScore();
    }

    public static void SubstractScore(int newScoreValue)
    {
        if (scoreNumb > 0)
        {
            scoreNumb -= newScoreValue;
            UpdateScore();
        }
    }

    public static void UpdateScore () 
    {
        scoreText.text = " " + scoreNumb;
	}


    public void RestartGame()
    {
        scoreNumb = 0;
        UpdateScore();
        SceneManager.LoadScene(scene.name);
    }
}
