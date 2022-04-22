using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalScoreRight : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private TextMeshProUGUI leftScore;
    [SerializeField] private GameObject ballPos;
    [SerializeField] private GameObject playerLeft;
    [SerializeField] private GameObject playerLeftGK;
    [SerializeField] private GameObject playerRight;
    [SerializeField] private GameObject playerRightGK;
    #endregion
    #region Private Variables
    private float scoreValue;
    private Vector2 playerLeftPosition;
    private Vector2 playerLeftGKPosition;
    private Vector2 playerRightPosition;
    private Vector2 playerRightGKPosition;

    #endregion
    #region Components
    BallMovement resetBall;
    #endregion

    private void Start()
    {
        resetBall = GameObject.FindGameObjectWithTag("ball").GetComponent<BallMovement>();
        playerLeftGKPosition = playerLeftGK.transform.position;
        playerLeftPosition = playerLeft.transform.position;
        playerRightPosition = playerRight.transform.position;
        playerRightGKPosition = playerRightGK.transform.position;
    }

    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            AddScore();
            DeleteWildcards();
        }
    }

    #endregion

    #region Methods
    private void AddScore()
    {
        scoreValue++;
        leftScore.text = scoreValue.ToString();
        //play audio

        resetBall.rndSpeed = 0f;
        StartCoroutine(resetBall.BallMove());
        ballPos.transform.position = new Vector2(0, 0);

        playerLeft.transform.position = playerLeftPosition;
        playerLeftGK.transform.position = playerLeftGKPosition;
        playerRight.transform.position = playerRightPosition;
        playerRightGK.transform.position = playerRightGKPosition;
    }

    private void DeleteWildcards()
    {
        Destroy(GameObject.FindGameObjectWithTag("yellowWildcard"));
    }
    #endregion


}
