using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGKMove : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private Vector2 ballPos;
    [SerializeField] private GameObject ballRef;
    #endregion
    #region Private Variables
    #endregion
    #region Components
    Rigidbody2D rb;
    #endregion
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } //Onstartup executes



    private void FixedUpdate()
    {
        UpdateBallPos();
        MoveAI();
    }


    #region Methods
    private void MoveAI()
    {
        MoveCorrectDirection();
    }

    private void UpdateBallPos()
    {
        ballPos = new Vector2(ballRef.transform.position.x, ballRef.transform.position.y);
    }

    private void MoveCorrectDirection()
    {
        if (ballPos.y > transform.position.y)
        {
            rb.velocity = new Vector2(0, moveSpeed);
        }

        else if (ballPos.y + 0.2 > transform.position.y || ballPos.y - 0.2 > transform.position.y)
        {
            rb.velocity = new Vector2(0, 0);
        }

        else
        {
            rb.velocity = new Vector2(0, -moveSpeed);
        }
    }
    #endregion
}
