using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalScoreLeft : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private TextMeshProUGUI rightScore;
    [SerializeField] private GameObject ballPos;
    [SerializeField] private GameObject playerLeft;
    [SerializeField] private GameObject playerLeftGoalKeeper;
    [SerializeField] private GameObject playerRight;
    [SerializeField] private GameObject playerRightGoalKeeper;  
    #endregion
    #region Private Variables
    private float scoreValue;
    #endregion
    #region Components
    BallMovement resetBall;
    #endregion

    private void Start()
    {
        resetBall = GameObject.FindGameObjectWithTag("ball").GetComponent<BallMovement>();
    }

    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            AddScore();
        }
    }

    #endregion

    #region Methods
    private void AddScore()
    {
        scoreValue++;
        rightScore.text = scoreValue.ToString();
        //play audio

        resetBall.rndSpeed = 0f;
        StartCoroutine(resetBall.BallMove());
        ballPos.transform.position = new Vector2(0, 0);

        playerLeft.transform.position = new Vector2(-4, 0);
        playerLeftGoalKeeper.transform.position = new Vector2(-9.5f, 0);
        playerRight.transform.position = new Vector2(4, 0);
        playerRightGoalKeeper.transform.position = new Vector2(9.5f, 0);
    }
    #endregion
}
