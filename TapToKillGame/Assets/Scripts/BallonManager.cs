using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonManager : MonoBehaviour 
{
    //Don't put Instantiate script on a SpalmPrefab (use empty)
    //Movement script put on Balloon Prefab

    [SerializeField]
    private Transform _creationPoint = null;
    private GameObject _balloonPrefab = null;
    private GameObject newBalloonInstance;

    private int balloonCurrentAmmmount = 0;

    [SerializeField]
    private int balloonmaxPossibleAmmount = 10;
    private float balloonLifeTime = 7f;

    private void Start()
    {
        InvokeRepeating("Create", 1f, Random.Range(0.05f, 2f));
    }


    public void Create()
    {
        if (balloonCurrentAmmmount < balloonmaxPossibleAmmount)
        {
            newBalloonInstance = Instantiate(_balloonPrefab, _creationPoint.position, _creationPoint.rotation);

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
