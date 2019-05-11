using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //For Scenes Loading

public class MenuScript : MonoBehaviour
{
    public static bool startGame = false;
    public static bool gameIsPaused = false;
    public static GameObject startGameUI;

    [SerializeField]
    private GameObject pauseMenuUI;


    private void Awake()
    {
        startGameUI = new GameObject();
        startGameUI = FindObjectOfType<GameObject>();
    }

    private void Start()
    {
        startGameUI.SetActive(false);
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(false);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) & startGame == true)
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


    public static void StarGame()
    {
        startGame = true;
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

}