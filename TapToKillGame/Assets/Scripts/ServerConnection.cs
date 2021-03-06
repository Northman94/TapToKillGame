﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerConnection : MonoBehaviour 
{
    private bool isServerAwailable = false;
    [SerializeField]
    Server_Response server_Response;
    [SerializeField]
    private MenuScript menuScript;
   
     private void Awake()
    {
        server_Response = new Server_Response();

        server_Response = FindObjectOfType<Server_Response>();

        isServerConnetionValid();
    }

    public void isServerConnetionValid()
    {
        Debug.Log("= - = - = - = - = - = - = - = - = - = - = - ServerStatusRequested");
        server_Response.tellServerStatus();
    }


    public void ServerResonse(bool _status)
    {
        isServerAwailable = _status;
        Debug.Log("= - = - = - = - = - = - = - = - = - = - = - ServerStatusReceived:  " + isServerAwailable);

        if (_status)
        {
            menuScript.StartGame();
        }
    }

}
