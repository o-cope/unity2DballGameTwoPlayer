using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerNoRotationLock : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed;
    #endregion
    #region Private Variables
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
        MovePlayer();
    }

    #region Methods
    private void MovePlayer()
    {
        rb.velocity = new Vector2(0, yInput * moveSpeed);
    }

    private void GetMoveInput()
    {
        yInput = Input.GetAxis("PlayerLeft");
    }
    #endregion
}
