using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //For Scenes Loading

public class MenuScript : MonoBehaviour
{
    public  bool startGame = false;
    public static bool gameIsPaused = false;
    public GameObject startGameUI;

    [SerializeField]
    private GameObject pauseMenuUI;

    public GameObject gameOverPanel;
    private bool gameOverPanelActive = false;


    private void Start()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(false);
        gameOverPanel.SetActive(false);
        //startGameUI.SetActive(false);
    }


    void Update()
    {
        if (startGame == true)
        {
            startGameUI.SetActive(true);
            startGame = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape) & startGame == true & gameOverPanelActive == false)
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }


    public void StartGame()
    {
        startGame = true;
        Debug.Log("Start GAME");
    }

public void GameOver()
    {
        gameOverPanelActive = true;
        gameOverPanel.SetActive(true);
    } 

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

}