using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed;
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

    private void Update()
    {
        GetMoveInput();
    }

    private void FixedUpdate()
    {
        MoveAI();
    }


    //figure out ball.y and AI.y
    //simulate keypress for movement based on correct direction
    //apply movement

    #region Methods
    private void MoveAI()
    {
        rb.velocity = new Vector2(0, yInput * moveSpeed);
        Debug.Log(rb.velocity);
    }

    private void GetMoveInput()
    {
        yInput = Input.GetAxis("PlayerRight");
    }
    #endregion
}
