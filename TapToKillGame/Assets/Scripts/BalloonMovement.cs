using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour 
{
	void Update () 
    	{
        this.transform.Translate(Vector2.up * Time.deltaTime * 5);
	}
}
