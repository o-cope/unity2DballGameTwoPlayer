using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlayerRight : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed;
    #endregion
    #region Private Variables
    private float yInput;
    private float xInput;
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
        MovePlayer();
    }

    #region Methods
    private void MovePlayer()
    {
        rb.velocity = new Vector2(xInput * moveSpeed, yInput * moveSpeed);
    }

    private void GetMoveInput()
    {
        yInput = Input.GetAxis("SpinPlayerRightVertical");
        xInput = Input.GetAxis("SpinPlayerRightHorizontal");
    }


    #endregion
}
