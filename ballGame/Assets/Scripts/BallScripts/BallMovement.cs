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
    #region Private Variables
    #endregion
    #region Components
    Rigidbody2D rb;
    AudioSource bounceClip;
    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bounceClip = GetComponent<AudioSource>();
        StartCoroutine(BallMove());
    }

    private void Update()
    {
        ResetBallDirection();
    }

    private void FixedUpdate()
    {
        BallSpeedConstant();
    }


    #region Collisions
    private void OnCollisionEnter2D(Collision2D other)
    {
        bounceClip.Play();
    }
    #endregion


    #region Methods

    private void BallSpeedConstant()
    {
        rb.velocity = rndSpeed * (rb.velocity.normalized);
    }

    public void BallRndDirection()
    {
        rndSpeed = 5f;
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.1f, 0.1f));
        direction.Normalize();
        Vector2 newVelocity = rndSpeed * direction;
        transform.GetComponent<Rigidbody2D>().velocity = newVelocity;
    }

    private void ResetBallDirection()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rndSpeed = 0;
            StartCoroutine(BallMove());
        }
    }




    #endregion

    #region Coroutines
    public IEnumerator BallMove()
    {
        yield return new WaitForSeconds(1);
        BallRndDirection();
    }

    #endregion

}
