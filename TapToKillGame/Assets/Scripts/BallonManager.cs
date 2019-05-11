using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonManager : MonoBehaviour 
{
    //Don't put Instantiate script on a SpalmPrefab (use empty)
    //Movement script put on Balloon Prefab

    [SerializeField]
    private Transform _creationPoint = null;
    [SerializeField]
    private GameObject _goodBalloonPrefab = null;
    [SerializeField]
    private GameObject _badBalloonPrefab = null;
    [HideInInspector]
    private GameObject newBalloonInstance;

    private int balloonCurrentAmmmount = 0;

    [SerializeField]
    private int balloonmaxPossibleAmmount = 10;
    private float balloonLifeTime = 4f;

    private float randomValue;

    private void Start()
    {
        InvokeRepeating("Create", 1f, Random.Range(0.03f, 1.5f));
    }


    public void Create()
    {
        randomValue = Random.Range(1f, 10f);

        if (balloonCurrentAmmmount < balloonmaxPossibleAmmount)
        {
            // Red or Yellow
            if (randomValue > 5) 
            {
                newBalloonInstance = Instantiate(_goodBalloonPrefab, _creationPoint.position, _creationPoint.rotation);
            }
            else 
            {
                newBalloonInstance = Instantiate(_badBalloonPrefab, _creationPoint.position, _creationPoint.rotation);
            }

            ++balloonCurrentAmmmount;

            Destroy();
        }
    }

    public void Destroy()
    {
        Destroy(newBalloonInstance, balloonLifeTime);
        //must be GameObj, never RigidBody
        //NEVER put on a prefab

        --balloonCurrentAmmmount;
    }
}

