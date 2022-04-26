using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildcardScale : MonoBehaviour
{
    #region Public Variables
    [HideInInspector]
    public GameObject lastHit;
    #endregion
    #region Inspector Variables
    [SerializeField] private GameObject playerLeft;
    [SerializeField] private GameObject playerLeftGK;
    [SerializeField] private GameObject playerRight;
    [SerializeField] private GameObject playerRightGK;
    [SerializeField] private float timeScaledUp;
    #endregion
    #region Private Variables
    private float playerLeftX, playerLeftY;
    private float playerRightX, playerRightY;

    private float playerLeftY2, playerRightY2;
    #endregion
    #region Components
    #endregion

    private void Start()
    {
        GetScales();
    }

    #region Method
    private void GetScales()
    {
        playerLeftX = playerLeft.transform.localScale.x;
        playerLeftY = playerLeft.transform.localScale.y;
        playerRightX = playerRight.transform.localScale.x;
        playerRightY = playerRight.transform.localScale.y;


        playerLeftY2 = playerLeftY * 2;
        playerRightY2 = playerRightY * 2;
    }
    #endregion

    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wildcardScale") && lastHit == playerLeft)
        {
            StartCoroutine(ScaleUpLeft());
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("wildcardScale") && lastHit == playerRight)
        {
            StartCoroutine(ScaleUpRight());
            Destroy(other.gameObject);
        }
    }
    #endregion

    #region Collisions
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("playerLeft") || other.gameObject.CompareTag("playerLeftGK"))
        {
            lastHit = playerLeft;
        }
        else if (other.gameObject.CompareTag("playerRight") || other.gameObject.CompareTag("playerRightGK"))
        {
            lastHit = playerRight;
        }
    }
    #endregion

    #region Coroutines
    IEnumerator ScaleUpLeft()
    {
        playerLeft.transform.localScale = new Vector2(playerLeftX, playerLeftY2);
        yield return new WaitForSeconds(timeScaledUp);
        playerLeft.transform.localScale = new Vector2(playerLeftX, playerLeftY);
    }

    IEnumerator ScaleUpRight()
    {
        playerRight.transform.localScale = new Vector2(playerRightX, playerRightY2);
        yield return new WaitForSeconds(timeScaledUp);
        playerRight.transform.localScale = new Vector2(playerRightX, playerRightY);
    }

    #endregion


}
