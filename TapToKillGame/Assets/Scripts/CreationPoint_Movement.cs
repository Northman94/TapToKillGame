using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationPoint_Movement : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position = new Vector3(Random.Range(-4.5f, 6f), -2f, 3.5f); // X / Y / Z
    }
}

	
