using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerMove : MonoBehaviour
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
        yInput = Input.GetAxis("PlayerLeft");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0 , yInput * moveSpeed);
    }

}
