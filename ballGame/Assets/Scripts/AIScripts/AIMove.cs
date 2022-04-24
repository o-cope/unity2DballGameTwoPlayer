using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector2 ballPos;
    [SerializeField] private GameObject ballRef;
    #endregion
    #region Private Variable
    private float yInput;
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
        if (ballPos.y > transform.position.y)
        {
            rb.velocity = new Vector2(0, 1 * moveSpeed);
        }
        else if (ballPos.y + 0.2 > transform.position.y || ballPos.y - 0.2 > transform.position.y)
        {
            rb.velocity = new Vector2(0, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, -1 * moveSpeed);
        }
    }

    private void UpdateBallPos()
    {
        ballPos = new Vector2(ballRef.transform.position.x, ballRef.transform.position.y);
    }
    #endregion
}
