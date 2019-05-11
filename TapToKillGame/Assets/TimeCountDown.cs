using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountDown : MonoBehaviour 
{
    private Text time;
    [SerializeField]
    private float timeCountdown = 60;
    [SerializeField]
    private MenuScript menuScript;
    

    void Start()
    {
        time = GetComponent<Text>();
    }


    private void Update()
    {
        if (timeCountdown > 0)
        {
            timeCountdown -= Time.deltaTime;

            UpdateTime();
        }
        else
        {
            Time.timeScale = 0f;
            menuScript.GameOver();
        }
    }


    private void UpdateTime()
    {
        time.text = "Time: " + (int)timeCountdown;
    }

}
