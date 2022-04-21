using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float rndSpeed;
    #endregion
    #region Private Variable
    private float speed;
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

    }

    private void FixedUpdate()
    {
        rb.velocity = rndSpeed * (rb.velocity.normalized);
    }


    #region Methods
    private void RndDirection()
    {
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction.Normalize();
        Vector2 newVelocity = rndSpeed * direction;
        transform.GetComponent<Rigidbody2D>().velocity = newVelocity;
    }


    #endregion

    #region Coroutines
    IEnumerator BallMove()
    {
        yield return new WaitForSeconds(1);
        RndDirection();
    }

    #endregion

}
