using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //For Scenes Loading

public class MenuScript : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    //public GameObject settingsUI;


    private void Awake()
    {
        pauseMenuUI.SetActive(false);
        //settingsUI.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                //settingsUI.SetActive(false);
                Pause();
            }
        }
    }


    #region Open/Close Menus

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
    /*
    public void SettingMenuOpen()
    {
        pauseMenuUI.SetActive(false);
        settingsUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void SettingsMenuClose()
    {
        settingsUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }*/
    #endregion


    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

}