using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerMove : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateMax;
    #endregion
    #region Private Variables
    private float yInput;
    private float rotateInput;
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
        GetRotateInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }

    #region Methods
    private void MovePlayer()
    {
        rb.velocity = new Vector2(0, yInput * moveSpeed);
    }

    private void GetMoveInput()
    {
        yInput = Input.GetAxis("PlayerRight");
    }

    private void GetRotateInput()
    {
        rotateInput = Input.GetAxis("PlayerRightRotate");
    }

    private void RotatePlayer()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotateInput * rotateMax);
    }
    #endregion

}
