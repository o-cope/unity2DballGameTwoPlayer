using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildcardDirection : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variables
    #endregion
    #region Components
    BallMovement rndDirection;
    #endregion

    private void Start()
    {
        rndDirection = GameObject.FindGameObjectWithTag("ball").GetComponent<BallMovement>();
    }

    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wildcardDirection"))
        {
            RandomDirection();
            Destroy(other.gameObject);
        }
    }
    #endregion

    #region Method
    private void RandomDirection()
    {
        rndDirection.BallRndDirection();
    }
    #endregion
}
