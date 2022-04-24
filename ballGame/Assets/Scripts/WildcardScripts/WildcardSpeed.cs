using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildcardSpeed : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variables
    private float tempSpeed;
    #endregion
    #region Components
    BallMovement ballSpeed;
    #endregion

    private void Start()
    {
        ballSpeed = GameObject.FindGameObjectWithTag("ball").GetComponent<BallMovement>();
        tempSpeed = ballSpeed.rndSpeed;
    }
     
    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wildcardSpeed"))
        {
            StartCoroutine(IncreaseSpeed());
            Destroy(other.gameObject);
        }
    }
    #endregion

    #region Methods
    #endregion

    #region Coroutines
    IEnumerator IncreaseSpeed()
    {
        ballSpeed.rndSpeed = ballSpeed.rndSpeed * 1.5f;
        yield return new WaitForSeconds(1.5f);
        ballSpeed.rndSpeed = tempSpeed;
    }
    #endregion
}
