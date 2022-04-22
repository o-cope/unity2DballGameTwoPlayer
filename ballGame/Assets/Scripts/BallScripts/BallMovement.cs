using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    #region Public Variables
    public float rndSpeed;
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variable
    #endregion
    #region Components
    Rigidbody2D rb;
    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(BallMove());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rndSpeed = 0;
            StartCoroutine(BallMove());
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = rndSpeed * (rb.velocity.normalized);
    }


    #region Methods
    private void RndDirection()
    {
        rndSpeed = 5f;
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.1f, 0.1f));
        direction.Normalize();
        Vector2 newVelocity = rndSpeed * direction;
        transform.GetComponent<Rigidbody2D>().velocity = newVelocity;
    }


    #endregion

    #region Coroutines
    public IEnumerator BallMove()
    {
        yield return new WaitForSeconds(1);
        RndDirection();
    }

    #endregion

}
