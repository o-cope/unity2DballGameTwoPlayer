using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildcardTeleport : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private GameObject spawnRange;
    #endregion
    #region Private Variables
    #endregion
    #region Components
    //BallMovement rndDirection;
    #endregion

    private void Start()
    {
        //rndDirection = GameObject.FindGameObjectWithTag("ball").GetComponent<BallMovement>();
    }


    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wildcardTeleport"))
        {
            BallTeleport();
            Destroy(other.gameObject);
        }
    }
    #endregion

    #region Methods
    private void BallTeleport()
    {
        MeshCollider c = spawnRange.GetComponent<MeshCollider>();
        float screenX, screenY;

        screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
        screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);

        Vector2 teleportPos;
        teleportPos = new Vector2(screenX, screenY);
        transform.position = teleportPos;
        //rndDirection.BallMove
    }
    #endregion 
}
