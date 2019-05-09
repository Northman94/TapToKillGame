using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonInteraction : MonoBehaviour 
{
    public GameObject balloon = null;

    public int newScoreValue = 1;


    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pop = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll = balloon.GetComponent<Collider2D>();
            //or CapsuleCollider2D

            if (coll.OverlapPoint(pop))
            {
                Debug.Log("byMouseExplosion!!!");
                Destroy(balloon, 0.1f);

                GameScore.AddScore(newScoreValue);
            }
            else if (Input.touchCount == 1)
            {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(wp.x, wp.y);

                if (coll == Physics2D.OverlapPoint(touchPos))
                {
                    Debug.Log("byFingerExplosion!");
                    Destroy(balloon, 0.1f);

                    GameScore.AddScore(newScoreValue);
                }

            }

        }
    }
}
