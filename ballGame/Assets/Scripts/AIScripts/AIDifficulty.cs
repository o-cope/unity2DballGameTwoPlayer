using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDifficulty : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private GameObject ballRef;
    [SerializeField] private int difficultyValue = 3;
    #endregion
    #region Private Variables
    private Vector2 ballPos;
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
        MediumDifficultyMove();
    }


    #region Methods
    private void MoveAI()
    {
        if (CheckX())
        {
            MoveOppositeDirection();
        }
        else
        {
            MoveCorrectDirection();
        }
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
    private void MoveOppositeDirection()
    {
        if (ballPos.y > transform.position.y)
        {
            rb.velocity = new Vector2(0, -moveSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0, moveSpeed);
        }
    }
    private bool Chance(int n)
    {
        return Random.Range(0, n - 1) == 0;
    }
    private void MediumDifficultyMove()
    {
        if (!Chance(difficultyValue))
        {
            MoveAI();
        }
    }
    private bool CheckX()
    {
        return ballPos.x > transform.position.x;
    }

    #endregion
}
