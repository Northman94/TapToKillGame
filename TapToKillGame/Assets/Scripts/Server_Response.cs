using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server_Response : MonoBehaviour 
{
    private bool myStatus;
    [SerializeField]
    ServerConnection serverConnection;

    private void Awake()
    {
        serverConnection = new ServerConnection();
        serverConnection = FindObjectOfType<ServerConnection>();
    }

    public void tellServerStatus()
    {
        changeMyStatus(myStatus);
        Debug.Log("= - = - = - = - = - = - = - = - = - = - = - StatusOnServer:  " + myStatus);
        returnStatusOnClient();
    }

    private void changeMyStatus(bool Status)
    {
       myStatus = true;
    }

    private void returnStatusOnClient()
    {
        serverConnection.ServerResonse(myStatus);
    }

}
